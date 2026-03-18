Option Strict On
Option Infer On

Imports System
Imports System.Windows.Forms
Imports ModuloGestion.Next.Application.Auth
Imports ModuloGestion.Next.Infrastructure.SqlServer
Imports ModuloGestion.Next.UI.WinForms.Forms.Auth
Imports ModuloGestion.Next.UI.WinForms.Forms.Common

Module Program

    <STAThread>
    Sub Main()

        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

        Dim repository As IUserAuthRepository = New SqlUserAuthRepository()
        Dim authService As IAuthAppService = New AuthAppService(repository)

        Dim login As New FrmLoginNext(authService)

        If login.ShowDialog() = DialogResult.OK AndAlso login.ResultadoLogin IsNot Nothing Then
            System.Windows.Forms.Application.Run(New FrmMainShellNext(login.ResultadoLogin.Usuario, login.ResultadoLogin.Categoria))
        End If

    End Sub

End Module
