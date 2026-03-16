# ModuloGestion.Next — Análisis integral del sistema legado (baseline funcional)

> **Objetivo:** extraer el modelo real del negocio de `ModuloGestion` (legado) para reconstruir un nuevo ERP profesional **sin alterar la lógica actual en producción**.

## 1. Alcance y principios de este análisis

1. El sistema legado es la fuente de verdad funcional.
2. No se modifica comportamiento de negocio validado en producción.
3. La reconstrucción será paralela e incremental, por módulo.
4. Todo rediseño se valida por regresión funcional contra el legado.

---

## 2. Mapa de módulos actuales (observado en repositorio)

Inventario de formularios no-Designer detectado:

- **Gestión (núcleo ERP): 89 formularios**
- **Contabilidad: 9 formularios**
- **Montaje: 9 formularios**
- **Empleados/Nómina: 7 formularios**
- **Hoteles: 4 formularios**
- **Otros (raíz/Formularios/Optimización): 5 formularios**
- **Total: 123 formularios**

**Lectura arquitectónica:**
- Gestión concentra la mayor parte del negocio (proyectos, presupuestos, compras, artículos, clientes, proveedores).
- Contabilidad y Montaje tienen integración cruzada relevante.
- Empleados/Nómina interactúa con Contabilidad en procesos de pago/registro.

---

## 3. Modelo de negocio extraído (entidades reales)

El análisis de DataSets tipados y formularios permite consolidar el siguiente mapa de entidades.

## 3.1 Entidades núcleo
- Seguridad: `Usuarios`, `CategoriaUsuarios`.
- Comercial: `Clientes`, `Empresas`, `Proyectos`, `ProyectosDetalle`.
- Presupuestos: `Presupuesto`, `PresupuestoDetalle`, `PresupuestoDetalleElementos`, `PresupuestoDetalleHerrajes`, `PresupuestoDetallePintura`, `PresupuestoDocumentos`.
- Catálogo técnico: `Articulos`, `ArticulosDetalle`, `SubArticulos`, `SubArticulosDetalle`, `Grupo`, `ModeloArticulo`, `Descripciones`.
- Compras y abastecimiento: `Proveedores`, `ProveedoresProducto`, `CompraMateriales`, `CompraMaterialesDetalle`, `PagoProveedor`, `PagoProveedorDetalle`, `PreciosCompra`.
- Facturación/cobros: `Factura`, `FacturaDetalle`, `FacturaProveedor`, `FacturaProveedorDetalle`, `PagosClientes`, `PagosClientesDetalle`, `ComprobantesFiscales`.
- Logística/entregas: `NotasEntrega`, `NotasEntregaDetalle`, `Conductores`, `VehiculosTransporte`, `EmpresasTransporte`.
- RRHH: `Empleados`, `HorariosEmpleados`, `Nominas`, `NominasDetalle`, `AvanceEmpleados`, `AvnceEmpleadosPagos`.
- Montaje: `EmpresasContratadasMontaje`, `FacturaMontaje`, `FacturaMontajeDetalle`, `PagoMontaje`, `PagoMontajeDetalle`.

## 3.2 Entidades analíticas/reporting
- `EstadoTrabajos`, `Estadoentregas`, `EstadoCompraProyecto`, `ConsumoMaterialProyecto`, `ConsumoMaterialPresupuesto`, `TotalCompraPoveedor`, entre otras.

**Conclusión:** el legado no es “solo CRUD”; contiene un modelo transaccional amplio con agregados de presupuesto, compras, facturación y montaje.

---

## 4. Flujos de trabajo identificados

## 4.1 Seguridad y sesión
1. `FrmInicioSesion` valida credenciales con TableAdapter.
2. Se establece contexto de usuario (`UsuarioActual`) y categoría.
3. Se enruta a shell principal (`FrmGestion` o `FrmContabilidad`) según rol.

## 4.2 Comercial y presupuestos
1. Alta/gestión de cliente-empresa-proyecto.
2. Creación y edición de presupuesto + detalle.
3. Seguimiento de estado, costos, consumos y ejecución.

## 4.3 Compras
1. Catálogo de proveedores/productos.
2. Registro de compras por proyecto y detalles.
3. Seguimiento de pagos, precios y cuentas por pagar.

## 4.4 Montaje
1. Gestión de empresas de montaje.
2. Emisión/edición de factura de montaje.
3. Inserción de líneas desde presupuesto y recálculo de totales.
4. Asignación de pagos y reportes de resumen.

## 4.5 Empleados/Nómina
1. Mantenimiento de empleados activos/inactivos.
2. Ingreso de horarios/quincenas.
3. Nómina, avances y prestaciones.

## 4.6 Contabilidad
- Opera como módulo integrador (facturas, compras, cobros, montaje, empleados), con fuerte navegación cruzada a formularios de Gestión.

---

## 5. Stored Procedures y acceso a datos

SP detectados explícitamente en código:

- `sp_InsertarFacturaMontajeDetalle`
- `sp_RecalcularFacturaMontaje`
- `sp_ActualizarDetalleFacturaMontaje`
- `dbo.sp_AsignarPagoFacturaMontaje`
- `sp_AsignarPagoFactura`
- `sp_DesasignarPagoFactura`

