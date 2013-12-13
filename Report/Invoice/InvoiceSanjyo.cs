using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Jisseki_Report_Ibaraki.Report
{
    /// <summary>
    /// Invoice の概要の説明です。
    /// </summary>
    public partial class InvoiceSanjyo : DataDynamics.ActiveReports.ActiveReport
    {



        public InvoiceSanjyo()
        {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {

        }

        private void Invoice_ReportStart(object sender, EventArgs e)
        {

        }
    }
}
