Imports System
Imports System.Windows.Forms

Namespace Bootstrap
    Friend Module Program
        <STAThread>
        Public Sub Main()
            ApplicationConfiguration.Initialize()
            Application.Run(New Forms.Common.FrmShell())
        End Sub
    End Module
End Namespace
