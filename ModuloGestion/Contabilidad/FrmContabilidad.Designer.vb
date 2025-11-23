<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContabilidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosRecibidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDeCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConducesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasDeDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuecoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveevoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NievoPorveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoTiempoTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InActivosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvanceEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratoObraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApuntesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeCompraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaPreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MontajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaMontajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsContabilidad = New ModuloGestion.DsContabilidad()
        Me.TableAdapterManager = New ModuloGestion.DsContabilidadTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoDeCuentasToolStripMenuItem, Me.GastosToolStripMenuItem, Me.ContactosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.BancosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ApuntesToolStripMenuItem, Me.OrdenesDeCompraToolStripMenuItem1, Me.PresupuestosToolStripMenuItem, Me.MontajeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1407, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoDeCuentasToolStripMenuItem
        '
        Me.CatalogoDeCuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaDeVentaToolStripMenuItem, Me.PagosRecibidosToolStripMenuItem, Me.NotaDeCreditoToolStripMenuItem, Me.CotizacionesToolStripMenuItem, Me.ConducesToolStripMenuItem})
        Me.CatalogoDeCuentasToolStripMenuItem.Name = "CatalogoDeCuentasToolStripMenuItem"
        Me.CatalogoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.CatalogoDeCuentasToolStripMenuItem.Text = "Ingresos"
        '
        'FacturaDeVentaToolStripMenuItem
        '
        Me.FacturaDeVentaToolStripMenuItem.Name = "FacturaDeVentaToolStripMenuItem"
        Me.FacturaDeVentaToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.FacturaDeVentaToolStripMenuItem.Text = "Factura De Venta"
        '
        'PagosRecibidosToolStripMenuItem
        '
        Me.PagosRecibidosToolStripMenuItem.Name = "PagosRecibidosToolStripMenuItem"
        Me.PagosRecibidosToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.PagosRecibidosToolStripMenuItem.Text = "Pagos Recibidos"
        '
        'NotaDeCreditoToolStripMenuItem
        '
        Me.NotaDeCreditoToolStripMenuItem.Name = "NotaDeCreditoToolStripMenuItem"
        Me.NotaDeCreditoToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.NotaDeCreditoToolStripMenuItem.Text = "Nota de Credito"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'ConducesToolStripMenuItem
        '
        Me.ConducesToolStripMenuItem.Name = "ConducesToolStripMenuItem"
        Me.ConducesToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ConducesToolStripMenuItem.Text = "Conduces"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem, Me.FacturaProveedoresToolStripMenuItem, Me.NotasDeDebitoToolStripMenuItem, Me.OrdenesDeCompraToolStripMenuItem})
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'FacturaProveedoresToolStripMenuItem
        '
        Me.FacturaProveedoresToolStripMenuItem.Name = "FacturaProveedoresToolStripMenuItem"
        Me.FacturaProveedoresToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.FacturaProveedoresToolStripMenuItem.Text = "Factura Proveedores"
        '
        'NotasDeDebitoToolStripMenuItem
        '
        Me.NotasDeDebitoToolStripMenuItem.Name = "NotasDeDebitoToolStripMenuItem"
        Me.NotasDeDebitoToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NotasDeDebitoToolStripMenuItem.Text = "Notas de Debito"
        '
        'OrdenesDeCompraToolStripMenuItem
        '
        Me.OrdenesDeCompraToolStripMenuItem.Name = "OrdenesDeCompraToolStripMenuItem"
        Me.OrdenesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.OrdenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveevoresToolStripMenuItem})
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem, Me.ListadoToolStripMenuItem1, Me.NuecoToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.ListadoToolStripMenuItem.Text = "Clientes"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(144, 26)
        Me.ListadoToolStripMenuItem1.Text = "Listado"
        '
        'NuecoToolStripMenuItem
        '
        Me.NuecoToolStripMenuItem.Name = "NuecoToolStripMenuItem"
        Me.NuecoToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.NuecoToolStripMenuItem.Text = "Nuevo"
        '
        'ProveevoresToolStripMenuItem
        '
        Me.ProveevoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ListadoProveedoresToolStripMenuItem, Me.NievoPorveedorToolStripMenuItem, Me.MantenimientoToolStripMenuItem1})
        Me.ProveevoresToolStripMenuItem.Name = "ProveevoresToolStripMenuItem"
        Me.ProveevoresToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ProveevoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ListadoProveedoresToolStripMenuItem
        '
        Me.ListadoProveedoresToolStripMenuItem.Name = "ListadoProveedoresToolStripMenuItem"
        Me.ListadoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ListadoProveedoresToolStripMenuItem.Text = "Listado proveedores"
        '
        'NievoPorveedorToolStripMenuItem
        '
        Me.NievoPorveedorToolStripMenuItem.Name = "NievoPorveedorToolStripMenuItem"
        Me.NievoPorveedorToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.NievoPorveedorToolStripMenuItem.Text = "Nuevo Porveedor"
        '
        'MantenimientoToolStripMenuItem1
        '
        Me.MantenimientoToolStripMenuItem1.Name = "MantenimientoToolStripMenuItem1"
        Me.MantenimientoToolStripMenuItem1.Size = New System.Drawing.Size(227, 26)
        Me.MantenimientoToolStripMenuItem1.Text = "Mantenimiento"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem2, Me.BancosToolStripMenuItem1, Me.NuevoToolStripMenuItem})
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'ListadoToolStripMenuItem2
        '
        Me.ListadoToolStripMenuItem2.Name = "ListadoToolStripMenuItem2"
        Me.ListadoToolStripMenuItem2.Size = New System.Drawing.Size(140, 26)
        Me.ListadoToolStripMenuItem2.Text = "Listado"
        '
        'BancosToolStripMenuItem1
        '
        Me.BancosToolStripMenuItem1.Name = "BancosToolStripMenuItem1"
        Me.BancosToolStripMenuItem1.Size = New System.Drawing.Size(140, 26)
        Me.BancosToolStripMenuItem1.Text = "Bancos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoTiempoTrabajoToolStripMenuItem, Me.NominaToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.AvanceEmpleadosToolStripMenuItem, Me.ContratoObraToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'IngresoTiempoTrabajoToolStripMenuItem
        '
        Me.IngresoTiempoTrabajoToolStripMenuItem.Name = "IngresoTiempoTrabajoToolStripMenuItem"
        Me.IngresoTiempoTrabajoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.IngresoTiempoTrabajoToolStripMenuItem.Text = "Ingreso Horario"
        '
        'NominaToolStripMenuItem
        '
        Me.NominaToolStripMenuItem.Name = "NominaToolStripMenuItem"
        Me.NominaToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.NominaToolStripMenuItem.Text = "Nomina"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivosToolStripMenuItem1, Me.InActivosToolStripMenuItem1})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'ActivosToolStripMenuItem1
        '
        Me.ActivosToolStripMenuItem1.Name = "ActivosToolStripMenuItem1"
        Me.ActivosToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ActivosToolStripMenuItem1.Text = "Activos"
        '
        'InActivosToolStripMenuItem1
        '
        Me.InActivosToolStripMenuItem1.Name = "InActivosToolStripMenuItem1"
        Me.InActivosToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.InActivosToolStripMenuItem1.Text = "InActivos"
        '
        'AvanceEmpleadosToolStripMenuItem
        '
        Me.AvanceEmpleadosToolStripMenuItem.Name = "AvanceEmpleadosToolStripMenuItem"
        Me.AvanceEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.AvanceEmpleadosToolStripMenuItem.Text = "Avance Empleados"
        '
        'ContratoObraToolStripMenuItem
        '
        Me.ContratoObraToolStripMenuItem.Name = "ContratoObraToolStripMenuItem"
        Me.ContratoObraToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ContratoObraToolStripMenuItem.Text = "Contrato Obra"
        '
        'ApuntesToolStripMenuItem
        '
        Me.ApuntesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GruposToolStripMenuItem, Me.SubGruposToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.SubCuentaToolStripMenuItem, Me.DiarioToolStripMenuItem})
        Me.ApuntesToolStripMenuItem.Name = "ApuntesToolStripMenuItem"
        Me.ApuntesToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ApuntesToolStripMenuItem.Text = "Imprimir"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'SubGruposToolStripMenuItem
        '
        Me.SubGruposToolStripMenuItem.Name = "SubGruposToolStripMenuItem"
        Me.SubGruposToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.SubGruposToolStripMenuItem.Text = "SubGrupos"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'SubCuentaToolStripMenuItem
        '
        Me.SubCuentaToolStripMenuItem.Name = "SubCuentaToolStripMenuItem"
        Me.SubCuentaToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.SubCuentaToolStripMenuItem.Text = "SubCuenta"
        '
        'DiarioToolStripMenuItem
        '
        Me.DiarioToolStripMenuItem.Name = "DiarioToolStripMenuItem"
        Me.DiarioToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.DiarioToolStripMenuItem.Text = "Diario"
        '
        'OrdenesDeCompraToolStripMenuItem1
        '
        Me.OrdenesDeCompraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaOrdenToolStripMenuItem, Me.VerOrdenToolStripMenuItem, Me.ConsultaPreciosToolStripMenuItem})
        Me.OrdenesDeCompraToolStripMenuItem1.Name = "OrdenesDeCompraToolStripMenuItem1"
        Me.OrdenesDeCompraToolStripMenuItem1.Size = New System.Drawing.Size(158, 24)
        Me.OrdenesDeCompraToolStripMenuItem1.Text = "Ordenes De Compra"
        '
        'NuevaOrdenToolStripMenuItem
        '
        Me.NuevaOrdenToolStripMenuItem.Name = "NuevaOrdenToolStripMenuItem"
        Me.NuevaOrdenToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.NuevaOrdenToolStripMenuItem.Text = "Nueva Orden"
        '
        'VerOrdenToolStripMenuItem
        '
        Me.VerOrdenToolStripMenuItem.Name = "VerOrdenToolStripMenuItem"
        Me.VerOrdenToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.VerOrdenToolStripMenuItem.Text = "Ver Orden"
        '
        'ConsultaPreciosToolStripMenuItem
        '
        Me.ConsultaPreciosToolStripMenuItem.Name = "ConsultaPreciosToolStripMenuItem"
        Me.ConsultaPreciosToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.ConsultaPreciosToolStripMenuItem.Text = "Consulta Precios"
        '
        'PresupuestosToolStripMenuItem
        '
        Me.PresupuestosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AprobadosToolStripMenuItem})
        Me.PresupuestosToolStripMenuItem.Name = "PresupuestosToolStripMenuItem"
        Me.PresupuestosToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.PresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'AprobadosToolStripMenuItem
        '
        Me.AprobadosToolStripMenuItem.Name = "AprobadosToolStripMenuItem"
        Me.AprobadosToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.AprobadosToolStripMenuItem.Text = "Aprobados"
        '
        'MontajeToolStripMenuItem
        '
        Me.MontajeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem1, Me.EmpresaMontajeToolStripMenuItem, Me.FacturaToolStripMenuItem})
        Me.MontajeToolStripMenuItem.Name = "MontajeToolStripMenuItem"
        Me.MontajeToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.MontajeToolStripMenuItem.Text = "Montaje"
        '
        'PagosToolStripMenuItem1
        '
        Me.PagosToolStripMenuItem1.Name = "PagosToolStripMenuItem1"
        Me.PagosToolStripMenuItem1.Size = New System.Drawing.Size(208, 26)
        Me.PagosToolStripMenuItem1.Text = "Pagos"
        '
        'EmpresaMontajeToolStripMenuItem
        '
        Me.EmpresaMontajeToolStripMenuItem.Name = "EmpresaMontajeToolStripMenuItem"
        Me.EmpresaMontajeToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.EmpresaMontajeToolStripMenuItem.Text = "Empresa Montaje"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "DsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CuentaTableAdapter = Nothing
        Me.TableAdapterManager.FacturaProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager.FacturaProveedorTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.MonedasTableAdapter = Nothing
        Me.TableAdapterManager.SubCuentaTableAdapter = Nothing
        Me.TableAdapterManager.SubGrupoTableAdapter = Nothing
        Me.TableAdapterManager.TipoDeCuentaTableAdapter = Nothing
        Me.TableAdapterManager.TipoTransacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsContabilidadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmContabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsContabilidad As ModuloGestion.DsContabilidad
   
    Friend WithEvents TableAdapterManager As ModuloGestion.DsContabilidadTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CatalogoDeCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosRecibidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeCreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConducesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasDeDebitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveevoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuecoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NievoPorveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApuntesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoTiempoTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NominaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvanceEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubGruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InActivosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeCompraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevaOrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerOrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AprobadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaPreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MontajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpresaMontajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratoObraToolStripMenuItem As ToolStripMenuItem
End Class
