

DELETE FROM SubArticulos
FROM         SubArticulos LEFT OUTER JOIN
                      ArticulosDetalle ON SubArticulos.Id_Sub_Articulo = ArticulosDetalle.ID_Sub_Articulo
WHERE     (ArticulosDetalle.Id_Articulo IS NULL)