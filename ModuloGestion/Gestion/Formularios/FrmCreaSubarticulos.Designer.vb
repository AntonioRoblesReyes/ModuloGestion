<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreaSubarticulos
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
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticuloNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubArticulosListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubArticulosDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubArticuloNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerrajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerHerrajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoHerrajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPinturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompoenetesvPinturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GargarProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoSubArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Trasportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaTransporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConductoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mantenimientousuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.ProyectosToolStripMenuItem, Me.PresupuestosToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.HerrajesToolStripMenuItem, Me.PinturaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.GargarProyectosToolStripMenuItem, Me.GrupoSubArticuloToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.Trasportes, Me.PreciosCompraToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1268, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerClientesToolStripMenuItem, Me.ClientesToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ClientesToolStripMenuItem.Text = "Marcos"
        '
        'VerClientesToolStripMenuItem
        '
        Me.VerClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallesToolStripMenuItem})
        Me.VerClientesToolStripMenuItem.Name = "VerClientesToolStripMenuItem"
        Me.VerClientesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.VerClientesToolStripMenuItem.Text = "Marco Compuesto"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ClientesToolStripMenuItem1.Text = "Marco Mazizo"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerEmpresasToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.NuevaEmpresaToolStripMenuItem})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'VerEmpresasToolStripMenuItem
        '
        Me.VerEmpresasToolStripMenuItem.Name = "VerEmpresasToolStripMenuItem"
        Me.VerEmpresasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.VerEmpresasToolStripMenuItem.Text = "Ver Empresas"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'NuevaEmpresaToolStripMenuItem
        '
        Me.NuevaEmpresaToolStripMenuItem.Name = "NuevaEmpresaToolStripMenuItem"
        Me.NuevaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NuevaEmpresaToolStripMenuItem.Text = "Nueva Empresa"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerProyectosToolStripMenuItem, Me.ProyectoToolStripMenuItem})
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'VerProyectosToolStripMenuItem
        '
        Me.VerProyectosToolStripMenuItem.Name = "VerProyectosToolStripMenuItem"
        Me.VerProyectosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VerProyectosToolStripMenuItem.Text = "Ver Proyectos"
        '
        'ProyectoToolStripMenuItem
        '
        Me.ProyectoToolStripMenuItem.Name = "ProyectoToolStripMenuItem"
        Me.ProyectoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ProyectoToolStripMenuItem.Text = "Proyecto"
        '
        'PresupuestosToolStripMenuItem
        '
        Me.PresupuestosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPresupuestosToolStripMenuItem, Me.NuevoPresupuestoToolStripMenuItem})
        Me.PresupuestosToolStripMenuItem.Name = "PresupuestosToolStripMenuItem"
        Me.PresupuestosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'VerPresupuestosToolStripMenuItem
        '
        Me.VerPresupuestosToolStripMenuItem.Name = "VerPresupuestosToolStripMenuItem"
        Me.VerPresupuestosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.VerPresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'NuevoPresupuestoToolStripMenuItem
        '
        Me.NuevoPresupuestoToolStripMenuItem.Name = "NuevoPresupuestoToolStripMenuItem"
        Me.NuevoPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NuevoPresupuestoToolStripMenuItem.Text = "Nuevo Presupuesto"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem1, Me.NuevoToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ArticulosToolStripMenuItem1
        '
        Me.ArticulosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosListadoToolStripMenuItem, Me.ArticulosDetalleToolStripMenuItem, Me.ArticuloNuevoToolStripMenuItem})
        Me.ArticulosToolStripMenuItem1.Name = "ArticulosToolStripMenuItem1"
        Me.ArticulosToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ArticulosToolStripMenuItem1.Text = "Articulos"
        '
        'ArticulosListadoToolStripMenuItem
        '
        Me.ArticulosListadoToolStripMenuItem.Name = "ArticulosListadoToolStripMenuItem"
        Me.ArticulosListadoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ArticulosListadoToolStripMenuItem.Text = "Articulos Listado"
        '
        'ArticulosDetalleToolStripMenuItem
        '
        Me.ArticulosDetalleToolStripMenuItem.Name = "ArticulosDetalleToolStripMenuItem"
        Me.ArticulosDetalleToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ArticulosDetalleToolStripMenuItem.Text = "Articulos Detalle"
        '
        'ArticuloNuevoToolStripMenuItem
        '
        Me.ArticuloNuevoToolStripMenuItem.Name = "ArticuloNuevoToolStripMenuItem"
        Me.ArticuloNuevoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ArticuloNuevoToolStripMenuItem.Text = "Articulo Nuevo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubArticulosListadoToolStripMenuItem, Me.SubArticulosDetalleToolStripMenuItem, Me.SubArticuloNuevoToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NuevoToolStripMenuItem.Text = "SubArticulos"
        '
        'SubArticulosListadoToolStripMenuItem
        '
        Me.SubArticulosListadoToolStripMenuItem.Name = "SubArticulosListadoToolStripMenuItem"
        Me.SubArticulosListadoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SubArticulosListadoToolStripMenuItem.Text = "SubArticulos Listado"
        '
        'SubArticulosDetalleToolStripMenuItem
        '
        Me.SubArticulosDetalleToolStripMenuItem.Name = "SubArticulosDetalleToolStripMenuItem"
        Me.SubArticulosDetalleToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SubArticulosDetalleToolStripMenuItem.Text = "SubArticulos Detalle"
        '
        'SubArticuloNuevoToolStripMenuItem
        '
        Me.SubArticuloNuevoToolStripMenuItem.Name = "SubArticuloNuevoToolStripMenuItem"
        Me.SubArticuloNuevoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SubArticuloNuevoToolStripMenuItem.Text = "SubArticulo Nuevo"
        '
        'HerrajesToolStripMenuItem
        '
        Me.HerrajesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerHerrajesToolStripMenuItem, Me.IngresoHerrajesToolStripMenuItem})
        Me.HerrajesToolStripMenuItem.Name = "HerrajesToolStripMenuItem"
        Me.HerrajesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HerrajesToolStripMenuItem.Text = "Herrajes"
        '
        'VerHerrajesToolStripMenuItem
        '
        Me.VerHerrajesToolStripMenuItem.Name = "VerHerrajesToolStripMenuItem"
        Me.VerHerrajesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VerHerrajesToolStripMenuItem.Text = "Ver Herrajes"
        '
        'IngresoHerrajesToolStripMenuItem
        '
        Me.IngresoHerrajesToolStripMenuItem.Name = "IngresoHerrajesToolStripMenuItem"
        Me.IngresoHerrajesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.IngresoHerrajesToolStripMenuItem.Text = "Ingreso herrajes"
        '
        'PinturaToolStripMenuItem
        '
        Me.PinturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPinturaToolStripMenuItem, Me.CompoenetesvPinturaToolStripMenuItem})
        Me.PinturaToolStripMenuItem.Name = "PinturaToolStripMenuItem"
        Me.PinturaToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.PinturaToolStripMenuItem.Text = "Pintura"
        '
        'VerPinturaToolStripMenuItem
        '
        Me.VerPinturaToolStripMenuItem.Name = "VerPinturaToolStripMenuItem"
        Me.VerPinturaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VerPinturaToolStripMenuItem.Text = "Ver Pintura"
        '
        'CompoenetesvPinturaToolStripMenuItem
        '
        Me.CompoenetesvPinturaToolStripMenuItem.Name = "CompoenetesvPinturaToolStripMenuItem"
        Me.CompoenetesvPinturaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CompoenetesvPinturaToolStripMenuItem.Text = "Componetes Pintura"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresListadoToolStripMenuItem1})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ReporteToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresListadoToolStripMenuItem1
        '
        Me.ProveedoresListadoToolStripMenuItem1.Name = "ProveedoresListadoToolStripMenuItem1"
        Me.ProveedoresListadoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresListadoToolStripMenuItem1.Text = "Proveedores Listado"
        '
        'GargarProyectosToolStripMenuItem
        '
        Me.GargarProyectosToolStripMenuItem.Name = "GargarProyectosToolStripMenuItem"
        Me.GargarProyectosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.GargarProyectosToolStripMenuItem.Text = "Materiales"
        '
        'GrupoSubArticuloToolStripMenuItem
        '
        Me.GrupoSubArticuloToolStripMenuItem.Name = "GrupoSubArticuloToolStripMenuItem"
        Me.GrupoSubArticuloToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.GrupoSubArticuloToolStripMenuItem.Text = "Grupo SubArticulos"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'Trasportes
        '
        Me.Trasportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaTransporteToolStripMenuItem, Me.VehiculosToolStripMenuItem, Me.ConductoresToolStripMenuItem})
        Me.Trasportes.Name = "Trasportes"
        Me.Trasportes.Size = New System.Drawing.Size(80, 20)
        Me.Trasportes.Text = "Transportes"
        '
        'EmpresaTransporteToolStripMenuItem
        '
        Me.EmpresaTransporteToolStripMenuItem.Name = "EmpresaTransporteToolStripMenuItem"
        Me.EmpresaTransporteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EmpresaTransporteToolStripMenuItem.Text = "Empresa Transporte"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'ConductoresToolStripMenuItem
        '
        Me.ConductoresToolStripMenuItem.Name = "ConductoresToolStripMenuItem"
        Me.ConductoresToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ConductoresToolStripMenuItem.Text = "Conductores"
        '
        'PreciosCompraToolStripMenuItem
        '
        Me.PreciosCompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mstUsuarios, Me.mantenimientousuariosToolStripMenuItem1})
        Me.PreciosCompraToolStripMenuItem.Name = "PreciosCompraToolStripMenuItem"
        Me.PreciosCompraToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.PreciosCompraToolStripMenuItem.Text = "Usuarios"
        '
        'mstUsuarios
        '
        Me.mstUsuarios.Name = "mstUsuarios"
        Me.mstUsuarios.Size = New System.Drawing.Size(204, 22)
        Me.mstUsuarios.Text = "Cambio Contraseña"
        '
        'mantenimientousuariosToolStripMenuItem1
        '
        Me.mantenimientousuariosToolStripMenuItem1.Name = "mantenimientousuariosToolStripMenuItem1"
        Me.mantenimientousuariosToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.mantenimientousuariosToolStripMenuItem1.Text = "Mantenimiento Usuarios"
        '
        'DetallesToolStripMenuItem
        '
        Me.DetallesToolStripMenuItem.Name = "DetallesToolStripMenuItem"
        Me.DetallesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DetallesToolStripMenuItem.Text = "Detalles"
        '
        'FrmCreaSubarticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 765)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmCreaSubarticulos"
        Me.Text = "Crear Sub Articulos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerEmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaEmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerProyectosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerPresupuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticuloNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubArticulosListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubArticulosDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubArticuloNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerrajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerHerrajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoHerrajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PinturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerPinturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompoenetesvPinturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresListadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GargarProyectosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoSubArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Trasportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaTransporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConductoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mstUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mantenimientousuariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetallesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
