/*
Script para guardar cabecera + detalle de FacturaMontajeB11 usando TVP.
Incluye:
  1) CREATE TYPE dbo.TipoDetalleFacturaB11
  2) CREATE OR ALTER PROCEDURE dbo.sp_FacturaMontajeB11_Upsert
*/

IF TYPE_ID(N'dbo.TipoDetalleFacturaB11') IS NULL
BEGIN
    CREATE TYPE dbo.TipoDetalleFacturaB11 AS TABLE
    (
        IdDetalle                NVARCHAR(25) NOT NULL,
        Descripcion              NVARCHAR(500) NULL,
        Cantidad                 DECIMAL(18, 4) NOT NULL,
        Precio                   DECIMAL(18, 4) NOT NULL,
        Total                    DECIMAL(18, 4) NOT NULL
    );
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_FacturaMontajeB11_Upsert
    @IdFacturaB11        NVARCHAR(25),
    @IdEmpresaMontaje    NVARCHAR(25),
    @Fecha               DATE,
    @NCF                 NVARCHAR(25),
    @SubTotal            DECIMAL(18, 2),
    @ITBIS               DECIMAL(18, 2),
    @RetencionISR        DECIMAL(18, 2),
    @Total               DECIMAL(18, 2),
    @Detalle             dbo.TipoDetalleFacturaB11 READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRAN;

        IF EXISTS (
            SELECT 1
            FROM dbo.FacturaMontajeB11
            WHERE IdFacturaB11 = @IdFacturaB11
        )
        BEGIN
            UPDATE dbo.FacturaMontajeB11
               SET IdEmpresaMontaje = @IdEmpresaMontaje,
                   Fecha = @Fecha,
                   NCF = @NCF,
                   SubTotal = @SubTotal,
                   ITBIS = @ITBIS,
                   RetencionISR = @RetencionISR,
                   Total = @Total
             WHERE IdFacturaB11 = @IdFacturaB11;
        END
        ELSE
        BEGIN
            INSERT INTO dbo.FacturaMontajeB11
            (
                IdFacturaB11,
                IdEmpresaMontaje,
                Fecha,
                NCF,
                SubTotal,
                ITBIS,
                RetencionISR,
                Total
            )
            VALUES
            (
                @IdFacturaB11,
                @IdEmpresaMontaje,
                @Fecha,
                @NCF,
                @SubTotal,
                @ITBIS,
                @RetencionISR,
                @Total
            );
        END;

        DELETE FROM dbo.FacturaMontajeB11Detalle
         WHERE IdFacturaB11 = @IdFacturaB11;

        INSERT INTO dbo.FacturaMontajeB11Detalle
        (
            IdDetalle,
            IdFacturaB11,
            Descripcion,
            Cantidad,
            Precio,
            Total
        )
        SELECT d.IdDetalle,
               @IdFacturaB11,
               d.Descripcion,
               d.Cantidad,
               d.Precio,
               d.Total
          FROM @Detalle d;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH;
END;
GO
