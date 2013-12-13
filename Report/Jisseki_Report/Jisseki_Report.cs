using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Jisseki_Report_Ibaraki.Report
{
    /// <summary>
    /// Jisseki_Report の概要の説明です。
    /// </summary>
    public partial class Jisseki_Report : DataDynamics.ActiveReports.ActiveReport
    {

        public Jisseki_Report()
        {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {

            try
            {
                //初期表示
                JapaneseCalendar jCalender = new JapaneseCalendar();
                int iEra = jCalender.GetEra(DateTime.Now);
                switch (iEra)
                {
                    case 4://平成
                        lblEra.Text = "平成";
                        break;

                    case 3://昭和
                        lblEra.Text = "昭和";

                        break;

                    case 2://大正
                        lblEra.Text = "大正";

                        break;

                    case 1://明治
                        lblEra.Text = "明治";

                        break;

                }
                DateTime JapaneseDate = DateTime.Parse(
                    this.txtYear.Text + "/" +
                    this.txtMonth.Text + "/" +
                    this.txtDay.Text
                           );
                this.txtYear.Text = jCalender.GetYear(JapaneseDate).ToString();
            }
            catch
            {

            }

        }       

    }
}
