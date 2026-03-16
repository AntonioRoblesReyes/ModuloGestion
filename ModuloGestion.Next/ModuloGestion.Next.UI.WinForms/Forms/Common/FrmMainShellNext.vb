Option Strict On
Option Infer On

Imports System.Windows.Forms

Namespace Forms.Common

    Public Class FrmMainShellNext
        Inherits Form

        Private ReadOnly _usuario As String

        Public Sub New(usuario As String)

            _usuario = usuario

            Me.Text = "ModuloGestion.Next - Principal (" & usuario & ")"
            Me.WindowState = FormWindowState.Maximized

        End Sub

    End Class

End Namespace