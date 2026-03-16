/*
    ModuloGestion.Next - Esquema mínimo de autenticación/sesión
    Objetivo: reemplazar login legado manteniendo comportamiento funcional por categoría.
*/

IF NOT EXISTS (SELECT 1 FROM sys.schemas WHERE name = 'auth')
BEGIN
    EXEC('CREATE SCHEMA auth');
END
GO

IF OBJECT_ID('auth.Usuarios', 'U') IS NULL
BEGIN
    CREATE TABLE auth.Usuarios (
        IdUsuario            INT IDENTITY(1,1) PRIMARY KEY,
        Usuario              NVARCHAR(50) NOT NULL,
        ClaveHash            VARBINARY(64) NOT NULL,
        SalHash              VARBINARY(32) NOT NULL,
        NombreCompleto       NVARCHAR(150) NOT NULL,
        Categoria            INT NOT NULL, -- compatibilidad con legado (1,2,3,4)
        Activo               BIT NOT NULL CONSTRAINT DF_Usuarios_Activo DEFAULT(1),
        IntentosFallidos     INT NOT NULL CONSTRAINT DF_Usuarios_Intentos DEFAULT(0),
        UltimoAccesoUtc      DATETIME2(0) NULL,
        CreadoEnUtc          DATETIME2(0) NOT NULL CONSTRAINT DF_Usuarios_Creado DEFAULT SYSUTCDATETIME(),
        ModificadoEnUtc      DATETIME2(0) NULL,
        CONSTRAINT UQ_Usuarios_Usuario UNIQUE (Usuario),
        CONSTRAINT CK_Usuarios_Categoria CHECK (Categoria IN (1,2,3,4))
    );
END
GO

IF OBJECT_ID('auth.Roles', 'U') IS NULL
BEGIN
    CREATE TABLE auth.Roles (
        IdRol                INT IDENTITY(1,1) PRIMARY KEY,
        Codigo               NVARCHAR(50) NOT NULL,
        Nombre               NVARCHAR(100) NOT NULL,
        Activo               BIT NOT NULL CONSTRAINT DF_Roles_Activo DEFAULT(1),
        CONSTRAINT UQ_Roles_Codigo UNIQUE (Codigo)
    );
END
GO

IF OBJECT_ID('auth.UsuarioRol', 'U') IS NULL
BEGIN
    CREATE TABLE auth.UsuarioRol (
        IdUsuario            INT NOT NULL,
        IdRol                INT NOT NULL,
        AsignadoEnUtc        DATETIME2(0) NOT NULL CONSTRAINT DF_UsuarioRol_Asignado DEFAULT SYSUTCDATETIME(),
        CONSTRAINT PK_UsuarioRol PRIMARY KEY (IdUsuario, IdRol),
        CONSTRAINT FK_UsuarioRol_Usuario FOREIGN KEY (IdUsuario) REFERENCES auth.Usuarios (IdUsuario),
        CONSTRAINT FK_UsuarioRol_Rol FOREIGN KEY (IdRol) REFERENCES auth.Roles (IdRol)
    );
END
GO

IF OBJECT_ID('auth.PermisosMenu', 'U') IS NULL
BEGIN
    CREATE TABLE auth.PermisosMenu (
        IdPermisoMenu        INT IDENTITY(1,1) PRIMARY KEY,
        CodigoMenu           NVARCHAR(100) NOT NULL,
        Descripcion          NVARCHAR(200) NOT NULL,
        Activo               BIT NOT NULL CONSTRAINT DF_PermisosMenu_Activo DEFAULT(1),
        CONSTRAINT UQ_PermisosMenu_Codigo UNIQUE (CodigoMenu)
    );
END
GO

IF OBJECT_ID('auth.RolPermisoMenu', 'U') IS NULL
BEGIN
    CREATE TABLE auth.RolPermisoMenu (
        IdRol                INT NOT NULL,
        IdPermisoMenu        INT NOT NULL,
        Permitido            BIT NOT NULL CONSTRAINT DF_RolPermisoMenu_Permitido DEFAULT(1),
        CONSTRAINT PK_RolPermisoMenu PRIMARY KEY (IdRol, IdPermisoMenu),
        CONSTRAINT FK_RolPermisoMenu_Rol FOREIGN KEY (IdRol) REFERENCES auth.Roles (IdRol),
        CONSTRAINT FK_RolPermisoMenu_Permiso FOREIGN KEY (IdPermisoMenu) REFERENCES auth.PermisosMenu (IdPermisoMenu)
    );
END
GO

IF OBJECT_ID('auth.SesionesUsuario', 'U') IS NULL
BEGIN
    CREATE TABLE auth.SesionesUsuario (
        IdSesion             BIGINT IDENTITY(1,1) PRIMARY KEY,
        IdUsuario            INT NOT NULL,
        FechaInicioUtc       DATETIME2(0) NOT NULL CONSTRAINT DF_Sesiones_Inicio DEFAULT SYSUTCDATETIME(),
        FechaFinUtc          DATETIME2(0) NULL,
        NombreEquipo         NVARCHAR(100) NULL,
        IpOrigen             NVARCHAR(45) NULL,
        Resultado            NVARCHAR(20) NOT NULL,
        Observacion          NVARCHAR(250) NULL,
        CONSTRAINT FK_SesionesUsuario_Usuario FOREIGN KEY (IdUsuario) REFERENCES auth.Usuarios (IdUsuario),
        CONSTRAINT CK_SesionesUsuario_Resultado CHECK (Resultado IN ('OK','FAIL','LOCKED'))
    );
END
GO

/* SP recomendado para login (sin exponer hash a UI) */
CREATE OR ALTER PROCEDURE auth.sp_Login
    @Usuario NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        u.IdUsuario,
        u.Usuario,
        u.NombreCompleto,
        u.Categoria,
        u.Activo,
        u.ClaveHash,
        u.SalHash,
        u.IntentosFallidos
    FROM auth.Usuarios u
    WHERE u.Usuario = @Usuario;
END
GO

CREATE OR ALTER PROCEDURE auth.sp_RegistrarSesion
    @IdUsuario INT,
    @Resultado NVARCHAR(20),
    @NombreEquipo NVARCHAR(100) = NULL,
    @IpOrigen NVARCHAR(45) = NULL,
    @Observacion NVARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO auth.SesionesUsuario
    (
        IdUsuario,
        Resultado,
        NombreEquipo,
        IpOrigen,
        Observacion
    )
    VALUES
    (
        @IdUsuario,
        @Resultado,
        @NombreEquipo,
        @IpOrigen,
        @Observacion
    );
END
GO
