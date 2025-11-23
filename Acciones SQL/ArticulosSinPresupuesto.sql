DELETE FROM Articulos
FROM         Articulos LEFT OUTER JOIN
                      PresupuestoDetalle ON Articulos.IdArticulo = PresupuestoDetalle.Articulo
WHERE     (PresupuestoDetalle.Articulo IS NULL)