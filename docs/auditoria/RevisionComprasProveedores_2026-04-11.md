# Auditoría técnica: Compras a proveedores (VB.NET WinForms + DataSet/TableAdapter + SQL Server)

Fecha: 2026-04-11

## Alcance revisado
- `FrmIngresoCompras`, `FrmComprasProyecto`, `FrmProductos`, `FrmProveedores`, `ImpCompras`.
- DataSet/TableAdapters: `DsCompras`, `DsProveedoresProducto`, `DsImprimirCompras`.
- Flujo funcional: proveedor -> productos -> detalle -> guardar -> editar -> imprimir -> reabrir.

## Hallazgos priorizados

### Críticos
1. **Riesgo de colisión de `Id_Detalle_compra` por generación en UI (`MAX local`)**.
   - Se corregió en formulario para leer desde DataTable tipado en memoria y no desde nombre de columna incorrecto del grid.
   - Riesgo remanente de concurrencia multiusuario: debe resolverse en DB con `SEQUENCE`/`IDENTITY` o SP transaccional.

2. **Guardado sin validación de cabecera y detalle**.
   - Se agregaron validaciones obligatorias antes de guardar para evitar compras sin proveedor, sin Id o sin líneas válidas.

3. **Conversión numérica frágil por parseo de TextBox formateado con miles/comas**.
   - Se eliminó la dependencia de parsear UI para persistir totales; ahora se toman del `DataRowView` (valores numéricos).

### Importantes
4. **Manejo deficiente de proveedor sin productos al agregar detalle**.
   - Se agregaron validaciones de `BindingSource.Position`/conteo y mensajes claros.

5. **Cambios agregando detalle no siempre marcaban estado pendiente**.
   - Se fuerza `cambiosPendientes = True` al agregar ítem exitosamente.

6. **Querys con precedencia ambigua en filtros de pendientes (`AND/OR`)**.
   - Recomendación: parentizar explícitamente en SQL para evitar resultados incorrectos.

### Mejoras recomendadas
7. **Ausencia de relación FK tipada Compra -> Detalle en DataSet**.
8. **Manejo de errores silencioso en múltiples `Try/Catch` vacíos**.
9. **Dependencia fuerte de `My.Forms` y controles UI en lógica de negocio**.
10. **`FillByTotal` usa `CAST(... AS VARCHAR) LIKE` sobre columnas numéricas (no sargable, bajo rendimiento)**.

## SQL sugerido (DBA) para robustez

```sql
-- 1) FK de integridad: no debe existir detalle sin cabecera
ALTER TABLE dbo.CompraMaterialesDetalle
ADD CONSTRAINT FK_CompraMaterialesDetalle_CompraMateriales
FOREIGN KEY (Id_Compra)
REFERENCES dbo.CompraMateriales (Id_Compra)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

-- 2) Clave única fuerte para detalle (si aún no existe en DB)
ALTER TABLE dbo.CompraMaterialesDetalle
ADD CONSTRAINT UQ_CompraMaterialesDetalle_IdDetalleCompra UNIQUE (Id_Detalle_compra);
```

## SQL sugerido para filtros de pendientes (corrección de precedencia)

```sql
-- Antes: combinaciones con AND/OR sin paréntesis explícitos
-- Después:
WHERE (Id_Proveedor = @IdProveedor)
  AND (
        (Moneda = 'RD$' AND PendienteRD > 0)
        OR
        (Moneda = 'US$' AND PendienteUS > 0)
      )
```

## Refactor aplicado en formulario principal
- Validaciones de entrada obligatoria.
- Cálculo/guardado de totales desacoplado de formato visual.
- Detección segura de filas de detalle vacías.
- Validación robusta de selección de producto de proveedor.

