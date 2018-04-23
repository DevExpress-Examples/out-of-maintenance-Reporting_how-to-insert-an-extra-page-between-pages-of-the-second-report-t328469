using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace dxWinSample {
    public partial class XtraReportInformation : DevExpress.XtraReports.UI.XtraReport {
        public XtraReportInformation() {
            InitializeComponent();
        }

        public XtraReportInformation(int p) {
            InitializeComponent();
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = p;               
        }

    }
}
