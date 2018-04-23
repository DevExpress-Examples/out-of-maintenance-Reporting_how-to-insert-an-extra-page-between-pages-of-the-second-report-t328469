using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace dxWinSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            XtraReport report = GetReport();
            new ReportPrintTool(report).ShowRibbonPreview();
        }
        private XtraReport GetReport() {
            XtraReport mainReport = new XtraReportMain();
            mainReport.CreateDocument();
            XtraReport infoReport = new XtraReportInformation(mainReport.Pages.Count);
            infoReport.CreateDocument();
            int minPageCount = Math.Min(mainReport.Pages.Count, infoReport.Pages.Count);
            for(int i = 0; i < minPageCount; i++) {
                mainReport.Pages.Insert(i * 2 + 1, infoReport.Pages[i]);
            }
            return mainReport;
        }
    }
}
