use GestionEmpresa
DELETE FROM HorariosEmpleados
DELETE FROM AvnceEmpleadosPagos
DELETE FROM AvanceEmpleados
DELETE FROM Empleados
DELETE FROM NominasDetalle
DELETE FROM Calendario
DELETE FROM Nominas


insert into GestionEmpresa.dbo.Nominas  select * from GestionEmpresaDELL.dbo.Nominas
insert into GestionEmpresa.dbo.Calendario  select * from GestionEmpresaDELL.dbo.Calendario

insert into GestionEmpresa.dbo.Empleados  select * from GestionEmpresaDELL.dbo.Empleados
insert into GestionEmpresa.dbo.HorariosEmpleados  select * from GestionEmpresaDELL.dbo.HorariosEmpleados
insert into GestionEmpresa.dbo.AvanceEmpleados  select * from GestionEmpresaDELL.dbo.AvanceEmpleados
insert into GestionEmpresa.dbo.AvnceEmpleadosPagos  select * from GestionEmpresaDELL.dbo.AvnceEmpleadosPagos

insert into GestionEmpresa.dbo.NominasDetalle  select * from GestionEmpresaDELL.dbo.NominasDetalle


DELETE FROM ProveedoresProducto
DELETE FROM CompraMaterialesDetalle
DELETE FROM CompraMateriales
DELETE FROM FacturaProveedorDetalle
DELETE FROM FacturaProveedor
DELETE FROM Proveedores
insert into GestionEmpresa.dbo.Proveedores  select * from GestionEmpresaDELL.dbo.Proveedores
insert into GestionEmpresa.dbo.ProveedoresProducto  select * from GestionEmpresaDELL.dbo.ProveedoresProducto

insert into GestionEmpresa.dbo.CompraMateriales  select * from GestionEmpresadell.dbo.CompraMateriales
insert into GestionEmpresa.dbo.CompraMaterialesDetalle  select * from GestionEmpresaDELL.dbo.CompraMaterialesDetalle
insert into GestionEmpresa.dbo.FacturaProveedor  select * from GestionEmpresaDELL.dbo.FacturaProveedor
insert into GestionEmpresa.dbo.FacturaProveedorDetalle  select * from GestionEmpresaDELL.dbo.FacturaProveedorDetalle
