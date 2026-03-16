Imports System

Namespace Bootstrap
    Friend Module Program
        <STAThread>
        Public Sub Main()
            Global.System.Windows.Forms.Application.EnableVisualStyles()
            Global.System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

            Using frmLogin As New Forms.Auth.FrmLoginNext()
                If frmLogin.ShowDialog() <> Global.System.Windows.Forms.DialogResult.OK Then
                    Return
                End If
            End Using

            Global.System.Windows.Forms.Application.Run(New Forms.Common.FrmShell())
        End Sub
    End Module
End Namespace
