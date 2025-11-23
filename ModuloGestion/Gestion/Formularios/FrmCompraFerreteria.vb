Public Class FrmCompraFerreteria

    Private Sub FerreteriaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FerreteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FerreteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsFerreteria)

    End Sub

    Private Sub FrmCompraFerreteria_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmCompraFerreteria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsFerreteria.Ferreteria' Puede moverla o quitarla según sea necesario.
        Me.FerreteriaTableAdapter.Fill(Me.DsFerreteria.Ferreteria)

    End Sub

    Private Sub BtnNuevoElemento_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevoElemento.Click
        My.Forms.FrmFerreteria.Close()
        My.Forms.FrmFerreteria.Show()
    End Sub





    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.FerreteriaTableAdapter.FillByDescripcion(Me.DsFerreteria.Ferreteria, "%" & TextBox1.Text & "%")
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'My.Forms.FrmCompras.AnexarFerreteria()
        'Dim idElemento As String = Me.DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).IdFerreteria
        'My.Forms.FrmIngresoCompras.LblIdFerreteria.Text = idElemento
        'My.Forms.FrmIngresoCompras.AnexarFerreteria()
    End Sub
End Class