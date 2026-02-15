# Revisión puntual: columna `ItemPresupuesto` en `DsFacturas`

## Qué revisé
- Dataset: `ModuloGestion/Gestion/Dataet/DsFacturas.xsd`.
- Columna objetivo: `ItemPresupuesto` en:
  - `FacturaDetalle`
  - `FacturaProformaDetalle`

## Resultado de la revisión

1. **La columna existe y está mapeada de forma consistente en ambos detalles**
   - Está declarada en el esquema XSD para `FacturaDetalle` y `FacturaProformaDetalle`.
   - En ambos casos tiene tipo `string`, longitud máxima 50 y permite nulos (`minOccurs="0"`).

2. **Se usa en CRUD completo (INSERT/UPDATE/DELETE/SELECT)**
   - `ItemPresupuesto` aparece en comandos SQL y parámetros de `FacturaDetalle`.
   - También aparece en comandos SQL y parámetros de `FacturaProformaDetalle`.
   - No se encontró discrepancia entre nombre de columna en mapeo y nombre usado en comandos SQL.

3. **Observación importante de diseño (no error técnico inmediato)**
   - `ItemPresupuesto` está modelada como texto libre (`nvarchar`) y nullable.
   - No se observa en este dataset una relación/foreign key contra una tabla de `Presupuesto`.
   - Esto permite flexibilidad, pero también deja espacio a valores inválidos o no normalizados.

## Recomendación
- Si la columna debe referenciar una partida de presupuesto real, conviene migrar a un identificador controlado (por ejemplo `IdPresupuestoDetalle`) y definir relación/validación referencial.
- Si debe seguir siendo textual, mantenerla como está pero validar formato desde UI o capa de negocio para evitar inconsistencias.
