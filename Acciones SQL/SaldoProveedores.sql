UPDATE       Proveedores
SET                SaldoUS = TotalCompraPoveedor.Expr1, SaldoRD = TotalCompraPoveedor.Expr2
FROM            Proveedores INNER JOIN
                         TotalCompraPoveedor ON Proveedores.Id_Proveedor = TotalCompraPoveedor.Id_Proveedor