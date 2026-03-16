# ModuloGestion.Next — Plan de ejecución completo (orden recomendado)

Este plan define **cómo construir el ERP nuevo desde cero**, en el orden correcto, sin depender del sistema legado para la base de datos ni para decisiones de arquitectura.

## 0) Principios base (antes de codificar)

1. **Base de datos separada**: todo en `GestionEmpresa_Next`.
2. **Arquitectura por capas**: `Domain` → `Application` → `Infrastructure` → `UI`.
3. **Contratos primero**: casos de uso e interfaces antes de implementación concreta.
4. **Vertical slices**: implementar funcionalidades completas, una por una, con pruebas.
5. **Migraciones controladas**: scripts versionados y reproducibles.

---

## 1) Fase de fundación técnica

### Objetivo
Dejar lista la estructura mínima para crecer sin retrabajo.

### Entregables
- Solución y proyectos base (`Domain`, `Application`, `Infrastructure.SqlServer`, `UI.WinForms`).
- Convenciones (nombres, namespaces, manejo de errores, logging).
- Script de base de datos inicial en `GestionEmpresa_Next`.
- Pipeline básico de build/validación.

### Criterio de salida
- La solución compila.
- Script SQL ejecuta en una instancia limpia.
- UI abre shell principal sin errores.

---

## 2) Fase de seguridad y acceso (primero funcional)

### Objetivo
Construir el módulo de autenticación/autorización base.

### Entregables
- Esquema `auth` completo en `GestionEmpresa_Next`.
- Login con hash+salt, control de intentos fallidos y registro de sesión.
- Roles y permisos por menú.
- Usuario administrador semilla (script de seed).
- Pantalla de login + sesión de usuario en memoria de aplicación.

### Criterio de salida
- Se puede iniciar sesión con usuario activo.
- Se bloquean/registran intentos inválidos.
- Menús se habilitan por rol/permisos.

---

## 3) Fase de núcleo maestro (catálogos transversales)

### Objetivo
Tener los maestros que usa casi todo el ERP.

### Entregables
- Empresas, sucursales, usuarios internos.
- Monedas, impuestos, unidades de medida.
- Clientes, proveedores, artículos/familias/subfamilias.
- CRUD con validaciones de negocio.

### Criterio de salida
- Catálogos estables y reutilizables por módulos.

---

## 4) Fase de compras e inventario (base operativa)

### Objetivo
Asegurar flujo de entrada de materiales y control de existencia/costos.

### Entregables
- Órdenes de compra y recepción.
- Kardex/movimientos inventario.
- Ajustes y transferencias.
- Consultas de existencias y costo promedio.

### Criterio de salida
- Toda entrada/salida deja trazabilidad y saldo consistente.

---

## 5) Fase de ventas/presupuestos/proyectos

### Objetivo
Implementar el flujo comercial y su impacto en ejecución.

### Entregables
- Presupuestos y versiones.
- Conversión a pedido/proyecto.
- Seguimiento de estado (pendiente, aprobado, en ejecución, cerrado).

### Criterio de salida
- Se puede recorrer punta a punta desde presupuesto hasta proyecto.

---

## 6) Fase de contabilidad integrada

### Objetivo
Conectar operación con asientos y reportes contables.

### Entregables
- Cuentas contables y centros de costo.
- Reglas de contabilización por evento.
- Libros y reportes clave.

### Criterio de salida
- Eventos operativos generan asientos válidos y auditables.

---

## 7) Fase de RRHH/Nómina (si aplica al alcance inicial)

### Objetivo
Migrar módulos de empleados/nomina en orden controlado.

### Entregables
- Maestros de empleados.
- Conceptos de pago y cálculo quincenal.
- Reportes/recibos.

### Criterio de salida
- Cálculo repetible y validado con casos reales.

---

## 8) Fase de reportes, auditoría y hardening

### Objetivo
Cerrar calidad y operación para producción.

### Entregables
- Auditoría funcional (quién, cuándo, qué cambió).
- Reportes ejecutivos y operativos.
- Backups/restore, monitoreo y checklist de despliegue.
- Pruebas de humo end-to-end.

### Criterio de salida
- Sistema listo para piloto productivo.

---

## Orden de implementación recomendado (iteraciones)

1. **Autenticación completa** (DB + casos de uso + UI login).
2. **Catálogos maestros mínimos** (clientes, proveedores, artículos).
3. **Compras + inventario básico**.
4. **Presupuestos/proyectos**.
5. **Contabilidad integrada**.
6. **RRHH/Nómina** (según prioridad de negocio).
7. **Reportes + cierre productivo**.

---

## Próximo paso inmediato (Sprint 1)

1. Cerrar script `auth` + seed admin en `GestionEmpresa_Next`.
2. Implementar casos de uso `IniciarSesion`, `CerrarSesion`, `ObtenerPermisos`.
3. Conectar `UI.WinForms` con pantalla login y apertura de shell según permisos.
4. Agregar pruebas de aplicación para autenticación (casos válidos/ inválidos/ bloqueado).

Con este orden evitamos retrabajo y garantizamos una base sólida para construir el ERP completo de forma incremental.
