Namespace dxWinSample
    Partial Public Class XtraReportMain
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo15 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo16 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo17 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReportMain))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "dxWinSample.Properties.Settings.nwindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Categories"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Products"
            relationInfo1.ParentTable = "Categories"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1})
            tableInfo1.Name = "Categories"
            columnInfo1.Name = "CategoryID"
            columnInfo2.Name = "CategoryName"
            columnInfo3.Name = "Description"
            columnInfo4.Name = "Picture"
            columnInfo5.Name = "Icon_17"
            columnInfo6.Name = "Icon_25"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6})
            tableInfo2.Name = "Products"
            columnInfo7.Name = "ProductID"
            columnInfo8.Name = "ProductName"
            columnInfo9.Name = "SupplierID"
            columnInfo10.Alias = "Products_CategoryID"
            columnInfo10.Name = "CategoryID"
            columnInfo11.Name = "QuantityPerUnit"
            columnInfo12.Name = "UnitPrice"
            columnInfo13.Name = "UnitsInStock"
            columnInfo14.Name = "UnitsOnOrder"
            columnInfo15.Name = "ReorderLevel"
            columnInfo16.Name = "Discontinued"
            columnInfo17.Name = "EAN13"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15, columnInfo16, columnInfo17})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.GroupHeader1.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Italic)
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 49.04167F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.StylePriority.UseFont = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 49.04167F)
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(585.4167F, 25F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.ProductName")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.2857142857142857R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.UnitPrice")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.2857142857142857R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.UnitsOnOrder")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.2857142857142857R
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.HeightF = 0F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' XtraReportMain
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "15.1"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    End Class
End Namespace
