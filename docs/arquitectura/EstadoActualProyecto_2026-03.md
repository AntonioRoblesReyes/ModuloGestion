# Estado actual del repositorio ModuloGestion / ModuloGestion.Next

## 1) Estructura general del proyecto

El repositorio contiene **dos líneas principales**:

1. **Sistema legado `ModuloGestion`** (WinForms .NET Framework 4.8, arquitectura acoplada UI + datos).
2. **Nueva iniciativa `ModuloGestion.Next`** (WinForms .NET 8 con separación por capas, aún en etapa base).

Además hay carpetas de soporte:
- `Acciones SQL/` (scripts sueltos de mantenimiento/corrección).
- `docs/arquitectura/` (análisis y planes de migración).
- `Archivos de copia de seguridad de Crystal Reports/` (histórico/backup).

### Soluciones/proyectos relevantes

- `ModuloGestion.sln` (raíz) carga el proyecto legado `ModuloGestion`.
- `ModuloGestion.Next/ModuloGestion.Next.sln` contiene 4 proyectos por capas:
  - `ModuloGestion.Next.UI.WinForms`
  - `ModuloGestion.Next.Application`
  - `ModuloGestion.Next.Domain`
  - `ModuloGestion.Next.Infrastructure.SqlServer`

## 2) Dependencias y stack tecnológico actual

### Legado (`ModuloGestion`)
- **Target:** `.NET Framework 4.8`, WinForms.
- **OptionStrict:** `Off` (más riesgo de errores en runtime).
- **Reporting:** Crystal Reports (múltiples referencias `CrystalDecisions.*`).
- **Paquetes NuGet:** BouncyCastle en el núcleo legado y ClosedXML/OpenXml en `OptimizacionMadera`.
- **Datos:** SQL Server con `System.Data.SqlClient` y DataSets tipados (muchos `.xsd/.xsc/.xss`).

### Nuevo (`ModuloGestion.Next`)
- **Target:** `.NET 8` (UI en `net8.0-windows`, capas no-UI en `net8.0`).
- **Estilo:** OptionStrict/OptionInfer/OptionExplicit activados.
- **Paquete principal:** `Microsoft.Data.SqlClient` (actualmente preview `7.0.0-preview4`).

## 3) Qué hace hoy el sistema

### Legado: sistema operativo real en producción
Cubre procesos ERP amplios:
- Seguridad/login y enrutamiento por rol.
- Gestión comercial (clientes, empresas, proyectos, presupuestos).
- Compras/proveedores.
- Contabilidad y cobros/pagos.
- Empleados/nómina.
- Montaje y facturación de montaje.
- Reportes (Crystal Reports).

### ModuloGestion.Next: base arquitectónica + login de prueba
Actualmente implementa:
- Estructura de capas y arranque WinForms.
- Pantalla de login (`FrmLoginNext`) conectada a un `AuthAppService` temporal.
- Validación hardcoded (`admin` / `1234`) sin persistencia real.
- Apertura de shell principal si login es correcto.

El propio `README` declara que aún no hay lógica de negocio ni integración legado.

## 4) Hallazgos de partes incompletas/problemas

### En `ModuloGestion.Next`
1. **Autenticación temporal hardcoded** (`admin/1234`), no apta para producción.
2. **Cadena de conexión en claro con usuario `sa` y password en código**.
3. **Dependencias de arquitectura invertidas:**
   - Application referencia Infrastructure.
   - Domain referencia `SqlClient` (debería ser puro dominio).
4. **Bootstrap vacíos** en Domain/Application/Infrastructure (sin casos de uso, entidades ni repositorios).
5. **Importaciones no utilizadas / mezcla de capas en UI de login** (`SqlClient` e infraestructura importados en formulario).

### En legado (`ModuloGestion`)
1. **Credenciales SQL en claro** en `app.config` y settings generados.
2. **Autologin inseguro y password en texto plano** en `FrmInicioSesion` para equipos permitidos.
3. **Acoplamiento alto de UI con reglas de negocio y navegación global** (`My.Forms`, visibilidad por menús, lógica de permisos en formulario principal).
4. **Lógica SQL dentro de formularios** (consultas y operaciones embebidas) en múltiples módulos.
5. **Uso de `Option Strict Off`** en el proyecto principal.
6. **Se detecta un archivo `ModuloGestion/ModuloGestion.sln` aparentemente corrupto/binario** (no parseable como texto de solución estándar).

## 5) Estado técnico resumido

- El **producto funcional real** sigue siendo el legado WinForms + SQL Server.
- `ModuloGestion.Next` está en **fase de fundación**, con intención correcta de capas pero todavía sin vertical slices funcionales.
- La brecha más importante no es UI: es **modelo de dominio + casos de uso + persistencia transaccional**.
- Existen riesgos de seguridad inmediatos por exposición de credenciales.

## 6) Próximos pasos recomendados (orden sugerido)

1. **Seguridad inmediata (alto impacto):**
   - Eliminar secretos del repo (connection strings, usuario `sa`, passwords hardcoded).
   - Mover configuración a variables de entorno / user secrets / vault.

2. **Corregir arquitectura base de Next:**
   - Quitar referencia Application -> Infrastructure.
   - Quitar `SqlClient` de Domain.
   - Definir contratos en Application (puertos) e implementar en Infrastructure.

3. **Primer vertical slice real (MVP):**
   - `IniciarSesion` con BD `GestionEmpresa_Next`.
   - Entidades de usuario/rol, hash de contraseña, bloqueo por intentos.
   - UI de login consumiendo caso de uso, no implementación concreta.

4. **Catálogos base (siguiente sprint):**
   - Clientes, proveedores, artículos.
   - CRUD con validaciones y repositorios.

5. **Estrategia de migración controlada desde legado:**
   - Inventariar procesos críticos por módulo (presupuestos, compras, montaje).
   - Crear pruebas de regresión funcional por flujo antes de reescribir.

6. **Calidad técnica mínima continua:**
   - Añadir pruebas unitarias de casos de uso.
   - Pipeline de build + análisis estático.
   - Convenciones de logging, errores y trazabilidad.

## 7) Conclusión ejecutiva

El repositorio está en una transición clara:
- **Legado:** completo, funcional, pero con deuda técnica y riesgos de seguridad.
- **Next:** bien encaminado en intención arquitectónica, todavía incompleto para operaciones de negocio.

La decisión correcta para continuar es avanzar por **slices funcionales pequeños**, empezando por autenticación real y catálogos maestros, mientras se reduce riesgo de seguridad desde el día 1.
