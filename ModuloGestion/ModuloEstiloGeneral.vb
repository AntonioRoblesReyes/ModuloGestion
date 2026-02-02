Imports System.Windows.Forms
Imports System.Drawing

Public Module ModuloEstiloGeneral

    Public Sub AplicarEstiloFormulario(ByVal formulario As Form)
        ' Aplicar al formulario general
        formulario.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        formulario.BackColor = Color.WhiteSmoke
        formulario.StartPosition = FormStartPosition.CenterScreen

        ' Aplicar a los controles internos
        AplicarEstiloAControles(formulario)
    End Sub

    Private Sub AplicarEstiloAControles(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls

            ' Aplicar estilo por tipo de control
            Select Case True
                Case TypeOf ctrl Is Label
                    ctrl.ForeColor = Color.Black
                    ctrl.Font = New Font("Segoe UI", 9, FontStyle.Regular)

                Case TypeOf ctrl Is Button
                    Dim btn = DirectCast(ctrl, Button)
                    btn.FlatStyle = FlatStyle.Flat
                    btn.BackColor = Color.White
                    btn.ForeColor = Color.Black
                    btn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    btn.FlatAppearance.BorderColor = Color.Silver
                    btn.FlatAppearance.BorderSize = 1

                Case TypeOf ctrl Is TextBox
                    Dim txt = DirectCast(ctrl, TextBox)
                    txt.BackColor = Color.White
                    txt.ForeColor = Color.Black
                    txt.BorderStyle = BorderStyle.FixedSingle
                    txt.Font = New Font("Segoe UI", 9)

                Case TypeOf ctrl Is ComboBox
                    Dim cmb = DirectCast(ctrl, ComboBox)
                    cmb.BackColor = Color.White
                    cmb.ForeColor = Color.Black
                    cmb.FlatStyle = FlatStyle.Flat
                    cmb.Font = New Font("Segoe UI", 9)

                Case TypeOf ctrl Is DataGridView
                    Dim dgv = DirectCast(ctrl, DataGridView)
                    dgv.BackgroundColor = Color.White
                    dgv.GridColor = Color.LightGray
                    dgv.DefaultCellStyle.Font = New Font("Segoe UI", 8.5)
                    dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5, FontStyle.Bold)
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                    dgv.EnableHeadersVisualStyles = False


                Case TypeOf ctrl Is GroupBox
                    ctrl.Font = New Font("Segoe UI", 9, FontStyle.Bold)

                Case TypeOf ctrl Is Panel
                    ctrl.BackColor = Color.WhiteSmoke
            End Select

            ' Recursividad para controles hijos
            If ctrl.HasChildren Then
                AplicarEstiloAControles(ctrl)
            End If
        Next
    End Sub

End Module
