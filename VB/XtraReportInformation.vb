Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace dxWinSample
    Partial Public Class XtraReportInformation
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal p As Integer)
            InitializeComponent()
            Me.ReportPrintOptions.DetailCountOnEmptyDataSource = p
        End Sub

    End Class
End Namespace
