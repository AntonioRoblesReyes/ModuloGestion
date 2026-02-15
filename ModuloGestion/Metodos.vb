Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms

Module Metodos

    ' Mantiene compatibilidad con llamadas existentes (nombre histórico).
    Public Sub Cerrardatset(ByVal formulario As Form)
        CerrarDataset(formulario)
    End Sub

    Public Sub CerrarDataset(ByVal formulario As Form)
        If formulario Is Nothing Then Return

        For Each control As Control In ObtenerControlesRecursivo(formulario)
            Dim grid = TryCast(control, DataGridView)
            If grid IsNot Nothing Then
                grid.DataSource = Nothing
            End If

            Dim binding = TryCast(control.DataBindings, ControlBindingsCollection)
            If binding IsNot Nothing Then
                For Each item As Binding In binding
                    Dim dataSet = TryCast(item.DataSource, DataSet)
                    If dataSet IsNot Nothing Then
                        dataSet.Dispose()
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub CerrarGrill(ByVal formulario As Form)
        If formulario Is Nothing Then Return

        For Each control As Control In ObtenerControlesRecursivo(formulario)
            Dim grid = TryCast(control, DataGridView)
            If grid IsNot Nothing Then
                grid.DataSource = Nothing
            End If
        Next
    End Sub

    Public Function EstaAbierto(ByVal myForm As Form) As Boolean
        If myForm Is Nothing Then Return False
        Return EstaAbierto(myForm.Name)
    End Function

    Public Function EstaAbierto(ByVal nombreFormulario As String) As Boolean
        If String.IsNullOrWhiteSpace(nombreFormulario) Then Return False

        For Each openForm As Form In Application.OpenForms
            If String.Equals(openForm.Name, nombreFormulario, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function ObtenerControlesRecursivo(ByVal padre As Control) As List(Of Control)
        Dim resultado As New List(Of Control)()
        AgregarControles(padre, resultado)
        Return resultado
    End Function

    Private Sub AgregarControles(ByVal padre As Control, ByVal resultado As List(Of Control))
        For Each hijo As Control In padre.Controls
            resultado.Add(hijo)
            If hijo.HasChildren Then
                AgregarControles(hijo, resultado)
            End If
        Next
    End Sub

End Module
