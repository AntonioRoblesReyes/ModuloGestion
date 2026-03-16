# ModuloGestion — Plan maestro de reconstrucción (sin alterar lógica funcional)

## 1) Análisis del sistema actual

### 1.1 Módulos identificados
A partir de la estructura del repositorio y formularios existentes, el ERP está organizado en estos dominios principales:

- **Gestión (núcleo ERP)**: proyectos, presupuestos, clientes, artículos, compras, proveedores, entregas, transportes y usuarios.
- **Contabilidad**: facturas, cobros, pagos y vistas operativas contables.
- **Empleados/Nómina**: empleados, horarios, quincenas, nómina, avances y prestaciones.
- **Montaje**: empresas de montaje, facturación de montaje, pagos y recalculos.
- **Hoteles**: catálogo de hoteles/edificios/habitaciones con su propio dataset/conexión.
- **Optimización de madera**: módulo especializado.

Inventario rápido de formularios (no Designer):

- Gestión: **89**
- Contabilidad: **9**
- Empleados: **7**
- Montaje: **9**
- Hoteles: **4**
- Otros (raíz/Formularios/Opt.): **5**
- Total aproximado: **123 formularios**

### 1.2 Lógica de negocio y flujo general
Flujo observado:

1. **Inicio de sesión** (`FrmInicioSesion`) valida usuario/clave con TableAdapter y enruta según categoría.
2. **Menú principal** (`FrmGestion`) activa/desactiva opciones por rol y abre formularios de operación.
3. Cada formulario ejecuta lógica de negocio + acceso a datos (TableAdapter o SQL directo) en el mismo code-behind.
4. Existen reportes Crystal Reports para múltiples módulos.

### 1.3 Formularios clave revisados en profundidad

#### A) `FrmInicioSesion`
**Qué hace**
- Auto-rellena credenciales por nombre de equipo (opcional).
- Valida usuario y contraseña contra `UsuariosTableAdapter.FillByAccceso`.
- Guarda usuario en variable global `UsuarioActual`.
- Enruta a `FrmGestion` o `FrmContabilidad` por categoría.

**Problemas detectados**
- Credenciales en claro en UI para equipos permitidos.
- Lógica de autenticación + navegación + reglas de rol en el formulario.
- Dependencia global fuerte (`My.Forms`, `UsuarioActual`, Labels como canal de contexto).

**Versión mejorada propuesta**
- Mantener comportamiento funcional exacto.
- Separar en:
  - `AuthService` (validación)
  - `SessionContext` (usuario activo)
  - `RoleRouter` (destino por categoría)
- Mantener compatibilidad con datasets mientras se migra por fases.

#### B) `FrmGestion`
**Qué hace**
- Es el shell operativo principal con `MenuStrip`.
- Habilita/oculta opciones por categoría de usuario.
- Orquesta la navegación a la mayoría de formularios de negocio.

**Problemas detectados**
- Formulario “Dios” (demasiadas responsabilidades).
- Repetición de patrón `Close()/Show()` y acoplamiento a `My.Forms`.
- Políticas de permisos embebidas y dispersas.

**Versión mejorada propuesta**
- `MainShellForm` solo presentación + navegación.
- `PermissionService` centraliza reglas de menú.
- `NavigationService` abre formularios/diálogos de manera uniforme.

#### C) `FrmFacturaMontajeEditar`
**Qué hace**
- Carga factura de montaje, detalle, presupuesto asociado.
- Inserta/edita líneas (mezcla TableAdapter y Stored Procedure).
- Recalcula totales.

**Problemas detectados**
- Mezcla UI + persistencia + reglas de cálculo.
- Múltiples puntos de actualización manual para refrescar datos.
- Acoplamiento entre controles del grid y reglas transaccionales.

**Versión mejorada propuesta**
- `FacturaMontajeService` con casos de uso:
  - `CrearLineaVacia`
  - `AgregarPartidaDesdePresupuesto`
  - `RecalcularFactura`
- Repositorios desacoplados de la UI y pruebas de reglas de cálculo.

### 1.4 Base de datos actual: tablas/procedimientos

Hallazgos relevantes:

- Existen **datasets tipados** extensivos y gran número de DataTables (más de 150 clases de tabla), entre ellas:
  - `Proyectos`, `Presupuesto`, `PresupuestoDetalle`, `Clientes`, `Articulos`, `CompraMateriales`, `CompraMaterialesDetalle`, `FacturaProveedor`, `PagosClientes`, `NotasEntrega`, `SubArticulos`, `Proveedores`, `Nominas`, etc.
- Scripts SQL de apoyo en `Acciones SQL` (actualización, limpieza, vistas y consultas).
- Stored procedures explícitos detectados en código:
  - `sp_InsertarFacturaMontajeDetalle`
  - `sp_RecalcularFacturaMontaje`
  - `sp_ActualizarDetalleFacturaMontaje`
  - `dbo.sp_AsignarPagoFacturaMontaje`
  - `sp_AsignarPagoFactura`
  - `sp_DesasignarPagoFactura`

### 1.5 Flujos de trabajo principales

- **Ventas/Presupuestos**: empresa/proyecto → presupuesto → detalle → aprobación/estado.
- **Compras**: proveedores/productos → orden/compra material → detalle → pago.
- **Cobros/Pagos**: asignación/desasignación de pagos a facturas.
- **Empleados**: empleados activos/inactivos → horarios/quincena → nómina/avances/prestaciones.
- **Montaje**: empresa montaje → factura montaje → detalle por presupuesto → recalculo/pago.

