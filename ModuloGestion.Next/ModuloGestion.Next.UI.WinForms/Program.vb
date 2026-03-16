Imports System
Imports System.Windows.Forms

Namespace Bootstrap
    Friend Module Program
        <STAThread>
        Public Sub Main()
            System.Windows.Forms.Application.EnableVisualStyles()
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

            Using frmLogin As New Forms.Auth.FrmLogin()
                If frmLogin.ShowDialog() <> Global.System.Windows.Forms.DialogResult.OK Then
                    Return
                End If
            End Using

            System.Windows.Forms.Application.Run(New Forms.Common.FrmShell())
        End Sub
    End Module
End Namespace
