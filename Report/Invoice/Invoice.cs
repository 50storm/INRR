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
    public partial class Invoice : DataDynamics.ActiveReports.ActiveReport
    {



        public Invoice()
        {
            //
            // ActiveReport デザイナ サポートに必要です。
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {
            ////支部費
            //int BigSize     = int.Parse(this.txtNum_BigSize.Text);
            //int MediumSmall = int.Parse(this.txtNum_MediumSmall.Text);
            //int ShibuFee    = int.Parse(this.txtNum_ShibuFee.Text);
            ////台数*支部費(100円)
            //int TotalDaisuu = BigSize + MediumSmall;
            //this.txtNum_ShibuFee.Text = (TotalDaisuu * ShibuFee).ToString();

            string ShibuFeePrt = this.txtShibuFeePrt.Text;

            //支部費のみ印字
            if (ShibuFeePrt.Equals("1"))
            {
                //支部費のみ印字する

                //台数割会費　大型　　　金額
                this.txtSum_BigSize.Visible = false;
                //台数割会費　中・小型　金額
                this.txtSum_MediumSmall.Visible = false;
                //均等割会費　　　　　　金額
                this.txtU_Average.Visible = false;
                //支部費　　　　　　　　金額
                this.txtSumSibuMemberFee.Text  = this.txtNum_ShibuFee.Text;
                this.txtSumSibuMemberFeeHeader.Text = this.txtNum_ShibuFee.Text;


            }
            else 
            {
                //通常通り、台数均等割会費を表示と支部費を表示する

                //台数割会費　大型　　　金額
                this.txtSum_BigSize.Visible = true;
                //台数割会費　中・小型　金額
                this.txtSum_MediumSmall.Visible = true;
                //均等割会費　　　　　　金額
                this.txtU_Average.Visible = true;
            
            }


            //販売店協会会費は次月
            int MonthRep1 = int.Parse(this.txtMonthRep1.Text);
            if (MonthRep1 == 12)
            {
                MonthRep1 = 1;
            }
            else 
            {
                MonthRep1 = MonthRep1 + 1;
            }
            this.txtMonthRep1.Text = MonthRep1.ToString();

        }

        private void Invoice_ReportStart(object sender, EventArgs e)
        {

        }
    }
}