---

## 2) Nueva arquitectura limpia (objetivo)

## 2.1 Estructura de solución propuesta

```text
ModuloGestion.Rebuild.sln
src/
  ModuloGestion.UI.WinForms/
    Forms/
      Auth/
      Gestion/
      Compras/
      Presupuestos/
      Contabilidad/
      Empleados/
      Montaje/
    Common/
  ModuloGestion.Application/
    UseCases/
    DTOs/
    Interfaces/
  ModuloGestion.Domain/
    Entities/
    ValueObjects/
    Services/
    Rules/
  ModuloGestion.Infrastructure/
    Persistence/
      SqlServer/
        Repositories/
        Db/
    Reporting/
  ModuloGestion.LegacyAdapter/
    TableAdaptersBridge/
tests/
  ModuloGestion.Domain.Tests/
  ModuloGestion.Application.Tests/
```

## 2.2 Principios
- **No cambiar comportamiento funcional** (compatibilidad como regla #1).
- **Separación por capas**: UI, Aplicación, Dominio, Infraestructura.
- **Migración incremental**: módulo por módulo y formulario por formulario.
- **Anti-corruption layer** para convivir temporalmente con TableAdapters.

---

## 3) Plan por fases (obligatorio y secuencial)

## FASE 1 — Modelo del sistema
1. Definir bounded contexts: Gestión, Compras, Presupuestos, Contabilidad, RRHH, Montaje.
2. Definir entidades maestras y transaccionales (catálogos vs movimientos).
3. Definir relaciones y agregados.
4. Crear diccionario de datos versionado.

**Entidades núcleo iniciales**
- Seguridad: `Usuario`, `Rol`, `Permiso`.
- Comercial: `Cliente`, `Empresa`, `Proyecto`, `Presupuesto`, `PresupuestoDetalle`.
- Compras: `Proveedor`, `Compra`, `CompraDetalle`, `PagoProveedor`.
- Contabilidad: `Factura`, `Cobro`, `ComprobanteFiscal`.
- RRHH: `Empleado`, `Horario`, `Nomina`, `AvanceEmpleado`.
- Montaje: `EmpresaMontaje`, `FacturaMontaje`, `FacturaMontajeDetalle`.

## FASE 2 — Base de datos
1. Crear tablas **solo cuando se necesiten por caso de uso**.
2. Crear SP **solo cuando agreguen valor** (transacción compleja/rendimiento).
3. Evitar duplicidad de tablas por módulo.
4. Convenciones:
   - PK: `Id...`
   - FK explícitas
   - columnas auditables (`CreadoEn`, `ModificadoEn`, `CreadoPor`)

## FASE 3 — Interfaz
1. Crear formularios únicamente por necesidad funcional priorizada.
2. Formularios delgados (sin SQL directo).
3. Reutilización de componentes (grids, buscadores, diálogos).
4. Patrón sugerido: MVP pasivo para WinForms.

## FASE 4 — Lógica del sistema
1. Implementar casos de uso en Application.
2. Reglas de negocio en Domain.
3. Compatibilidad gradual con sistema actual (LegacyAdapter).
4. Pruebas de regresión por flujo crítico.

---

## 4) Diseño de base de datos inicial recomendado

Modelo mínimo para arrancar (fase 1/2):

- `Usuarios`, `Roles`, `UsuarioRol`
- `Clientes`, `Empresas`, `Proyectos`
- `Presupuestos`, `PresupuestoDetalles`
- `Proveedores`, `Compras`, `CompraDetalles`
- `Facturas`, `FacturasDetalle`, `Cobros`, `Pagos`
- `Empleados`, `Horarios`, `Nominas`, `NominaDetalles`
- `EmpresasMontaje`, `FacturasMontaje`, `FacturasMontajeDetalle`

Relaciones clave:
- `Proyecto` 1-N `Presupuesto`
- `Presupuesto` 1-N `PresupuestoDetalle`
- `Proveedor` 1-N `Compra`
- `Compra` 1-N `CompraDetalle`
- `FacturaMontaje` 1-N `FacturaMontajeDetalle`

---

## 5) Roadmap incremental sugerido (sin big-bang)

1. **Sprint 1**: seguridad/sesión + menú principal + permisos centralizados.
2. **Sprint 2**: catálogo base (clientes/proveedores/proyectos).
3. **Sprint 3**: presupuestos (núcleo comercial).
4. **Sprint 4**: compras + pagos proveedor.
5. **Sprint 5**: empleados/nómina.
6. **Sprint 6**: montaje.
7. **Sprint 7**: contabilidad/reportes.

Criterio de cierre por sprint:
- Pruebas de regresión funcional contra el módulo legado.
- Sin SQL embebido en formularios nuevos.
- Casos de uso documentados y testeados.

---

## 6) Riesgos y mitigaciones

- **Riesgo**: alta dependencia de TableAdapters.
  - Mitigación: capa puente (`LegacyAdapter`) y reemplazo por repositorio caso a caso.
- **Riesgo**: reglas implícitas en UI.
  - Mitigación: extraer reglas a servicios y crear pruebas de regresión.
- **Riesgo**: seguridad (credenciales en config/código).
  - Mitigación: secretos fuera de repositorio y hardening de autenticación.

---

## 7) Entregable de esta iteración

- Diagnóstico global de arquitectura actual.
- Propuesta de arquitectura objetivo.
- Plan de ejecución por fases (1→4) y roadmap incremental.
- Documento ampliado de análisis integral en `docs/arquitectura/AnalisisIntegralModuloGestion.md`.

