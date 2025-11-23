DELETE FROM Articulos
WHERE Descripcion_articulo LIKE '%duplicado%'

DELETE FROM SubArticulos
WHERE Descripcion_Sub_Articulo LIKE '%duplicado%'
AND Id_Sub_Articulo NOT IN (SELECT Id_Sub_Articulo FROM ArticulosDetalle);
DELETE FROM SubArticulos
WHERE Id_Sub_Articulo NOT IN (SELECT Id_Sub_Articulo FROM ArticulosDetalle);
