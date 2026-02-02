Imports System.ComponentModel

Public Class FrmFacturaMontajeEditar

    '======================================================
    '                     LOAD
    '======================================================
    Private Sub FrmFacturaMontajeEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PresupuestoTableAdapter.Fill(DsPagosMontaje.Presupuesto)
            PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
            EmpresasContratadasMontajeTableAdapter.FillByActivas(DsPagosMontaje.EmpresasContratadasMontaje)

        Catch ex As Exception
            MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '======================================================
    '                  MODIFICAR FACTURA
    '======================================================
    Sub ModificarFactura()
        Try
            Me.Show()
            ArticulosTableAdapter.Fill(DsArticulos.Articulos)

            '========================
            ' CARGAR EMPRESAS (COMBO)
            '========================
            EmpresasContratadasMontajeTableAdapter.Fill(
            DsPagosMontaje.EmpresasContratadasMontaje
        )

            '========================
            ' CARGAR FACTURA
            '========================
            FacturaMontajeTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontaje,
            IdFacturaTextBox.Text
        )

            If FacturaMontajeBindingSource.Current Is Nothing Then
                MessageBox.Show("Factura no encontrada.")
                Exit Sub
            End If

            '========================
            ' POSICIONAR LA EMPRESA
            '========================
            Dim idEmpresa As String =
            CType(FacturaMontajeBindingSource.Current, DataRowView)(
                "IdEmpresaMontaje"
            ).ToString()

            EmpresasContratadasMontajeBindingSource.Position =
            EmpresasContratadasMontajeBindingSource.Find(
                "IdEmpresaMontaje",
                idEmpresa
            )

            '========================
            ' DETALLE FACTURA
            '========================
            FacturaMontajeDetalleTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontajeDetalle,
            IdFacturaTextBox.Text
        )

            '========================
            ' PRESUPUESTO
            '========================
            Dim idPresupuesto As String =
            CType(FacturaMontajeBindingSource.Current, DataRowView)(
                "Id_Presupuesto"
            ).ToString()

            PresupuestoDetalleTableAdapter.FillByIdPresupuesto(
            DsPagosMontaje.PresupuestoDetalle,
            idPresupuesto
        )

        Catch ex As Exception
            MessageBox.Show("Error cargando la factura: " & ex.Message)
        End Try
    End Sub



    '======================================================
    '                  NUEVA FACTURA
    '======================================================
    Sub PrepararNuevaFactura()
        Try
            ArticulosTableAdapter.Fill(DsArticulos.Articulos)
            IdFacturaTextBox.Text = FacturaMontajeTableAdapter.SiguienteFactura()
            PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsPagosMontaje.PresupuestoDetalle, LblPresupuesto.Text)
            Me.Show()
        Catch ex As Exception
            MessageBox.Show($"Error al crear nueva factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '======================================================
    '             NUEVA LINEA DE DETALLE
    '======================================================
    Sub NuevaLinea()
        Try
            Using cn As New SqlClient.SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlClient.SqlCommand("sp_InsertarFacturaMontajeDetalle", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@IdFactura", IdFacturaTextBox.Text)
                    cmd.Parameters.AddWithValue("@IdDetallePres", DBNull.Value)
                    cmd.Parameters.AddWithValue("@IdArticulo", DBNull.Value)
                    cmd.Parameters.AddWithValue("@Descripcion", "NUEVA LÍNEA")
                    cmd.Parameters.AddWithValue("@Cantidad", 0)
                    cmd.Parameters.AddWithValue("@Precio", 0)
                    cmd.Parameters.AddWithValue("@IdPresupuesto", LblPresupuesto.Text)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' 🔄 Refrescar detalle
            FacturaMontajeDetalleTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontajeDetalle,
            IdFacturaTextBox.Text
        )

            ' 🔄 Refrescar cabecera
            FacturaMontajeTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontaje,
            IdFacturaTextBox.Text
        )

        Catch ex As Exception
            MsgBox("Error al agregar nueva línea: " & ex.Message)
        End Try
    End Sub

    Sub NuevoApuntePresupuesto()

        Dim Factura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje

        Dim nuevoIdDetalle As String = Me.FacturaMontajeDetalleTableAdapter.SiguienteDetalle(IdFacturaTextBox.Text)
        
        Try
            '===============================================
            ' 1. VALIDAR QUE HAY FILA ACTUAL
            '===============================================
            If PresupuestoDetalleDataGridView.CurrentRow Is Nothing Then
                MessageBox.Show("No hay fila seleccionada.")
                Exit Sub
            End If

            Dim fila As DataGridViewRow =
            PresupuestoDetalleDataGridView.CurrentRow

            '===============================================
            ' 2. OBTENER DATOS (SIN NULLS)
            '===============================================
            Dim idDetallePres As String =
            fila.Cells("IdDetallePresupuesto").Value.ToString().Trim()

            Dim idArticulo As String =
            fila.Cells("IdArticulo").Value.ToString().Trim()

            Dim descripcion As String =
            fila.Cells("IdArticulo").FormattedValue.ToString().Trim()

            Dim cantidad As Decimal =
            Convert.ToDecimal(fila.Cells("Cantidad").Value)

            Dim precio As Decimal =
            Convert.ToDecimal(fila.Cells("Previsto").Value)

            Dim totalPartida As Decimal = cantidad * precio






            '===============================================
            ' 4. INSERTAR EN SQL
            '===============================================
            FacturaMontajeDetalleTableAdapter.Insert(
            nuevoIdDetalle,
            IdFacturaTextBox.Text,
            idDetallePres,
            idArticulo,
            descripcion,
            cantidad,
            precio,
            totalPartida,
            LblPresupuesto.Text.Trim()
        )

            '===============================================
            ' 5. REFRESCAR GRID
            '===============================================
            FacturaMontajeDetalleTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontajeDetalle,
            IdFacturaTextBox.Text)




            '===============================================
            ' 7. RECALCULAR
            '===============================================
            SumaTotal()

        Catch ex As Exception
            MessageBox.Show(
            "Error al agregar nuevo apunte: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub



    Sub SumaTotal()

        ' Esta versión NO calcula nada
        ' Solo pide a SQL que recalcule y refresca pantalla

        Try
            Using cn As New SqlClient.SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlClient.SqlCommand("sp_RecalcularFacturaMontaje", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@IdFactura", IdFacturaTextBox.Text)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' 🔄 Refrescar factura (cabecera)
            FacturaMontajeTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontaje,
            IdFacturaTextBox.Text
        )

        Catch ex As Exception
            MessageBox.Show(
            "Error al recalcular factura: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub


    '======================================================
    '                EVENTOS DE INTERFAZ
    '======================================================
    Private Sub RetencionIRSTextBox_Leave(sender As Object, e As EventArgs) Handles RetencionIRSTextBox.Leave
        SumaTotal()
    End Sub
    Private Sub FacturaMontajeDetalleDataGridView_CellEndEdit(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles FacturaMontajeDetalleDataGridView.CellEndEdit

        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim row As DataGridViewRow =
            FacturaMontajeDetalleDataGridView.Rows(e.RowIndex)

            ' 🔑 ID del detalle
            Dim idDetalle As String =
            row.Cells("IdFacturaMontajeDetalle").Value.ToString()

            ' 🔢 Valores actuales (SIEMPRE)
            Dim cantidad As Decimal = 0
            Dim precio As Decimal = 0

            Decimal.TryParse(Convert.ToString(row.Cells(5).Value), cantidad)
            Decimal.TryParse(Convert.ToString(row.Cells(6).Value), precio)

            ' ✏️ Descripción (puede cambiar o no)
            Dim descripcion As String =
            Convert.ToString(row.Cells(4).Value)

            ' 🔵 SQL MANDA
            Using cn As New SqlClient.SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlClient.SqlCommand("sp_ActualizarDetalleFacturaMontaje", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@IdDetalleFactura", idDetalle)
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@Precio", precio)
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' 🔄 refrescar detalle y cabecera
            FacturaMontajeDetalleTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontajeDetalle,
            IdFacturaTextBox.Text
        )

            FacturaMontajeTableAdapter.FillByIdFactura(
            DsPagosMontaje.FacturaMontaje,
            IdFacturaTextBox.Text
        )

        Catch ex As Exception
            MessageBox.Show(
            "Error al actualizar el detalle: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub




    Private Sub FacturaMontajeDetalleDataGridView_RowsRemoved(
    sender As Object,
    e As DataGridViewRowsRemovedEventArgs
) Handles FacturaMontajeDetalleDataGridView.RowsRemoved

        Try
            BeginInvoke(Sub()

                            ' 1️⃣ Confirmar cambios locales
                            FacturaMontajeDetalleBindingSource.EndEdit()

                            ' 2️⃣ Enviar DELETE al SQL -> dispara TRIGGER
                            FacturaMontajeDetalleTableAdapter.Update(
                            DsPagosMontaje.FacturaMontajeDetalle
                        )

                            ' 3️⃣ Recargar cabecera desde SQL
                            FacturaMontajeTableAdapter.FillByIdFactura(
                            DsPagosMontaje.FacturaMontaje,
                            IdFacturaTextBox.Text
                        )

                            ' 4️⃣ Actualizar pantalla
                            SumaTotal()

                        End Sub)

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el detalle: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ImpuestoTextBox_Leave(sender As Object, e As EventArgs) Handles ImpuestoTextBox.Leave
        SumaTotal()
    End Sub
    Private Sub FormatearNumericosN2()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)

                ' ⛔ EXCLUIR IDs
                If txt Is IdFacturaTextBox Then Continue For
                If txt Is IdEmpresaMontajeTextBox Then Continue For
                If txt Is LblPresupuesto Then Continue For

                Dim valor As Double
                If Double.TryParse(txt.Text, valor) Then
                    txt.Text = valor.ToString("N2")
                End If
            End If
        Next
    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles PresupuestoDetalleDataGridView.CellClick

        Try
            ' Evitar encabezados
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

            ' Solo columna Añadir
            If PresupuestoDetalleDataGridView.Columns(e.ColumnIndex).Name <> "Añadir" Then Exit Sub

            ' Forzar fila correcta
            PresupuestoDetalleDataGridView.CurrentCell =
            PresupuestoDetalleDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)

            PresupuestoDetalleDataGridView.Rows(e.RowIndex).Selected = True

            ' Llamar al método REAL
            NuevoApuntePresupuesto()


        Catch ex As Exception
            MessageBox.Show("Error al añadir partida: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BtnAprobarPago_Click(sender As Object, e As EventArgs) Handles BtnAprobarPago.Click
        Try
            If FacturaMontajeTableAdapter.ExisteFactura(IdFacturaTextBox.Text) Then
                MsgBox("La factura ya está creada.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' 1️⃣ Crear factura en SQL
            FacturaMontajeTableAdapter.Nueva(
            IdFacturaTextBox.Text,
            IdEmpresaMontajeTextBox.Text,
            FechaPAgoDateTimePicker.Value,
            LblProyecto.Text,
            LblPresupuesto.Text,
            0, 0, 0, "", 0, 0
        )

            MsgBox("Factura creada exitosamente.", MsgBoxStyle.Information)

            ' 2️⃣ Pasar a modo MODIFICAR (igual que cuando la abres)
            ModificarFactura()

            ' 3️⃣ Inicializar estado visual
            PagadoTextBox.Text = "0"

        Catch ex As Exception
            MsgBox("Error al crear factura: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevalínea_Click(sender As Object, e As EventArgs) Handles BtnNuevalínea.Click
        Try
            Dim nuevoId As String = FacturaMontajeDetalleTableAdapter.SiguienteDetalle(IdFacturaTextBox.Text)

            FacturaMontajeDetalleTableAdapter.Insert(
                nuevoId,
                IdFacturaTextBox.Text,
                "Sin Presupuesto",                ' Id detalle presupuesto vacío
                "Sin Articulo",                ' Id artículo vacío
                "NUEVA LÍNEA",     ' Descripción por defecto
                0,
                0,
                0,
                LblPresupuesto.Text
            )

            FacturaMontajeDetalleTableAdapter.FillByIdFactura(
                DsPagosMontaje.FacturaMontajeDetalle,
                IdFacturaTextBox.Text)

            SumaTotal()

        Catch ex As Exception
            MsgBox("Error creando nueva línea: " & ex.Message)
        End Try
    End Sub

End Class