Observaciones:
- Existe combinación de **TableAdapters + SQL inline + SP**.
- Al menos 32 formularios contienen sentencias SQL embebidas (SELECT/INSERT/UPDATE/DELETE), lo que confirma acoplamiento UI-datos.
- El nuevo sistema debe consolidar el acceso mediante servicios y repositorios sobre SP.

---

## 6. Reglas de negocio ocultas en formularios (muestra representativa)

## 6.1 `FrmInicioSesion` (Gestión)
- Regla: enrutamiento por categoría de usuario (`1,2,3 => Gestión`, `4 => Contabilidad`).
- Regla implícita: uso de etiquetas del formulario de destino como canal de contexto (`Label1`,`Label2`).
- Riesgo: credenciales de auto-login en claro por nombre de equipo.

## 6.2 `FrmGestion` (shell principal)
- Regla: permisos por categoría mediante visibilidad de menú.
- Regla: restricciones adicionales por usuario (`ANTONIO` con acceso ampliado).
- Riesgo: “formulario dios”; mezcla navegación, seguridad y reglas de acceso.

## 6.3 `FrmFacturaMontajeEditar` (Montaje)
- Regla: creación de línea vacía de factura en SP.
- Regla: alta de detalle desde partida de presupuesto.
- Regla: recálculo de factura tras cambios.
- Riesgo: mezcla UI + persistencia + cálculos en un único formulario.

## 6.4 `FrmContabilidad` (integración)
- Regla: menú central que orquesta operaciones de compras, proveedores, cobros, empleados y montaje.
- Riesgo: dependencia cruzada alta con formularios de Gestión.

---

## 7. Dependencias entre módulos (acoplamiento)

Dependencias de navegación cruzada observadas (My.Forms):

- `Gestión -> Montaje`
- `Contabilidad -> Gestión`
- `Gestión -> Contabilidad`
- `Contabilidad -> Empleados`
- `Contabilidad -> Montaje`
- `Gestión -> Hoteles`

**Interpretación:** existe acoplamiento transversal por UI. En `ModuloGestion.Next` la navegación debe desacoplarse por casos de uso y contratos de aplicación.

---

## 8. Arquitectura objetivo para ModuloGestion.Next

```text
UI WinForms (Presentación)
   ↓
Application Services (Casos de uso)
   ↓
Domain Model (Entidades + reglas de negocio)
   ↓
Infrastructure (Repositorios + SP + Reportes)
   ↓
SQL Server
```

Reglas obligatorias del nuevo sistema:

1. Formularios sin SQL embebido.
2. Formularios invocan casos de uso (Application).
3. Reglas de negocio en Domain (no en code-behind).
4. Repositorios ejecutan SP y traducen resultados a DTO/Entidades.
5. Lógica transaccional compleja en SQL Server (SP versionados).

---

## 9. Diseño de módulos de ModuloGestion.Next (propuesto)

- `ModuloGestion.Next.UI.WinForms`
- `ModuloGestion.Next.Application`
- `ModuloGestion.Next.Domain`
- `ModuloGestion.Next.Infrastructure.SqlServer`
- `ModuloGestion.Next.Infrastructure.Reporting`
- `ModuloGestion.Next.LegacyBridge` (adaptadores temporales al legado)

## 9.1 Contratos de Application (primer corte)
- `IAuthAppService`
- `IClientesAppService`
- `IProyectosAppService`
- `IPresupuestosAppService`
- `IComprasAppService`
- `IPagosAppService`
- `IMontajeAppService`
- `IEmpleadosNominaAppService`
- `IContabilidadAppService`

---

## 10. Estrategia de migración incremental (paralela)

Orden de migración acordado:

1. autenticación y sesión
2. clientes
3. proyectos
4. presupuestos
5. compras
6. pagos
7. montaje
8. empleados y nómina
9. contabilidad

Para cada módulo:

1. **Análisis funcional** (formularios, reglas, datasets, SP, reportes).
2. **Modelo de dominio** (entidades, agregados, invariantes).
3. **Casos de uso** (Application).
4. **Persistencia** (repositorios + SP).
5. **UI nueva** (formularios delgados).
6. **Pruebas de regresión** contra resultados del legado.
7. **Go-live por feature flag** y convivencia temporal.

---

## 11. Backlog arquitectónico de arranque (sin código funcional aún)

## Sprint A — Foundation
- Convenciones de naming, versionado de SP, manejo de errores y auditoría.
- Plantilla de solución `ModuloGestion.Next` con capas vacías.
- Contratos base de sesión, logging y configuración.

## Sprint B — Auth & Session
- Extraer reglas reales de login/roles del legado.
- Definir modelo `UsuarioSesion` + políticas de autorización.
- Construir primer caso de uso operativo con regresión funcional.

## Sprint C — Clientes + Proyectos
- Módulos piloto de migración para validar método extremo a extremo.

---

## 12. Entregable de esta iteración

- Este documento consolida el análisis funcional, modelo de negocio extraído, arquitectura objetivo y estrategia de migración, cumpliendo la secuencia: **analizar → diseñar → luego implementar**.
- No se integra código al sistema legado ni se altera su operación productiva.
