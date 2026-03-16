Option Strict On
Option Infer On

Imports System
Imports System.Windows.Forms
Imports ModuloGestion.Next.UI.WinForms.Forms.Auth
Imports ModuloGestion.Next.UI.WinForms.Forms.Common

Module Program

    <STAThread>
    Sub Main()

        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

        Dim authService As IAuthAppService = New AuthAppService()

        Dim login As New FrmLoginNext(authService)

        If login.ShowDialog() = DialogResult.OK Then
            System.Windows.Forms.Application.Run(New FrmMainShellNext(login.Usuario))
        End If

    End Sub

End Module