# ModuloGestion.Next

Estructura base inicial de la nueva solución con arquitectura en capas.

## Proyectos

- `ModuloGestion.Next.UI.WinForms`
- `ModuloGestion.Next.Application`
- `ModuloGestion.Next.Domain`
- `ModuloGestion.Next.Infrastructure.SqlServer`

## Referencias

- UI → Application
- Application → Domain
- Application → Infrastructure.SqlServer
- Infrastructure.SqlServer → Domain

## Nota

Esta iteración solo prepara la arquitectura base. No contiene lógica de negocio ni integración con el sistema legado aún.
