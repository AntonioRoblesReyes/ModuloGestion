Option Strict On
Option Infer On

Imports System.Windows.Forms

Namespace Forms.Common

    Public Class FrmMainShellNext
        Inherits Form

        Private ReadOnly _usuario As String
        Private ReadOnly _categoria As Integer

        Public Sub New(usuario As String, categoria As Integer)

            _usuario = usuario
            _categoria = categoria

            Me.Text = "ModuloGestion.Next - Principal (" & usuario & ")"
            Me.WindowState = FormWindowState.Maximized

            Dim lblEstado As New Label With {
                .AutoSize = True,
                .Left = 20,
                .Top = 20,
                .Text = "Usuario: " & _usuario & " | Categoría: " & _categoria.ToString()
            }

            Controls.Add(lblEstado)

        End Sub

    End Class

End Namespace
