Imports System.Windows.Forms
Imports System.Drawing

Public Module ModuloEstiloGeneral

    Private ReadOnly ColorFondo As Color = Color.FromArgb(245, 247, 250)
    Private ReadOnly ColorSuperficie As Color = Color.White
    Private ReadOnly ColorTexto As Color = Color.FromArgb(33, 37, 41)
    Private ReadOnly ColorTextoSecundario As Color = Color.FromArgb(96, 104, 112)
    Private ReadOnly ColorBorde As Color = Color.FromArgb(222, 226, 230)
    Private ReadOnly ColorPrimario As Color = Color.FromArgb(44, 62, 80)
    Private ReadOnly ColorPrimarioSuave As Color = Color.FromArgb(235, 240, 246)

    Public Sub AplicarEstiloFormulario(ByVal formulario As Form)
        ' Aplicar al formulario general
        formulario.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        formulario.BackColor = ColorFondo
        formulario.StartPosition = FormStartPosition.CenterScreen

        ' Aplicar a los controles internos
        AplicarEstiloAControles(formulario)
    End Sub

    Private Sub AplicarEstiloAControles(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls

            ' Aplicar estilo por tipo de control
            Select Case True
                Case TypeOf ctrl Is Label
                    ctrl.ForeColor = ColorTexto
                    ctrl.Font = New Font("Segoe UI", 9, FontStyle.Regular)

                Case TypeOf ctrl Is Button
                    Dim btn = DirectCast(ctrl, Button)
                    btn.FlatStyle = FlatStyle.Flat
                    btn.BackColor = ColorSuperficie
                    btn.ForeColor = ColorPrimario
                    btn.Font = New Font("Segoe UI Semibold", 9.5, FontStyle.Bold)
                    btn.FlatAppearance.BorderColor = ColorBorde
                    btn.FlatAppearance.BorderSize = 1
                    btn.FlatAppearance.MouseOverBackColor = ColorPrimarioSuave
                    btn.FlatAppearance.MouseDownBackColor = ColorPrimarioSuave

                Case TypeOf ctrl Is TextBox
                    Dim txt = DirectCast(ctrl, TextBox)
                    txt.BackColor = ColorSuperficie
                    txt.ForeColor = ColorTexto
                    txt.BorderStyle = BorderStyle.FixedSingle
                    txt.Font = New Font("Segoe UI", 9)

                Case TypeOf ctrl Is ComboBox
                    Dim cmb = DirectCast(ctrl, ComboBox)
                    cmb.BackColor = ColorSuperficie
                    cmb.ForeColor = ColorTexto
                    cmb.FlatStyle = FlatStyle.Flat
                    cmb.Font = New Font("Segoe UI", 9)

                Case TypeOf ctrl Is DataGridView
                    Dim dgv = DirectCast(ctrl, DataGridView)
                    dgv.BackgroundColor = ColorSuperficie
                    dgv.GridColor = ColorBorde
                    dgv.DefaultCellStyle.Font = New Font("Segoe UI", 8.75)
                    dgv.DefaultCellStyle.ForeColor = ColorTexto
                    dgv.DefaultCellStyle.SelectionBackColor = ColorPrimarioSuave
                    dgv.DefaultCellStyle.SelectionForeColor = ColorTexto
                    dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimario
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorSuperficie
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                    dgv.EnableHeadersVisualStyles = False


                Case TypeOf ctrl Is GroupBox
                    ctrl.Font = New Font("Segoe UI Semibold", 9, FontStyle.Bold)
                    ctrl.ForeColor = ColorTextoSecundario

                Case TypeOf ctrl Is Panel
                    ctrl.BackColor = ColorFondo
            End Select

            ' Recursividad para controles hijos
            If ctrl.HasChildren Then
                AplicarEstiloAControles(ctrl)
            End If
        Next
    End Sub

End Module
