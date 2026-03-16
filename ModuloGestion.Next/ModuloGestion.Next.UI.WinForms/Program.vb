Imports System
Imports System.Windows.Forms

Namespace Bootstrap
    Friend Module Program
        <STAThread>
        Public Sub Main()
            System.Windows.Forms.Application.EnableVisualStyles()
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
            System.Windows.Forms.Application.Run(New Forms.Common.FrmShell())
        End Sub
    End Module
End Namespace
