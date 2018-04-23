Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace dxWinSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim report As XtraReport = GetReport()
            CType(New ReportPrintTool(report), ReportPrintTool).ShowRibbonPreview()
        End Sub
        Private Function GetReport() As XtraReport
            Dim mainReport As XtraReport = New XtraReportMain()
            mainReport.CreateDocument()
            Dim infoReport As XtraReport = New XtraReportInformation(mainReport.Pages.Count)
            infoReport.CreateDocument()
            Dim minPageCount As Integer = Math.Min(mainReport.Pages.Count, infoReport.Pages.Count)
            For i As Integer = 0 To minPageCount - 1
                mainReport.Pages.Insert(i * 2 + 1, infoReport.Pages(i))
            Next i
            Return mainReport
        End Function
    End Class
End Namespace
