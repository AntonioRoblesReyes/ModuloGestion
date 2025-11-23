UPDATE       CompraMateriales
SET                Tasa = Tasa.Venta
FROM            CompraMateriales LEFT OUTER JOIN
                         Tasa ON CompraMateriales.Fecha_Compra = Tasa.IdFecha
WHERE        (NOT (Tasa.IdFecha IS NULL))


UPDATE       CompraMaterialesDetalle
SET                Tasa = CompraMateriales.Tasa, Itebis = CompraMateriales.PorcientoImpuesto
FROM            CompraMaterialesDetalle RIGHT OUTER JOIN
                         CompraMateriales ON CompraMaterialesDetalle.Id_Compra = CompraMateriales.Id_Compra
UPDATE       CompraMaterialesDetalle
SET                PrecioUS = PrecioRD / Tasa, ItebisUS = PrecioRD / Tasa * Itebis, ItebisRD = PrecioRD * Itebis