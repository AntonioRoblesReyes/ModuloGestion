UPDATE       CompraMaterialesDetalle
SET                fecha = CompraMateriales.Fecha_Compra
FROM            CompraMateriales LEFT OUTER JOIN
                         CompraMaterialesDetalle ON CompraMateriales.Id_Compra = CompraMaterialesDetalle.Id_Compra