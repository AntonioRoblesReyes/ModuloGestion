Module Metodos
    Public Sub Cerrardatset(ByVal formulario As Form)
        Dim dataset As Object
        For Each dataset In formulario.Controls
            If TypeOf dataset Is DataSet Then
                Dim datasettemp As DataSet = CType(dataset, DataSet)
                datasettemp.Dispose()
            End If
        Next
    End Sub
    Public Sub CerrarGrill(ByVal formulario As Form)
        Dim cerrarGrill As Object
        For Each cerrarGrill In formulario.Controls
            If TypeOf cerrarGrill Is DataGridView Then
                Dim cerrarGrilltemp As DataGridView = CType(cerrarGrill, DataGridView)
                cerrarGrilltemp.DataSource = Nothing
            End If
        Next
    End Sub
    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function


End Module
