# ModuloGestion.Next

Estructura base inicial de la nueva solución con arquitectura en capas.

## Proyectos

- `ModuloGestion.Next.UI.WinForms`
- `ModuloGestion.Next.Application`
- `ModuloGestion.Next.Domain`
- `ModuloGestion.Next.Infrastructure.SqlServer`

## Referencias

- UI → Application
- UI → Infrastructure.SqlServer (composición)
- Application → Domain
- Infrastructure.SqlServer → Application

## Base de datos actual

- Base dedicada: `GestionEmpresa_Next`
- Script inicial de autenticación: `docs/sql/ModuloGestionNext.Auth.sql`
- Variable requerida para ejecución local: `MODULOGESTION_NEXT_CONNECTION_STRING`
- Usuario semilla inicial: `admin`
- Clave semilla inicial: `Admin1234!`

## Nota

Esta iteración prepara la arquitectura base y el primer flujo de autenticación con puertos en `Application`.
El login actual ya está alineado con el esquema `auth` de `GestionEmpresa_Next`.
Aún no contiene módulos de negocio del sistema legado.
