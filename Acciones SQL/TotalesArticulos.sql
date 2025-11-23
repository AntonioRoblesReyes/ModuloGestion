-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SELECT     Proyectos.Id_Proyecto, DetalleHabitacion.IdArticulo, SUM(DetalleHabitacion.Cantidad) AS Expr1, DetalleHabitacion.IdHAbitacion
FROM         DetalleHabitacion INNER JOIN
                      Habitacion ON DetalleHabitacion.IdHAbitacion = Habitacion.IdHAbitacion INNER JOIN
                      Proyectos ON Habitacion.Id_Proyecto = Proyectos.Id_Proyecto
WHERE     (Proyectos.Id_Proyecto = @Id_Proyecto) AND (DetalleHabitacion.IdArticulo = @IdArticulo)
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
