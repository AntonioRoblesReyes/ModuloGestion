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

## Nota

Esta iteración prepara la arquitectura base y el primer flujo de autenticación con puertos en `Application`.
Aún no contiene módulos de negocio del sistema legado.
