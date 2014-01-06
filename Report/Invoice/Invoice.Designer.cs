namespace Jisseki_Report_Ibaraki.Report
{
    /// <summary>
    /// Invoice の概要の説明です。
    /// </summary>
    partial class Invoice
    {
        private DataDynamics.ActiveReports.Detail detail;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport デザイナで生成されたコード
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。
        /// このメソッドの内容をコード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Invoice));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.txtSum_LessThan29 = new DataDynamics.ActiveReports.TextBox();
            this.txtU_LessThan29 = new DataDynamics.ActiveReports.TextBox();
            this.label49 = new DataDynamics.ActiveReports.Label();
            this.label41 = new DataDynamics.ActiveReports.Label();
            this.txtNum_LessThan29 = new DataDynamics.ActiveReports.TextBox();
            this.label21 = new DataDynamics.ActiveReports.Label();
            this.txtSum_Over30 = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Over30 = new DataDynamics.ActiveReports.TextBox();
            this.label48 = new DataDynamics.ActiveReports.Label();
            this.label40 = new DataDynamics.ActiveReports.Label();
            this.txtNum_Over30 = new DataDynamics.ActiveReports.TextBox();
            this.label20 = new DataDynamics.ActiveReports.Label();
            this.txtSum_To2000From1000cc = new DataDynamics.ActiveReports.TextBox();
            this.txtU_To2000From1000cc = new DataDynamics.ActiveReports.TextBox();
            this.label47 = new DataDynamics.ActiveReports.Label();
            this.label39 = new DataDynamics.ActiveReports.Label();
            this.txtNum_To2000From1000cc = new DataDynamics.ActiveReports.TextBox();
            this.label19 = new DataDynamics.ActiveReports.Label();
            this.txtSum_Over2001cc = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Over2001cc = new DataDynamics.ActiveReports.TextBox();
            this.label46 = new DataDynamics.ActiveReports.Label();
            this.label38 = new DataDynamics.ActiveReports.Label();
            this.txtNum_Over2001cc = new DataDynamics.ActiveReports.TextBox();
            this.label18 = new DataDynamics.ActiveReports.Label();
            this.label45 = new DataDynamics.ActiveReports.Label();
            this.label37 = new DataDynamics.ActiveReports.Label();
            this.txtSum_Kamotu4DP9_3t = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Kamotu4DP9_3t = new DataDynamics.ActiveReports.TextBox();
            this.label44 = new DataDynamics.ActiveReports.Label();
            this.label36 = new DataDynamics.ActiveReports.Label();
            this.txtNum_Kamotu4DP9_3t = new DataDynamics.ActiveReports.TextBox();
            this.label16 = new DataDynamics.ActiveReports.Label();
            this.label43 = new DataDynamics.ActiveReports.Label();
            this.label35 = new DataDynamics.ActiveReports.Label();
            this.label42 = new DataDynamics.ActiveReports.Label();
            this.label34 = new DataDynamics.ActiveReports.Label();
            this.txtCONAME = new DataDynamics.ActiveReports.TextBox();
            this.txtNum_BigSize = new DataDynamics.ActiveReports.TextBox();
            this.txtU_BigSize = new DataDynamics.ActiveReports.TextBox();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.txtSum_BigSize = new DataDynamics.ActiveReports.TextBox();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.txtNum_MediumSmall = new DataDynamics.ActiveReports.TextBox();
            this.txtU_MediumSmall = new DataDynamics.ActiveReports.TextBox();
            this.txtSum_MediumSmall = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Average = new DataDynamics.ActiveReports.TextBox();
            this.txtSumSibuMemberFee = new DataDynamics.ActiveReports.TextBox();
            this.label14 = new DataDynamics.ActiveReports.Label();
            this.label15 = new DataDynamics.ActiveReports.Label();
            this.label17 = new DataDynamics.ActiveReports.Label();
            this.txtNum_Kamotu7t = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Kamotu7t = new DataDynamics.ActiveReports.TextBox();
            this.txtSum_Kamotu7t = new DataDynamics.ActiveReports.TextBox();
            this.txtNum_Kamotu6DP9_5t = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Kamotu6DP9_5t = new DataDynamics.ActiveReports.TextBox();
            this.txtSum_Kamotu6DP9_5t = new DataDynamics.ActiveReports.TextBox();
            this.txtNum_Kamotu2DP9_2DP5t = new DataDynamics.ActiveReports.TextBox();
            this.txtU_Kamotu2DP9_2DP5t = new DataDynamics.ActiveReports.TextBox();
            this.txtSum_Kamotu2DP9_2DP5t = new DataDynamics.ActiveReports.TextBox();
            this.txtSumSibuMemberFeeHeader = new DataDynamics.ActiveReports.TextBox();
            this.txtU_MemberFee = new DataDynamics.ActiveReports.TextBox();
            this.label22 = new DataDynamics.ActiveReports.Label();
            this.txtSumMemberFee = new DataDynamics.ActiveReports.TextBox();
            this.label23 = new DataDynamics.ActiveReports.Label();
            this.label24 = new DataDynamics.ActiveReports.Label();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.label25 = new DataDynamics.ActiveReports.Label();
            this.label26 = new DataDynamics.ActiveReports.Label();
            this.label27 = new DataDynamics.ActiveReports.Label();
            this.label28 = new DataDynamics.ActiveReports.Label();
            this.label29 = new DataDynamics.ActiveReports.Label();
            this.label30 = new DataDynamics.ActiveReports.Label();
            this.line4 = new DataDynamics.ActiveReports.Line();
            this.line5 = new DataDynamics.ActiveReports.Line();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.label11 = new DataDynamics.ActiveReports.Label();
            this.label12 = new DataDynamics.ActiveReports.Label();
            this.label13 = new DataDynamics.ActiveReports.Label();
            this.label31 = new DataDynamics.ActiveReports.Label();
            this.label32 = new DataDynamics.ActiveReports.Label();
            this.label33 = new DataDynamics.ActiveReports.Label();
            this.line6 = new DataDynamics.ActiveReports.Line();
            this.line7 = new DataDynamics.ActiveReports.Line();
            this.line8 = new DataDynamics.ActiveReports.Line();
            this.line9 = new DataDynamics.ActiveReports.Line();
            this.line10 = new DataDynamics.ActiveReports.Line();
            this.line11 = new DataDynamics.ActiveReports.Line();
            this.line12 = new DataDynamics.ActiveReports.Line();
            this.line13 = new DataDynamics.ActiveReports.Line();
            this.line14 = new DataDynamics.ActiveReports.Line();
            this.line15 = new DataDynamics.ActiveReports.Line();
            this.line16 = new DataDynamics.ActiveReports.Line();
            this.line17 = new DataDynamics.ActiveReports.Line();
            this.line20 = new DataDynamics.ActiveReports.Line();
            this.line21 = new DataDynamics.ActiveReports.Line();
            this.line22 = new DataDynamics.ActiveReports.Line();
            this.line23 = new DataDynamics.ActiveReports.Line();
            this.line24 = new DataDynamics.ActiveReports.Line();
            this.line25 = new DataDynamics.ActiveReports.Line();
            this.line26 = new DataDynamics.ActiveReports.Line();
            this.line27 = new DataDynamics.ActiveReports.Line();
            this.line28 = new DataDynamics.ActiveReports.Line();
            this.line29 = new DataDynamics.ActiveReports.Line();
            this.line30 = new DataDynamics.ActiveReports.Line();
            this.line31 = new DataDynamics.ActiveReports.Line();
            this.line33 = new DataDynamics.ActiveReports.Line();
            this.line34 = new DataDynamics.ActiveReports.Line();
            this.line35 = new DataDynamics.ActiveReports.Line();
            this.line36 = new DataDynamics.ActiveReports.Line();
            this.label50 = new DataDynamics.ActiveReports.Label();
            this.txtMonthRep0 = new DataDynamics.ActiveReports.TextBox();
            this.line3 = new DataDynamics.ActiveReports.Line();
            this.txtMonthRep1 = new DataDynamics.ActiveReports.TextBox();
            this.line19 = new DataDynamics.ActiveReports.Line();
            this.line18 = new DataDynamics.ActiveReports.Line();
            this.line32 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_LessThan29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_LessThan29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_LessThan29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Over30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Over30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Over30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_To2000From1000cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_To2000From1000cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_To2000From1000cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Over2001cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Over2001cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Over2001cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu4DP9_3t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu4DP9_3t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu4DP9_3t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_BigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_BigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_BigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_MediumSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_MediumSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_MediumSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumSibuMemberFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu7t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu7t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu7t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu6DP9_5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu6DP9_5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu6DP9_5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu2DP9_2DP5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu2DP9_2DP5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu2DP9_2DP5t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumSibuMemberFeeHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_MemberFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumMemberFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthRep0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthRep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.CanGrow = false;
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox1,
            this.txtSum_LessThan29,
            this.txtU_LessThan29,
            this.label49,
            this.label41,
            this.txtNum_LessThan29,
            this.label21,
            this.txtSum_Over30,
            this.txtU_Over30,
            this.label48,
            this.label40,
            this.txtNum_Over30,
            this.label20,
            this.txtSum_To2000From1000cc,
            this.txtU_To2000From1000cc,
            this.label47,
            this.label39,
            this.txtNum_To2000From1000cc,
            this.label19,
            this.txtSum_Over2001cc,
            this.txtU_Over2001cc,
            this.label46,
            this.label38,
            this.txtNum_Over2001cc,
            this.label18,
            this.label45,
            this.label37,
            this.txtSum_Kamotu4DP9_3t,
            this.txtU_Kamotu4DP9_3t,
            this.label44,
            this.label36,
            this.txtNum_Kamotu4DP9_3t,
            this.label16,
            this.label43,
            this.label35,
            this.label42,
            this.label34,
            this.txtCONAME,
            this.txtNum_BigSize,
            this.txtU_BigSize,
            this.label1,
            this.label2,
            this.label3,
            this.txtSum_BigSize,
            this.label4,
            this.label5,
            this.label6,
            this.label7,
            this.label8,
            this.label9,
            this.txtNum_MediumSmall,
            this.txtU_MediumSmall,
            this.txtSum_MediumSmall,
            this.txtU_Average,
            this.txtSumSibuMemberFee,
            this.label14,
            this.label15,
            this.label17,
            this.txtNum_Kamotu7t,
            this.txtU_Kamotu7t,
            this.txtSum_Kamotu7t,
            this.txtNum_Kamotu6DP9_5t,
            this.txtU_Kamotu6DP9_5t,
            this.txtSum_Kamotu6DP9_5t,
            this.txtNum_Kamotu2DP9_2DP5t,
            this.txtU_Kamotu2DP9_2DP5t,
            this.txtSum_Kamotu2DP9_2DP5t,
            this.txtSumSibuMemberFeeHeader,
            this.txtU_MemberFee,
            this.label22,
            this.txtSumMemberFee,
            this.label23,
            this.label24,
            this.line1,
            this.line2,
            this.label25,
            this.label26,
            this.label27,
            this.label28,
            this.label29,
            this.label30,
            this.line4,
            this.line5,
            this.label10,
            this.label11,
            this.label12,
            this.label13,
            this.label31,
            this.label32,
            this.label33,
            this.line6,
            this.line7,
            this.line8,
            this.line9,
            this.line10,
            this.line11,
            this.line12,
            this.line13,
            this.line14,
            this.line15,
            this.line16,
            this.line17,
            this.line20,
            this.line21,
            this.line22,
            this.line23,
            this.line24,
            this.line25,
            this.line26,
            this.line27,
            this.line28,
            this.line29,
            this.line30,
            this.line31,
            this.line33,
            this.line34,
            this.line35,
            this.line36,
            this.label50,
            this.txtMonthRep0,
            this.line3,
            this.txtMonthRep1,
            this.line19,
            this.line18,
            this.line32});
            this.detail.Height = 9.176592F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // textBox1
            // 
            this.textBox1.DataField = "=Sum_Kamotu7t+Sum_Kamotu6DP9_5t+Sum_Kamotu4DP9_3t+Sum_Kamotu2DP9_2DP5t+Sum_Over20" +
    "01cc+Sum_To2000From1000cc+Sum_Over30+Sum_LessThan29+U_MemberFee";
            this.textBox1.Height = 0.307874F;
            this.textBox1.Left = 3.622047F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "font-family: ＭＳ Ｐ明朝; font-size: 24pt; font-style: italic; text-align: center; ver" +
    "tical-align: middle";
            this.textBox1.Text = "999";
            this.textBox1.Top = 4.645669F;
            this.textBox1.Width = 2.908137F;
            // 
            // txtSum_LessThan29
            // 
            this.txtSum_LessThan29.CanGrow = false;
            this.txtSum_LessThan29.DataField = "Sum_LessThan29";
            this.txtSum_LessThan29.Height = 0.28125F;
            this.txtSum_LessThan29.Left = 4.488189F;
            this.txtSum_LessThan29.Name = "txtSum_LessThan29";
            this.txtSum_LessThan29.OutputFormat = resources.GetString("txtSum_LessThan29.OutputFormat");
            this.txtSum_LessThan29.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_LessThan29.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_LessThan29.Text = "999";
            this.txtSum_LessThan29.Top = 7.637795F;
            this.txtSum_LessThan29.Width = 2.007874F;
            // 
            // txtU_LessThan29
            // 
            this.txtU_LessThan29.CanGrow = false;
            this.txtU_LessThan29.DataField = "U_LessThan29";
            this.txtU_LessThan29.Height = 0.28125F;
            this.txtU_LessThan29.Left = 4.015748F;
            this.txtU_LessThan29.Name = "txtU_LessThan29";
            this.txtU_LessThan29.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_LessThan29.Text = "999";
            this.txtU_LessThan29.Top = 7.637796F;
            this.txtU_LessThan29.Width = 0.472441F;
            // 
            // label49
            // 
            this.label49.Height = 0.2916667F;
            this.label49.HyperLink = null;
            this.label49.Left = 3.622048F;
            this.label49.Name = "label49";
            this.label49.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label49.Text = "＠";
            this.label49.Top = 7.637796F;
            this.label49.Width = 0.3543305F;
            // 
            // label41
            // 
            this.label41.Height = 0.2916667F;
            this.label41.HyperLink = null;
            this.label41.Left = 3.228346F;
            this.label41.Name = "label41";
            this.label41.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label41.Text = "台";
            this.label41.Top = 7.637795F;
            this.label41.Width = 0.3937009F;
            // 
            // txtNum_LessThan29
            // 
            this.txtNum_LessThan29.CanGrow = false;
            this.txtNum_LessThan29.DataField = "Num_LessThan29";
            this.txtNum_LessThan29.Height = 0.28125F;
            this.txtNum_LessThan29.Left = 2.675591F;
            this.txtNum_LessThan29.Name = "txtNum_LessThan29";
            this.txtNum_LessThan29.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_LessThan29.Text = "999";
            this.txtNum_LessThan29.Top = 7.637795F;
            this.txtNum_LessThan29.Width = 0.5905512F;
            // 
            // label21
            // 
            this.label21.Height = 0.3149606F;
            this.label21.HyperLink = null;
            this.label21.Left = 0.2362204F;
            this.label21.Name = "label21";
            this.label21.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label21.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label21.Text = "乗合定員２９人以下";
            this.label21.Top = 7.637795F;
            this.label21.Width = 2.362205F;
            // 
            // txtSum_Over30
            // 
            this.txtSum_Over30.CanGrow = false;
            this.txtSum_Over30.DataField = "Sum_Over30";
            this.txtSum_Over30.Height = 0.28125F;
            this.txtSum_Over30.Left = 4.488189F;
            this.txtSum_Over30.Name = "txtSum_Over30";
            this.txtSum_Over30.OutputFormat = resources.GetString("txtSum_Over30.OutputFormat");
            this.txtSum_Over30.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Over30.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Over30.Text = "999";
            this.txtSum_Over30.Top = 7.322835F;
            this.txtSum_Over30.Width = 2.007874F;
            // 
            // txtU_Over30
            // 
            this.txtU_Over30.CanGrow = false;
            this.txtU_Over30.DataField = "U_Over30";
            this.txtU_Over30.Height = 0.28125F;
            this.txtU_Over30.Left = 4.015748F;
            this.txtU_Over30.Name = "txtU_Over30";
            this.txtU_Over30.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Over30.Text = "999";
            this.txtU_Over30.Top = 7.322835F;
            this.txtU_Over30.Width = 0.472441F;
            // 
            // label48
            // 
            this.label48.Height = 0.2916667F;
            this.label48.HyperLink = null;
            this.label48.Left = 3.622048F;
            this.label48.Name = "label48";
            this.label48.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label48.Text = "＠";
            this.label48.Top = 7.322835F;
            this.label48.Width = 0.3543305F;
            // 
            // label40
            // 
            this.label40.Height = 0.2916667F;
            this.label40.HyperLink = null;
            this.label40.Left = 3.228346F;
            this.label40.Name = "label40";
            this.label40.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label40.Text = "台";
            this.label40.Top = 7.322835F;
            this.label40.Width = 0.3937009F;
            // 
            // txtNum_Over30
            // 
            this.txtNum_Over30.CanGrow = false;
            this.txtNum_Over30.DataField = "Num_Over30";
            this.txtNum_Over30.Height = 0.28125F;
            this.txtNum_Over30.Left = 2.675591F;
            this.txtNum_Over30.Name = "txtNum_Over30";
            this.txtNum_Over30.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Over30.Text = "999";
            this.txtNum_Over30.Top = 7.322835F;
            this.txtNum_Over30.Width = 0.5905512F;
            // 
            // label20
            // 
            this.label20.Height = 0.3149606F;
            this.label20.HyperLink = null;
            this.label20.Left = 0.2362204F;
            this.label20.Name = "label20";
            this.label20.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label20.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label20.Text = "乗合定員３０人以上";
            this.label20.Top = 7.322835F;
            this.label20.Width = 2.362205F;
            // 
            // txtSum_To2000From1000cc
            // 
            this.txtSum_To2000From1000cc.CanGrow = false;
            this.txtSum_To2000From1000cc.DataField = "Sum_To2000From1000cc";
            this.txtSum_To2000From1000cc.Height = 0.28125F;
            this.txtSum_To2000From1000cc.Left = 4.488189F;
            this.txtSum_To2000From1000cc.Name = "txtSum_To2000From1000cc";
            this.txtSum_To2000From1000cc.OutputFormat = resources.GetString("txtSum_To2000From1000cc.OutputFormat");
            this.txtSum_To2000From1000cc.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_To2000From1000cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_To2000From1000cc.Text = "999";
            this.txtSum_To2000From1000cc.Top = 7.007874F;
            this.txtSum_To2000From1000cc.Width = 2.007874F;
            // 
            // txtU_To2000From1000cc
            // 
            this.txtU_To2000From1000cc.CanGrow = false;
            this.txtU_To2000From1000cc.DataField = "U_To2000From1000cc";
            this.txtU_To2000From1000cc.Height = 0.28125F;
            this.txtU_To2000From1000cc.Left = 4.015748F;
            this.txtU_To2000From1000cc.Name = "txtU_To2000From1000cc";
            this.txtU_To2000From1000cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_To2000From1000cc.Text = "999";
            this.txtU_To2000From1000cc.Top = 7.007875F;
            this.txtU_To2000From1000cc.Width = 0.472441F;
            // 
            // label47
            // 
            this.label47.Height = 0.2916667F;
            this.label47.HyperLink = null;
            this.label47.Left = 3.622048F;
            this.label47.Name = "label47";
            this.label47.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label47.Text = "＠";
            this.label47.Top = 7.007875F;
            this.label47.Width = 0.3543305F;
            // 
            // label39
            // 
            this.label39.Height = 0.2916667F;
            this.label39.HyperLink = null;
            this.label39.Left = 3.228346F;
            this.label39.Name = "label39";
            this.label39.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label39.Text = "台";
            this.label39.Top = 7.007874F;
            this.label39.Width = 0.3937009F;
            // 
            // txtNum_To2000From1000cc
            // 
            this.txtNum_To2000From1000cc.CanGrow = false;
            this.txtNum_To2000From1000cc.DataField = "Num_To2000From1000cc";
            this.txtNum_To2000From1000cc.Height = 0.28125F;
            this.txtNum_To2000From1000cc.Left = 2.675591F;
            this.txtNum_To2000From1000cc.Name = "txtNum_To2000From1000cc";
            this.txtNum_To2000From1000cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_To2000From1000cc.Text = "999";
            this.txtNum_To2000From1000cc.Top = 7.007874F;
            this.txtNum_To2000From1000cc.Width = 0.5905512F;
            // 
            // label19
            // 
            this.label19.Height = 0.3149606F;
            this.label19.HyperLink = null;
            this.label19.Left = 0.2362204F;
            this.label19.Name = "label19";
            this.label19.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label19.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label19.Text = "２，０００cc～１，０００cc";
            this.label19.Top = 7.007874F;
            this.label19.Width = 2.362205F;
            // 
            // txtSum_Over2001cc
            // 
            this.txtSum_Over2001cc.CanGrow = false;
            this.txtSum_Over2001cc.DataField = "Sum_Over2001cc";
            this.txtSum_Over2001cc.Height = 0.28125F;
            this.txtSum_Over2001cc.Left = 4.488189F;
            this.txtSum_Over2001cc.Name = "txtSum_Over2001cc";
            this.txtSum_Over2001cc.OutputFormat = resources.GetString("txtSum_Over2001cc.OutputFormat");
            this.txtSum_Over2001cc.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Over2001cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Over2001cc.Text = "999";
            this.txtSum_Over2001cc.Top = 6.692914F;
            this.txtSum_Over2001cc.Width = 2.007874F;
            // 
            // txtU_Over2001cc
            // 
            this.txtU_Over2001cc.CanGrow = false;
            this.txtU_Over2001cc.DataField = "U_Over2001cc";
            this.txtU_Over2001cc.Height = 0.28125F;
            this.txtU_Over2001cc.Left = 4.015748F;
            this.txtU_Over2001cc.Name = "txtU_Over2001cc";
            this.txtU_Over2001cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Over2001cc.Text = "999";
            this.txtU_Over2001cc.Top = 6.692914F;
            this.txtU_Over2001cc.Width = 0.472441F;
            // 
            // label46
            // 
            this.label46.Height = 0.2916667F;
            this.label46.HyperLink = null;
            this.label46.Left = 3.622048F;
            this.label46.Name = "label46";
            this.label46.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label46.Text = "＠";
            this.label46.Top = 6.692914F;
            this.label46.Width = 0.3543305F;
            // 
            // label38
            // 
            this.label38.Height = 0.2916667F;
            this.label38.HyperLink = null;
            this.label38.Left = 3.228346F;
            this.label38.Name = "label38";
            this.label38.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label38.Text = "台";
            this.label38.Top = 6.692914F;
            this.label38.Width = 0.3937009F;
            // 
            // txtNum_Over2001cc
            // 
            this.txtNum_Over2001cc.CanGrow = false;
            this.txtNum_Over2001cc.DataField = "Num_Over2001cc";
            this.txtNum_Over2001cc.Height = 0.28125F;
            this.txtNum_Over2001cc.Left = 2.675591F;
            this.txtNum_Over2001cc.Name = "txtNum_Over2001cc";
            this.txtNum_Over2001cc.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Over2001cc.Text = "999";
            this.txtNum_Over2001cc.Top = 6.692914F;
            this.txtNum_Over2001cc.Width = 0.5905512F;
            // 
            // label18
            // 
            this.label18.Height = 0.3149606F;
            this.label18.HyperLink = null;
            this.label18.Left = 0.2362204F;
            this.label18.Name = "label18";
            this.label18.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label18.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label18.Text = "２,００１cc以上";
            this.label18.Top = 6.692914F;
            this.label18.Width = 2.362205F;
            // 
            // label45
            // 
            this.label45.Height = 0.2916667F;
            this.label45.HyperLink = null;
            this.label45.Left = 3.622048F;
            this.label45.Name = "label45";
            this.label45.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label45.Text = "＠";
            this.label45.Top = 6.377954F;
            this.label45.Width = 0.3543305F;
            // 
            // label37
            // 
            this.label37.Height = 0.2916667F;
            this.label37.HyperLink = null;
            this.label37.Left = 3.228346F;
            this.label37.Name = "label37";
            this.label37.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label37.Text = "台";
            this.label37.Top = 6.377953F;
            this.label37.Width = 0.3937009F;
            // 
            // txtSum_Kamotu4DP9_3t
            // 
            this.txtSum_Kamotu4DP9_3t.CanGrow = false;
            this.txtSum_Kamotu4DP9_3t.DataField = "Sum_Kamotu4DP9_3t";
            this.txtSum_Kamotu4DP9_3t.Height = 0.28125F;
            this.txtSum_Kamotu4DP9_3t.Left = 4.488189F;
            this.txtSum_Kamotu4DP9_3t.Name = "txtSum_Kamotu4DP9_3t";
            this.txtSum_Kamotu4DP9_3t.OutputFormat = resources.GetString("txtSum_Kamotu4DP9_3t.OutputFormat");
            this.txtSum_Kamotu4DP9_3t.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Kamotu4DP9_3t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Kamotu4DP9_3t.Text = "999";
            this.txtSum_Kamotu4DP9_3t.Top = 6.062993F;
            this.txtSum_Kamotu4DP9_3t.Width = 2.007874F;
            // 
            // txtU_Kamotu4DP9_3t
            // 
            this.txtU_Kamotu4DP9_3t.CanGrow = false;
            this.txtU_Kamotu4DP9_3t.DataField = "U_Kamotu4DP9_3t";
            this.txtU_Kamotu4DP9_3t.Height = 0.28125F;
            this.txtU_Kamotu4DP9_3t.Left = 4.015748F;
            this.txtU_Kamotu4DP9_3t.Name = "txtU_Kamotu4DP9_3t";
            this.txtU_Kamotu4DP9_3t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Kamotu4DP9_3t.Text = "999";
            this.txtU_Kamotu4DP9_3t.Top = 6.062993F;
            this.txtU_Kamotu4DP9_3t.Width = 0.472441F;
            // 
            // label44
            // 
            this.label44.Height = 0.2916667F;
            this.label44.HyperLink = null;
            this.label44.Left = 3.622048F;
            this.label44.Name = "label44";
            this.label44.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label44.Text = "＠";
            this.label44.Top = 6.062993F;
            this.label44.Width = 0.3543305F;
            // 
            // label36
            // 
            this.label36.Height = 0.2916667F;
            this.label36.HyperLink = null;
            this.label36.Left = 3.228346F;
            this.label36.Name = "label36";
            this.label36.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label36.Text = "台";
            this.label36.Top = 6.062993F;
            this.label36.Width = 0.3937009F;
            // 
            // txtNum_Kamotu4DP9_3t
            // 
            this.txtNum_Kamotu4DP9_3t.CanGrow = false;
            this.txtNum_Kamotu4DP9_3t.DataField = "Num_Kamotu4DP9_3t";
            this.txtNum_Kamotu4DP9_3t.Height = 0.28125F;
            this.txtNum_Kamotu4DP9_3t.Left = 2.677166F;
            this.txtNum_Kamotu4DP9_3t.Name = "txtNum_Kamotu4DP9_3t";
            this.txtNum_Kamotu4DP9_3t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Kamotu4DP9_3t.Text = "999";
            this.txtNum_Kamotu4DP9_3t.Top = 6.062993F;
            this.txtNum_Kamotu4DP9_3t.Width = 0.5905512F;
            // 
            // label16
            // 
            this.label16.Height = 0.3149606F;
            this.label16.HyperLink = null;
            this.label16.Left = 0.2362204F;
            this.label16.Name = "label16";
            this.label16.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label16.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: left; vertical-align: middle";
            this.label16.Text = "４．９t～３t";
            this.label16.Top = 6.062993F;
            this.label16.Width = 2.362205F;
            // 
            // label43
            // 
            this.label43.Height = 0.2916667F;
            this.label43.HyperLink = null;
            this.label43.Left = 3.622048F;
            this.label43.Name = "label43";
            this.label43.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label43.Text = "＠";
            this.label43.Top = 5.748032F;
            this.label43.Width = 0.3543305F;
            // 
            // label35
            // 
            this.label35.Height = 0.2916667F;
            this.label35.HyperLink = null;
            this.label35.Left = 3.228346F;
            this.label35.Name = "label35";
            this.label35.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label35.Text = "台";
            this.label35.Top = 5.748032F;
            this.label35.Width = 0.3937009F;
            // 
            // label42
            // 
            this.label42.Height = 0.2916667F;
            this.label42.HyperLink = null;
            this.label42.Left = 3.622047F;
            this.label42.Name = "label42";
            this.label42.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label42.Text = "＠";
            this.label42.Top = 5.433071F;
            this.label42.Width = 0.3543305F;
            // 
            // label34
            // 
            this.label34.Height = 0.2916667F;
            this.label34.HyperLink = null;
            this.label34.Left = 3.228346F;
            this.label34.Name = "label34";
            this.label34.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label34.Text = "台";
            this.label34.Top = 5.433071F;
            this.label34.Width = 0.3937009F;
            // 
            // txtCONAME
            // 
            this.txtCONAME.CanGrow = false;
            this.txtCONAME.DataField = "CONAME";
            this.txtCONAME.Height = 0.3149606F;
            this.txtCONAME.Left = 0.3149606F;
            this.txtCONAME.Name = "txtCONAME";
            this.txtCONAME.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; text-align: left; vertical-align: middle";
            this.txtCONAME.Text = "三菱ふそうトラック・バス株式会社北関東ふそう";
            this.txtCONAME.Top = 0F;
            this.txtCONAME.Width = 3.937008F;
            // 
            // txtNum_BigSize
            // 
            this.txtNum_BigSize.CanGrow = false;
            this.txtNum_BigSize.DataField = "Num_BigSize";
            this.txtNum_BigSize.Height = 0.3149607F;
            this.txtNum_BigSize.Left = 2.677166F;
            this.txtNum_BigSize.Name = "txtNum_BigSize";
            this.txtNum_BigSize.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.txtNum_BigSize.Text = "999";
            this.txtNum_BigSize.Top = 1.574803F;
            this.txtNum_BigSize.Width = 0.5905512F;
            // 
            // txtU_BigSize
            // 
            this.txtU_BigSize.CanGrow = false;
            this.txtU_BigSize.DataField = "U_BigSize";
            this.txtU_BigSize.Height = 0.3149606F;
            this.txtU_BigSize.Left = 4.015747F;
            this.txtU_BigSize.Name = "txtU_BigSize";
            this.txtU_BigSize.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_BigSize.Text = "999";
            this.txtU_BigSize.Top = 1.574803F;
            this.txtU_BigSize.Width = 0.472442F;
            // 
            // label1
            // 
            this.label1.Height = 0.3149607F;
            this.label1.HyperLink = null;
            this.label1.Left = 2.755906F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label1.Text = "台数";
            this.label1.Top = 1.259843F;
            this.label1.Width = 0.7874016F;
            // 
            // label2
            // 
            this.label2.Height = 0.3149607F;
            this.label2.HyperLink = null;
            this.label2.Left = 3.700787F;
            this.label2.Name = "label2";
            this.label2.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label2.Text = "単価";
            this.label2.Top = 1.259843F;
            this.label2.Width = 0.7874016F;
            // 
            // label3
            // 
            this.label3.Height = 0.3149607F;
            this.label3.HyperLink = null;
            this.label3.Left = 4.488189F;
            this.label3.Name = "label3";
            this.label3.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label3.Text = "金額";
            this.label3.Top = 1.259843F;
            this.label3.Width = 2.007874F;
            // 
            // txtSum_BigSize
            // 
            this.txtSum_BigSize.CanGrow = false;
            this.txtSum_BigSize.DataField = "Sum_BigSize";
            this.txtSum_BigSize.Height = 0.3149606F;
            this.txtSum_BigSize.Left = 4.488189F;
            this.txtSum_BigSize.Name = "txtSum_BigSize";
            this.txtSum_BigSize.OutputFormat = resources.GetString("txtSum_BigSize.OutputFormat");
            this.txtSum_BigSize.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_BigSize.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; text" +
    "-justify: auto; vertical-align: middle";
            this.txtSum_BigSize.Text = "999";
            this.txtSum_BigSize.Top = 1.574803F;
            this.txtSum_BigSize.Width = 2.007874F;
            // 
            // label4
            // 
            this.label4.Height = 0.3182746F;
            this.label4.HyperLink = null;
            this.label4.Left = 0.3149606F;
            this.label4.Name = "label4";
            this.label4.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label4.Text = "摘要";
            this.label4.Top = 1.259843F;
            this.label4.Width = 2.283465F;
            // 
            // label5
            // 
            this.label5.Height = 0.3149606F;
            this.label5.HyperLink = null;
            this.label5.Left = 0.3149606F;
            this.label5.Name = "label5";
            this.label5.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label5.Style = "color: Black; font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical" +
    "-align: middle";
            this.label5.Text = "台数割会費　大型";
            this.label5.Top = 1.574803F;
            this.label5.Width = 2.283465F;
            // 
            // label6
            // 
            this.label6.Height = 0.3149606F;
            this.label6.HyperLink = null;
            this.label6.Left = 0.3149606F;
            this.label6.Name = "label6";
            this.label6.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label6.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label6.Text = "台数割会費　中・小型";
            this.label6.Top = 1.889764F;
            this.label6.Width = 2.283465F;
            // 
            // label7
            // 
            this.label7.Height = 0.3149606F;
            this.label7.HyperLink = null;
            this.label7.Left = 0.3149606F;
            this.label7.Name = "label7";
            this.label7.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label7.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: left; vertical-align: middle";
            this.label7.Text = "均等割会費";
            this.label7.Top = 2.204725F;
            this.label7.Width = 2.283465F;
            // 
            // label8
            // 
            this.label8.Height = 0.3149606F;
            this.label8.HyperLink = null;
            this.label8.Left = 0.3149607F;
            this.label8.Name = "label8";
            this.label8.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 20, 0);
            this.label8.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: right; vertical-align: middle";
            this.label8.Text = "請求金額合計";
            this.label8.Top = 2.567717F;
            this.label8.Width = 4.173228F;
            // 
            // label9
            // 
            this.label9.Height = 0.3149607F;
            this.label9.HyperLink = null;
            this.label9.Left = 2.362205F;
            this.label9.Name = "label9";
            this.label9.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; vertical-align: middle";
            this.label9.Text = "月分会費";
            this.label9.Top = 0.7874016F;
            this.label9.Width = 0.9479167F;
            // 
            // txtNum_MediumSmall
            // 
            this.txtNum_MediumSmall.CanGrow = false;
            this.txtNum_MediumSmall.DataField = "Num_MediumSmall";
            this.txtNum_MediumSmall.Height = 0.3149606F;
            this.txtNum_MediumSmall.Left = 2.677166F;
            this.txtNum_MediumSmall.Name = "txtNum_MediumSmall";
            this.txtNum_MediumSmall.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_MediumSmall.Text = "999";
            this.txtNum_MediumSmall.Top = 1.889764F;
            this.txtNum_MediumSmall.Width = 0.5905512F;
            // 
            // txtU_MediumSmall
            // 
            this.txtU_MediumSmall.CanGrow = false;
            this.txtU_MediumSmall.DataField = "U_MediumSmall";
            this.txtU_MediumSmall.Height = 0.3149606F;
            this.txtU_MediumSmall.Left = 4.015747F;
            this.txtU_MediumSmall.Name = "txtU_MediumSmall";
            this.txtU_MediumSmall.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_MediumSmall.Text = "999";
            this.txtU_MediumSmall.Top = 1.889764F;
            this.txtU_MediumSmall.Width = 0.472442F;
            // 
            // txtSum_MediumSmall
            // 
            this.txtSum_MediumSmall.CanGrow = false;
            this.txtSum_MediumSmall.DataField = "Sum_MediumSmall";
            this.txtSum_MediumSmall.Height = 0.3149606F;
            this.txtSum_MediumSmall.Left = 4.488189F;
            this.txtSum_MediumSmall.Name = "txtSum_MediumSmall";
            this.txtSum_MediumSmall.OutputFormat = resources.GetString("txtSum_MediumSmall.OutputFormat");
            this.txtSum_MediumSmall.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_MediumSmall.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_MediumSmall.Text = "999";
            this.txtSum_MediumSmall.Top = 1.889764F;
            this.txtSum_MediumSmall.Width = 2.007874F;
            // 
            // txtU_Average
            // 
            this.txtU_Average.CanGrow = false;
            this.txtU_Average.DataField = "U_Average";
            this.txtU_Average.Height = 0.3149606F;
            this.txtU_Average.Left = 4.488189F;
            this.txtU_Average.Name = "txtU_Average";
            this.txtU_Average.OutputFormat = resources.GetString("txtU_Average.OutputFormat");
            this.txtU_Average.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtU_Average.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtU_Average.Text = "999";
            this.txtU_Average.Top = 2.204725F;
            this.txtU_Average.Width = 2.007874F;
            // 
            // txtSumSibuMemberFee
            // 
            this.txtSumSibuMemberFee.CanGrow = false;
            this.txtSumSibuMemberFee.DataField = "=Sum_BigSize+Sum_MediumSmall+U_Average+";
            this.txtSumSibuMemberFee.Height = 0.3149606F;
            this.txtSumSibuMemberFee.Left = 4.488189F;
            this.txtSumSibuMemberFee.Name = "txtSumSibuMemberFee";
            this.txtSumSibuMemberFee.OutputFormat = resources.GetString("txtSumSibuMemberFee.OutputFormat");
            this.txtSumSibuMemberFee.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSumSibuMemberFee.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSumSibuMemberFee.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.txtSumSibuMemberFee.Text = "999";
            this.txtSumSibuMemberFee.Top = 2.567717F;
            this.txtSumSibuMemberFee.Width = 2.007874F;
            // 
            // label14
            // 
            this.label14.Height = 0.3149606F;
            this.label14.HyperLink = null;
            this.label14.Left = 0.2362204F;
            this.label14.Name = "label14";
            this.label14.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label14.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: left; vertical-align: middle";
            this.label14.Text = "７t以上";
            this.label14.Top = 5.433071F;
            this.label14.Width = 2.362205F;
            // 
            // label15
            // 
            this.label15.Height = 0.3149606F;
            this.label15.HyperLink = null;
            this.label15.Left = 0.2362204F;
            this.label15.Name = "label15";
            this.label15.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label15.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: left; vertical-align: middle";
            this.label15.Text = "６．９t～５t";
            this.label15.Top = 5.748032F;
            this.label15.Width = 2.362205F;
            // 
            // label17
            // 
            this.label17.Height = 0.3149606F;
            this.label17.HyperLink = null;
            this.label17.Left = 0.2362204F;
            this.label17.Name = "label17";
            this.label17.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label17.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label17.Text = "２．９t～２．５t";
            this.label17.Top = 6.377953F;
            this.label17.Width = 2.362205F;
            // 
            // txtNum_Kamotu7t
            // 
            this.txtNum_Kamotu7t.CanGrow = false;
            this.txtNum_Kamotu7t.DataField = "Num_Kamotu7t";
            this.txtNum_Kamotu7t.Height = 0.28125F;
            this.txtNum_Kamotu7t.Left = 2.677166F;
            this.txtNum_Kamotu7t.Name = "txtNum_Kamotu7t";
            this.txtNum_Kamotu7t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Kamotu7t.Text = "999";
            this.txtNum_Kamotu7t.Top = 5.433071F;
            this.txtNum_Kamotu7t.Width = 0.5905512F;
            // 
            // txtU_Kamotu7t
            // 
            this.txtU_Kamotu7t.CanGrow = false;
            this.txtU_Kamotu7t.DataField = "U_Kamotu7t";
            this.txtU_Kamotu7t.Height = 0.28125F;
            this.txtU_Kamotu7t.Left = 4.015747F;
            this.txtU_Kamotu7t.Name = "txtU_Kamotu7t";
            this.txtU_Kamotu7t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Kamotu7t.Text = "999";
            this.txtU_Kamotu7t.Top = 5.433071F;
            this.txtU_Kamotu7t.Width = 0.472441F;
            // 
            // txtSum_Kamotu7t
            // 
            this.txtSum_Kamotu7t.CanGrow = false;
            this.txtSum_Kamotu7t.DataField = "Sum_Kamotu7t";
            this.txtSum_Kamotu7t.Height = 0.28125F;
            this.txtSum_Kamotu7t.Left = 4.488189F;
            this.txtSum_Kamotu7t.Name = "txtSum_Kamotu7t";
            this.txtSum_Kamotu7t.OutputFormat = resources.GetString("txtSum_Kamotu7t.OutputFormat");
            this.txtSum_Kamotu7t.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Kamotu7t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Kamotu7t.Text = "999";
            this.txtSum_Kamotu7t.Top = 5.433071F;
            this.txtSum_Kamotu7t.Width = 2.007874F;
            // 
            // txtNum_Kamotu6DP9_5t
            // 
            this.txtNum_Kamotu6DP9_5t.CanGrow = false;
            this.txtNum_Kamotu6DP9_5t.DataField = "Num_Kamotu6DP9_5t";
            this.txtNum_Kamotu6DP9_5t.Height = 0.28125F;
            this.txtNum_Kamotu6DP9_5t.Left = 2.677166F;
            this.txtNum_Kamotu6DP9_5t.Name = "txtNum_Kamotu6DP9_5t";
            this.txtNum_Kamotu6DP9_5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Kamotu6DP9_5t.Text = "999";
            this.txtNum_Kamotu6DP9_5t.Top = 5.748032F;
            this.txtNum_Kamotu6DP9_5t.Width = 0.5905512F;
            // 
            // txtU_Kamotu6DP9_5t
            // 
            this.txtU_Kamotu6DP9_5t.CanGrow = false;
            this.txtU_Kamotu6DP9_5t.DataField = "U_Kamotu6DP9_5t";
            this.txtU_Kamotu6DP9_5t.Height = 0.28125F;
            this.txtU_Kamotu6DP9_5t.Left = 4.015748F;
            this.txtU_Kamotu6DP9_5t.Name = "txtU_Kamotu6DP9_5t";
            this.txtU_Kamotu6DP9_5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Kamotu6DP9_5t.Text = "999";
            this.txtU_Kamotu6DP9_5t.Top = 5.748032F;
            this.txtU_Kamotu6DP9_5t.Width = 0.472441F;
            // 
            // txtSum_Kamotu6DP9_5t
            // 
            this.txtSum_Kamotu6DP9_5t.CanGrow = false;
            this.txtSum_Kamotu6DP9_5t.DataField = "Sum_Kamotu6DP9_5t";
            this.txtSum_Kamotu6DP9_5t.Height = 0.28125F;
            this.txtSum_Kamotu6DP9_5t.Left = 4.488189F;
            this.txtSum_Kamotu6DP9_5t.Name = "txtSum_Kamotu6DP9_5t";
            this.txtSum_Kamotu6DP9_5t.OutputFormat = resources.GetString("txtSum_Kamotu6DP9_5t.OutputFormat");
            this.txtSum_Kamotu6DP9_5t.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Kamotu6DP9_5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Kamotu6DP9_5t.Text = "999";
            this.txtSum_Kamotu6DP9_5t.Top = 5.748032F;
            this.txtSum_Kamotu6DP9_5t.Width = 2.007874F;
            // 
            // txtNum_Kamotu2DP9_2DP5t
            // 
            this.txtNum_Kamotu2DP9_2DP5t.CanGrow = false;
            this.txtNum_Kamotu2DP9_2DP5t.DataField = "Num_Kamotu2DP9_2DP5t";
            this.txtNum_Kamotu2DP9_2DP5t.Height = 0.28125F;
            this.txtNum_Kamotu2DP9_2DP5t.Left = 2.675591F;
            this.txtNum_Kamotu2DP9_2DP5t.Name = "txtNum_Kamotu2DP9_2DP5t";
            this.txtNum_Kamotu2DP9_2DP5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtNum_Kamotu2DP9_2DP5t.Text = "999";
            this.txtNum_Kamotu2DP9_2DP5t.Top = 6.377953F;
            this.txtNum_Kamotu2DP9_2DP5t.Width = 0.5905512F;
            // 
            // txtU_Kamotu2DP9_2DP5t
            // 
            this.txtU_Kamotu2DP9_2DP5t.CanGrow = false;
            this.txtU_Kamotu2DP9_2DP5t.DataField = "U_Kamotu2DP9_2DP5t";
            this.txtU_Kamotu2DP9_2DP5t.Height = 0.28125F;
            this.txtU_Kamotu2DP9_2DP5t.Left = 4.015748F;
            this.txtU_Kamotu2DP9_2DP5t.Name = "txtU_Kamotu2DP9_2DP5t";
            this.txtU_Kamotu2DP9_2DP5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.txtU_Kamotu2DP9_2DP5t.Text = "999";
            this.txtU_Kamotu2DP9_2DP5t.Top = 6.377954F;
            this.txtU_Kamotu2DP9_2DP5t.Width = 0.472441F;
            // 
            // txtSum_Kamotu2DP9_2DP5t
            // 
            this.txtSum_Kamotu2DP9_2DP5t.CanGrow = false;
            this.txtSum_Kamotu2DP9_2DP5t.DataField = "Sum_Kamotu2DP9_2DP5t";
            this.txtSum_Kamotu2DP9_2DP5t.Height = 0.28125F;
            this.txtSum_Kamotu2DP9_2DP5t.Left = 4.488189F;
            this.txtSum_Kamotu2DP9_2DP5t.Name = "txtSum_Kamotu2DP9_2DP5t";
            this.txtSum_Kamotu2DP9_2DP5t.OutputFormat = resources.GetString("txtSum_Kamotu2DP9_2DP5t.OutputFormat");
            this.txtSum_Kamotu2DP9_2DP5t.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSum_Kamotu2DP9_2DP5t.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSum_Kamotu2DP9_2DP5t.Text = "999";
            this.txtSum_Kamotu2DP9_2DP5t.Top = 6.377953F;
            this.txtSum_Kamotu2DP9_2DP5t.Width = 2.007874F;
            // 
            // txtSumSibuMemberFeeHeader
            // 
            this.txtSumSibuMemberFeeHeader.CanGrow = false;
            this.txtSumSibuMemberFeeHeader.DataField = "=Sum_BigSize+Sum_MediumSmall+U_Average+";
            this.txtSumSibuMemberFeeHeader.Height = 0.3229167F;
            this.txtSumSibuMemberFeeHeader.Left = 3.622047F;
            this.txtSumSibuMemberFeeHeader.Name = "txtSumSibuMemberFeeHeader";
            this.txtSumSibuMemberFeeHeader.OutputFormat = resources.GetString("txtSumSibuMemberFeeHeader.OutputFormat");
            this.txtSumSibuMemberFeeHeader.Style = "font-family: ＭＳ Ｐ明朝; font-size: 24pt; font-style: italic; text-align: center; ver" +
    "tical-align: middle";
            this.txtSumSibuMemberFeeHeader.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.txtSumSibuMemberFeeHeader.Text = "999";
            this.txtSumSibuMemberFeeHeader.Top = 0.7874016F;
            this.txtSumSibuMemberFeeHeader.Width = 2.85023F;
            // 
            // txtU_MemberFee
            // 
            this.txtU_MemberFee.CanGrow = false;
            this.txtU_MemberFee.DataField = "U_MemberFee";
            this.txtU_MemberFee.Height = 0.28125F;
            this.txtU_MemberFee.Left = 4.488189F;
            this.txtU_MemberFee.Name = "txtU_MemberFee";
            this.txtU_MemberFee.OutputFormat = resources.GetString("txtU_MemberFee.OutputFormat");
            this.txtU_MemberFee.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtU_MemberFee.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtU_MemberFee.Text = "999";
            this.txtU_MemberFee.Top = 7.952756F;
            this.txtU_MemberFee.Width = 2.007874F;
            // 
            // label22
            // 
            this.label22.Height = 0.3149606F;
            this.label22.HyperLink = null;
            this.label22.Left = 0.2362204F;
            this.label22.Name = "label22";
            this.label22.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label22.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: justify; vertical-align: middle" +
    "";
            this.label22.Text = "会費";
            this.label22.Top = 7.952756F;
            this.label22.Width = 4.055118F;
            // 
            // txtSumMemberFee
            // 
            this.txtSumMemberFee.CanGrow = false;
            this.txtSumMemberFee.DataField = "=Sum_Kamotu7t+Sum_Kamotu6DP9_5t+Sum_Kamotu4DP9_3t+Sum_Kamotu2DP9_2DP5t+Sum_Over20" +
    "01cc+Sum_To2000From1000cc+Sum_Over30+Sum_LessThan29+U_MemberFee";
            this.txtSumMemberFee.Height = 0.3149606F;
            this.txtSumMemberFee.Left = 4.488189F;
            this.txtSumMemberFee.Name = "txtSumMemberFee";
            this.txtSumMemberFee.OutputFormat = resources.GetString("txtSumMemberFee.OutputFormat");
            this.txtSumMemberFee.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 10, 0);
            this.txtSumMemberFee.Style = "font-family: ＭＳ Ｐ明朝; font-size: 18pt; font-style: italic; text-align: right; vert" +
    "ical-align: middle";
            this.txtSumMemberFee.Text = "999";
            this.txtSumMemberFee.Top = 8.315748F;
            this.txtSumMemberFee.Width = 2.007874F;
            // 
            // label23
            // 
            this.label23.Height = 0.3149606F;
            this.label23.HyperLink = null;
            this.label23.Left = 4.094488F;
            this.label23.Name = "label23";
            this.label23.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; text-align: center; vertical-align: middle";
            this.label23.Text = "御中";
            this.label23.Top = 0F;
            this.label23.Width = 0.84375F;
            // 
            // label24
            // 
            this.label24.Height = 0.3079069F;
            this.label24.HyperLink = null;
            this.label24.Left = 0.3149605F;
            this.label24.Name = "label24";
            this.label24.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; vertical-align: middle";
            this.label24.Text = "自販連茨城県支部";
            this.label24.Top = 0.7874016F;
            this.label24.Width = 1.889764F;
            // 
            // line1
            // 
            this.line1.Height = 0F;
            this.line1.Left = 0.2362204F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0.3149605F;
            this.line1.Width = 4.48819F;
            this.line1.X1 = 0.2362204F;
            this.line1.X2 = 4.72441F;
            this.line1.Y1 = 0.3149605F;
            this.line1.Y2 = 0.3149605F;
            // 
            // line2
            // 
            this.line2.Height = 0F;
            this.line2.Left = 0.2362205F;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 0.3456693F;
            this.line2.Width = 4.48819F;
            this.line2.X1 = 0.2362205F;
            this.line2.X2 = 4.72441F;
            this.line2.Y1 = 0.3456693F;
            this.line2.Y2 = 0.3456693F;
            // 
            // label25
            // 
            this.label25.Height = 0.3149606F;
            this.label25.HyperLink = null;
            this.label25.Left = 3.228347F;
            this.label25.Name = "label25";
            this.label25.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label25.Text = "台";
            this.label25.Top = 1.574803F;
            this.label25.Width = 0.3937009F;
            // 
            // label26
            // 
            this.label26.Height = 0.3149606F;
            this.label26.HyperLink = null;
            this.label26.Left = 3.228347F;
            this.label26.Name = "label26";
            this.label26.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label26.Text = "台";
            this.label26.Top = 1.889764F;
            this.label26.Width = 0.3937009F;
            // 
            // label27
            // 
            this.label27.Height = 0.3149606F;
            this.label27.HyperLink = null;
            this.label27.Left = 3.622047F;
            this.label27.Name = "label27";
            this.label27.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label27.Text = "＠";
            this.label27.Top = 1.574803F;
            this.label27.Width = 0.3543305F;
            // 
            // label28
            // 
            this.label28.Height = 0.3149606F;
            this.label28.HyperLink = null;
            this.label28.Left = 3.622047F;
            this.label28.Name = "label28";
            this.label28.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label28.Text = "＠";
            this.label28.Top = 1.889764F;
            this.label28.Width = 0.3543305F;
            // 
            // label29
            // 
            this.label29.Height = 0.2708333F;
            this.label29.HyperLink = null;
            this.label29.Left = 0.472441F;
            this.label29.Name = "label29";
            this.label29.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label29.Style = "font-family: ＭＳ Ｐ明朝; font-size: 12pt; text-align: left; vertical-align: middle";
            this.label29.Text = "振込先：常陽銀行　本店　普通預金　47517";
            this.label29.Top = 3.149606F;
            this.label29.Width = 5.905512F;
            // 
            // label30
            // 
            this.label30.Height = 0.2708333F;
            this.label30.HyperLink = null;
            this.label30.Left = 0.472441F;
            this.label30.Name = "label30";
            this.label30.Padding = new DataDynamics.ActiveReports.PaddingEx(20, 0, 0, 0);
            this.label30.Style = "font-family: ＭＳ Ｐ明朝; font-size: 12pt; text-align: right; vertical-align: middle";
            this.label30.Text = "一般社団法人 日本自動車販売協会連合会茨城県支部";
            this.label30.Top = 3.464567F;
            this.label30.Width = 5.905512F;
            // 
            // line4
            // 
            this.line4.Height = 0F;
            this.line4.Left = 0.07874012F;
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 4.173229F;
            this.line4.Width = 6.614173F;
            this.line4.X1 = 0.07874012F;
            this.line4.X2 = 6.692913F;
            this.line4.Y1 = 4.173229F;
            this.line4.Y2 = 4.173229F;
            // 
            // line5
            // 
            this.line5.Height = 0F;
            this.line5.Left = 0.07874012F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 4.330709F;
            this.line5.Width = 6.614174F;
            this.line5.X1 = 0.07874012F;
            this.line5.X2 = 6.692914F;
            this.line5.Y1 = 4.330709F;
            this.line5.Y2 = 4.330709F;
            // 
            // label10
            // 
            this.label10.Height = 0.3182746F;
            this.label10.HyperLink = null;
            this.label10.Left = 0.2362204F;
            this.label10.Name = "label10";
            this.label10.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; vertical-align: middle";
            this.label10.Text = "摘要";
            this.label10.Top = 5.118111F;
            this.label10.Width = 2.362205F;
            // 
            // label11
            // 
            this.label11.Height = 0.3149607F;
            this.label11.HyperLink = null;
            this.label11.Left = 4.488189F;
            this.label11.Name = "label11";
            this.label11.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label11.Text = "金額";
            this.label11.Top = 5.118111F;
            this.label11.Width = 2.007874F;
            // 
            // label12
            // 
            this.label12.Height = 0.3149607F;
            this.label12.HyperLink = null;
            this.label12.Left = 3.700788F;
            this.label12.Name = "label12";
            this.label12.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label12.Text = "単価";
            this.label12.Top = 5.118111F;
            this.label12.Width = 0.7874014F;
            // 
            // label13
            // 
            this.label13.Height = 0.3149607F;
            this.label13.HyperLink = null;
            this.label13.Left = 2.755906F;
            this.label13.Name = "label13";
            this.label13.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: center; text-justify: auto; ver" +
    "tical-align: middle";
            this.label13.Text = "台数";
            this.label13.Top = 5.118111F;
            this.label13.Width = 0.7874014F;
            // 
            // label31
            // 
            this.label31.Height = 0.3079069F;
            this.label31.HyperLink = null;
            this.label31.Left = 0.3149607F;
            this.label31.Name = "label31";
            this.label31.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; vertical-align: middle";
            this.label31.Text = "茨城県自動車販売店協会";
            this.label31.Top = 4.645669F;
            this.label31.Width = 2.283465F;
            // 
            // label32
            // 
            this.label32.Height = 0.3149606F;
            this.label32.HyperLink = null;
            this.label32.Left = 2.913386F;
            this.label32.Name = "label32";
            this.label32.Style = "font-family: ＭＳ Ｐ明朝; font-size: 14pt; vertical-align: middle";
            this.label32.Text = "月分会費";
            this.label32.Top = 4.645669F;
            this.label32.Width = 0.9479167F;
            // 
            // label33
            // 
            this.label33.Height = 0.3149606F;
            this.label33.HyperLink = null;
            this.label33.Left = 0.2362205F;
            this.label33.Name = "label33";
            this.label33.Padding = new DataDynamics.ActiveReports.PaddingEx(0, 0, 20, 0);
            this.label33.Style = "font-family: ＭＳ Ｐ明朝; font-size: 11pt; text-align: right; vertical-align: middle";
            this.label33.Text = "請求金額合計";
            this.label33.Top = 8.315748F;
            this.label33.Width = 4.251968F;
            // 
            // line6
            // 
            this.line6.Height = 0F;
            this.line6.Left = 0.2362204F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 1.259843F;
            this.line6.Width = 6.299211F;
            this.line6.X1 = 0.2362204F;
            this.line6.X2 = 6.535431F;
            this.line6.Y1 = 1.259843F;
            this.line6.Y2 = 1.259843F;
            // 
            // line7
            // 
            this.line7.Height = 0F;
            this.line7.Left = 0.2362204F;
            this.line7.LineWeight = 1F;
            this.line7.Name = "line7";
            this.line7.Top = 2.913386F;
            this.line7.Width = 6.299213F;
            this.line7.X1 = 0.2362204F;
            this.line7.X2 = 6.535434F;
            this.line7.Y1 = 2.913386F;
            this.line7.Y2 = 2.913386F;
            // 
            // line8
            // 
            this.line8.Height = 0F;
            this.line8.Left = 0.2362204F;
            this.line8.LineWeight = 1F;
            this.line8.Name = "line8";
            this.line8.Top = 1.574803F;
            this.line8.Width = 6.299213F;
            this.line8.X1 = 0.2362204F;
            this.line8.X2 = 6.535434F;
            this.line8.Y1 = 1.574803F;
            this.line8.Y2 = 1.574803F;
            // 
            // line9
            // 
            this.line9.Height = 0F;
            this.line9.Left = 0.2362204F;
            this.line9.LineWeight = 1F;
            this.line9.Name = "line9";
            this.line9.Top = 1.889764F;
            this.line9.Width = 6.299213F;
            this.line9.X1 = 0.2362204F;
            this.line9.X2 = 6.535434F;
            this.line9.Y1 = 1.889764F;
            this.line9.Y2 = 1.889764F;
            // 
            // line10
            // 
            this.line10.Height = 0F;
            this.line10.Left = 0.2362204F;
            this.line10.LineWeight = 1F;
            this.line10.Name = "line10";
            this.line10.Top = 2.204725F;
            this.line10.Width = 6.299213F;
            this.line10.X1 = 0.2362204F;
            this.line10.X2 = 6.535434F;
            this.line10.Y1 = 2.204725F;
            this.line10.Y2 = 2.204725F;
            // 
            // line11
            // 
            this.line11.Height = 0F;
            this.line11.Left = 0.2362204F;
            this.line11.LineWeight = 1F;
            this.line11.Name = "line11";
            this.line11.Top = 2.519685F;
            this.line11.Width = 6.299213F;
            this.line11.X1 = 0.2362204F;
            this.line11.X2 = 6.535434F;
            this.line11.Y1 = 2.519685F;
            this.line11.Y2 = 2.519685F;
            // 
            // line12
            // 
            this.line12.Height = 0F;
            this.line12.Left = 0.2362205F;
            this.line12.LineWeight = 1F;
            this.line12.Name = "line12";
            this.line12.Top = 2.547244F;
            this.line12.Width = 6.299213F;
            this.line12.X1 = 0.2362205F;
            this.line12.X2 = 6.535434F;
            this.line12.Y1 = 2.547244F;
            this.line12.Y2 = 2.547244F;
            // 
            // line13
            // 
            this.line13.Height = 1.65354F;
            this.line13.Left = 0.2362204F;
            this.line13.LineWeight = 1F;
            this.line13.Name = "line13";
            this.line13.Top = 1.259843F;
            this.line13.Width = 2.980232E-07F;
            this.line13.X1 = 0.2362204F;
            this.line13.X2 = 0.2362207F;
            this.line13.Y1 = 1.259843F;
            this.line13.Y2 = 2.913383F;
            // 
            // line14
            // 
            this.line14.Height = 1.65354F;
            this.line14.Left = 6.535434F;
            this.line14.LineWeight = 1F;
            this.line14.Name = "line14";
            this.line14.Top = 1.259843F;
            this.line14.Width = 0F;
            this.line14.X1 = 6.535434F;
            this.line14.X2 = 6.535434F;
            this.line14.Y1 = 1.259843F;
            this.line14.Y2 = 2.913383F;
            // 
            // line15
            // 
            this.line15.Height = 1.653542F;
            this.line15.Left = 4.488189F;
            this.line15.LineWeight = 1F;
            this.line15.Name = "line15";
            this.line15.Top = 1.259843F;
            this.line15.Width = 0F;
            this.line15.X1 = 4.488189F;
            this.line15.X2 = 4.488189F;
            this.line15.Y1 = 1.259843F;
            this.line15.Y2 = 2.913385F;
            // 
            // line16
            // 
            this.line16.Height = 1.259842F;
            this.line16.Left = 3.622047F;
            this.line16.LineWeight = 1F;
            this.line16.Name = "line16";
            this.line16.Top = 1.259843F;
            this.line16.Width = 0F;
            this.line16.X1 = 3.622047F;
            this.line16.X2 = 3.622047F;
            this.line16.Y1 = 1.259843F;
            this.line16.Y2 = 2.519685F;
            // 
            // line17
            // 
            this.line17.Height = 1.259842F;
            this.line17.Left = 2.598425F;
            this.line17.LineWeight = 1F;
            this.line17.Name = "line17";
            this.line17.Top = 1.259843F;
            this.line17.Width = 0F;
            this.line17.X1 = 2.598425F;
            this.line17.X2 = 2.598425F;
            this.line17.Y1 = 1.259843F;
            this.line17.Y2 = 2.519685F;
            // 
            // line20
            // 
            this.line20.Height = 0F;
            this.line20.Left = 0.2362204F;
            this.line20.LineWeight = 1F;
            this.line20.Name = "line20";
            this.line20.Top = 5.433071F;
            this.line20.Width = 6.299213F;
            this.line20.X1 = 0.2362204F;
            this.line20.X2 = 6.535434F;
            this.line20.Y1 = 5.433071F;
            this.line20.Y2 = 5.433071F;
            // 
            // line21
            // 
            this.line21.Height = 0F;
            this.line21.Left = 0.2362204F;
            this.line21.LineWeight = 1F;
            this.line21.Name = "line21";
            this.line21.Top = 5.748032F;
            this.line21.Width = 6.299213F;
            this.line21.X1 = 0.2362204F;
            this.line21.X2 = 6.535434F;
            this.line21.Y1 = 5.748032F;
            this.line21.Y2 = 5.748032F;
            // 
            // line22
            // 
            this.line22.Height = 0F;
            this.line22.Left = 0.2362204F;
            this.line22.LineWeight = 1F;
            this.line22.Name = "line22";
            this.line22.Top = 6.062993F;
            this.line22.Width = 6.299213F;
            this.line22.X1 = 0.2362204F;
            this.line22.X2 = 6.535434F;
            this.line22.Y1 = 6.062993F;
            this.line22.Y2 = 6.062993F;
            // 
            // line23
            // 
            this.line23.Height = 0F;
            this.line23.Left = 0.2362204F;
            this.line23.LineWeight = 1F;
            this.line23.Name = "line23";
            this.line23.Top = 6.377953F;
            this.line23.Width = 6.299213F;
            this.line23.X1 = 0.2362204F;
            this.line23.X2 = 6.535434F;
            this.line23.Y1 = 6.377953F;
            this.line23.Y2 = 6.377953F;
            // 
            // line24
            // 
            this.line24.Height = 0F;
            this.line24.Left = 0.2362204F;
            this.line24.LineWeight = 1F;
            this.line24.Name = "line24";
            this.line24.Top = 6.692914F;
            this.line24.Width = 6.299213F;
            this.line24.X1 = 0.2362204F;
            this.line24.X2 = 6.535434F;
            this.line24.Y1 = 6.692914F;
            this.line24.Y2 = 6.692914F;
            // 
            // line25
            // 
            this.line25.Height = 0F;
            this.line25.Left = 0.2362204F;
            this.line25.LineWeight = 1F;
            this.line25.Name = "line25";
            this.line25.Top = 7.007874F;
            this.line25.Width = 6.299213F;
            this.line25.X1 = 0.2362204F;
            this.line25.X2 = 6.535434F;
            this.line25.Y1 = 7.007874F;
            this.line25.Y2 = 7.007874F;
            // 
            // line26
            // 
            this.line26.Height = 0F;
            this.line26.Left = 0.2362204F;
            this.line26.LineWeight = 1F;
            this.line26.Name = "line26";
            this.line26.Top = 7.322835F;
            this.line26.Width = 6.299213F;
            this.line26.X1 = 0.2362204F;
            this.line26.X2 = 6.535434F;
            this.line26.Y1 = 7.322835F;
            this.line26.Y2 = 7.322835F;
            // 
            // line27
            // 
            this.line27.Height = 0F;
            this.line27.Left = 0.2362204F;
            this.line27.LineWeight = 1F;
            this.line27.Name = "line27";
            this.line27.Top = 7.637795F;
            this.line27.Width = 6.299213F;
            this.line27.X1 = 0.2362204F;
            this.line27.X2 = 6.535434F;
            this.line27.Y1 = 7.637795F;
            this.line27.Y2 = 7.637795F;
            // 
            // line28
            // 
            this.line28.Height = 0F;
            this.line28.Left = 0.2362204F;
            this.line28.LineWeight = 1F;
            this.line28.Name = "line28";
            this.line28.Top = 7.952756F;
            this.line28.Width = 6.299213F;
            this.line28.X1 = 0.2362204F;
            this.line28.X2 = 6.535434F;
            this.line28.Y1 = 7.952756F;
            this.line28.Y2 = 7.952756F;
            // 
            // line29
            // 
            this.line29.Height = 0F;
            this.line29.Left = 0.2362204F;
            this.line29.LineWeight = 1F;
            this.line29.Name = "line29";
            this.line29.Top = 8.267717F;
            this.line29.Width = 6.299213F;
            this.line29.X1 = 0.2362204F;
            this.line29.X2 = 6.535434F;
            this.line29.Y1 = 8.267717F;
            this.line29.Y2 = 8.267717F;
            // 
            // line30
            // 
            this.line30.Height = 3.543309F;
            this.line30.Left = 0.2362204F;
            this.line30.LineWeight = 1F;
            this.line30.Name = "line30";
            this.line30.Top = 5.118109F;
            this.line30.Width = 0F;
            this.line30.X1 = 0.2362204F;
            this.line30.X2 = 0.2362204F;
            this.line30.Y1 = 5.118109F;
            this.line30.Y2 = 8.661418F;
            // 
            // line31
            // 
            this.line31.Height = 0F;
            this.line31.Left = 0.2362205F;
            this.line31.LineWeight = 1F;
            this.line31.Name = "line31";
            this.line31.Top = 8.295276F;
            this.line31.Width = 6.299213F;
            this.line31.X1 = 0.2362205F;
            this.line31.X2 = 6.535434F;
            this.line31.Y1 = 8.295276F;
            this.line31.Y2 = 8.295276F;
            // 
            // line33
            // 
            this.line33.Height = 2.834647F;
            this.line33.Left = 2.598425F;
            this.line33.LineWeight = 1F;
            this.line33.Name = "line33";
            this.line33.Top = 5.118111F;
            this.line33.Width = 0F;
            this.line33.X1 = 2.598425F;
            this.line33.X2 = 2.598425F;
            this.line33.Y1 = 5.118111F;
            this.line33.Y2 = 7.952758F;
            // 
            // line34
            // 
            this.line34.Height = 2.834647F;
            this.line34.Left = 3.622047F;
            this.line34.LineWeight = 1F;
            this.line34.Name = "line34";
            this.line34.Top = 5.118111F;
            this.line34.Width = 0F;
            this.line34.X1 = 3.622047F;
            this.line34.X2 = 3.622047F;
            this.line34.Y1 = 5.118111F;
            this.line34.Y2 = 7.952758F;
            // 
            // line35
            // 
            this.line35.Height = 3.543309F;
            this.line35.Left = 4.488189F;
            this.line35.LineWeight = 1F;
            this.line35.Name = "line35";
            this.line35.Top = 5.118111F;
            this.line35.Width = 0F;
            this.line35.X1 = 4.488189F;
            this.line35.X2 = 4.488189F;
            this.line35.Y1 = 5.118111F;
            this.line35.Y2 = 8.66142F;
            // 
            // line36
            // 
            this.line36.Height = 3.543309F;
            this.line36.Left = 6.535434F;
            this.line36.LineWeight = 1F;
            this.line36.Name = "line36";
            this.line36.Top = 5.118111F;
            this.line36.Width = 0F;
            this.line36.X1 = 6.535434F;
            this.line36.X2 = 6.535434F;
            this.line36.Y1 = 5.118111F;
            this.line36.Y2 = 8.66142F;
            // 
            // label50
            // 
            this.label50.Height = 0.2708333F;
            this.label50.HyperLink = null;
            this.label50.Left = 0.3937008F;
            this.label50.Name = "label50";
            this.label50.Style = "font-family: ＭＳ Ｐ明朝; font-size: 12pt; text-align: center; vertical-align: middle";
            this.label50.Text = "振込先：常陽銀行　本店　普通預金　117235　　茨城県自動車販売店協会";
            this.label50.Top = 8.897638F;
            this.label50.Width = 5.984252F;
            // 
            // txtMonthRep0
            // 
            this.txtMonthRep0.CanGrow = false;
            this.txtMonthRep0.DataField = "MonthRep";
            this.txtMonthRep0.Height = 0.3125F;
            this.txtMonthRep0.Left = 1.968504F;
            this.txtMonthRep0.Name = "txtMonthRep0";
            this.txtMonthRep0.Style = "font-family: ＭＳ Ｐ明朝; font-size: 16pt; text-align: center; vertical-align: middle";
            this.txtMonthRep0.Text = "99";
            this.txtMonthRep0.Top = 0.7874016F;
            this.txtMonthRep0.Width = 0.3958333F;
            // 
            // line3
            // 
            this.line3.Height = 0F;
            this.line3.Left = 0.2362204F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 1.181103F;
            this.line3.Width = 6.299211F;
            this.line3.X1 = 0.2362204F;
            this.line3.X2 = 6.535431F;
            this.line3.Y1 = 1.181103F;
            this.line3.Y2 = 1.181103F;
            // 
            // txtMonthRep1
            // 
            this.txtMonthRep1.DataField = "MonthRep";
            this.txtMonthRep1.Height = 0.3125F;
            this.txtMonthRep1.Left = 2.519685F;
            this.txtMonthRep1.Name = "txtMonthRep1";
            this.txtMonthRep1.Style = "font-family: ＭＳ Ｐ明朝; font-size: 16pt; text-align: center; vertical-align: middle";
            this.txtMonthRep1.Text = "99";
            this.txtMonthRep1.Top = 4.645669F;
            this.txtMonthRep1.Width = 0.3958333F;
            // 
            // line19
            // 
            this.line19.Height = 0F;
            this.line19.Left = 0.2362204F;
            this.line19.LineWeight = 1F;
            this.line19.Name = "line19";
            this.line19.Top = 5.118109F;
            this.line19.Width = 6.299213F;
            this.line19.X1 = 0.2362204F;
            this.line19.X2 = 6.535434F;
            this.line19.Y1 = 5.118109F;
            this.line19.Y2 = 5.118109F;
            // 
            // line18
            // 
            this.line18.Height = 0F;
            this.line18.Left = 0.2362204F;
            this.line18.LineWeight = 1F;
            this.line18.Name = "line18";
            this.line18.Top = 5.03937F;
            this.line18.Width = 6.299213F;
            this.line18.X1 = 0.2362204F;
            this.line18.X2 = 6.535434F;
            this.line18.Y1 = 5.03937F;
            this.line18.Y2 = 5.03937F;
            // 
            // line32
            // 
            this.line32.Height = 0F;
            this.line32.Left = 0.2362204F;
            this.line32.LineWeight = 1F;
            this.line32.Name = "line32";
            this.line32.Top = 8.661418F;
            this.line32.Width = 6.299213F;
            this.line32.X1 = 0.2362204F;
            this.line32.X2 = 6.535434F;
            this.line32.Y1 = 8.661418F;
            this.line32.Y2 = 8.661418F;
            // 
            // Invoice
            // 
            this.MasterReport = false;
            this.PageSettings.Margins.Bottom = 0F;
            this.PageSettings.Margins.Left = 0.7874016F;
            this.PageSettings.Margins.Right = 0.1968504F;
            this.PageSettings.Margins.Top = 1.574803F;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.892716F;
            this.Sections.Add(this.detail);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128; text-align: left; ve" +
            "rtical-align: top", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 128", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; ddo-char-set: 128", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 128", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.Invoice_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_LessThan29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_LessThan29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_LessThan29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Over30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Over30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Over30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_To2000From1000cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_To2000From1000cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_To2000From1000cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Over2001cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Over2001cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Over2001cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu4DP9_3t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu4DP9_3t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu4DP9_3t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_BigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_BigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_BigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_MediumSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_MediumSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_MediumSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumSibuMemberFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu7t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu7t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu7t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu6DP9_5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu6DP9_5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu6DP9_5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum_Kamotu2DP9_2DP5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Kamotu2DP9_2DP5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_Kamotu2DP9_2DP5t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumSibuMemberFeeHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_MemberFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumMemberFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthRep0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthRep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtCONAME;
        private DataDynamics.ActiveReports.TextBox txtNum_BigSize;
        private DataDynamics.ActiveReports.TextBox txtU_BigSize;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.TextBox txtSum_BigSize;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.Label label8;
        private DataDynamics.ActiveReports.Label label9;
        private DataDynamics.ActiveReports.TextBox txtNum_MediumSmall;
        private DataDynamics.ActiveReports.TextBox txtU_MediumSmall;
        private DataDynamics.ActiveReports.TextBox txtSum_MediumSmall;
        private DataDynamics.ActiveReports.TextBox txtU_Average;
        private DataDynamics.ActiveReports.TextBox txtSumSibuMemberFee;
        private DataDynamics.ActiveReports.Label label14;
        private DataDynamics.ActiveReports.Label label15;
        private DataDynamics.ActiveReports.Label label16;
        private DataDynamics.ActiveReports.Label label17;
        private DataDynamics.ActiveReports.TextBox txtNum_Kamotu7t;
        private DataDynamics.ActiveReports.TextBox txtU_Kamotu7t;
        private DataDynamics.ActiveReports.TextBox txtSum_Kamotu7t;
        private DataDynamics.ActiveReports.TextBox txtNum_Kamotu6DP9_5t;
        private DataDynamics.ActiveReports.TextBox txtU_Kamotu6DP9_5t;
        private DataDynamics.ActiveReports.TextBox txtSum_Kamotu6DP9_5t;
        private DataDynamics.ActiveReports.TextBox txtNum_Kamotu4DP9_3t;
        private DataDynamics.ActiveReports.TextBox txtU_Kamotu4DP9_3t;
        private DataDynamics.ActiveReports.TextBox txtSum_Kamotu4DP9_3t;
        private DataDynamics.ActiveReports.TextBox txtNum_Kamotu2DP9_2DP5t;
        private DataDynamics.ActiveReports.TextBox txtU_Kamotu2DP9_2DP5t;
        private DataDynamics.ActiveReports.TextBox txtSum_Kamotu2DP9_2DP5t;
        private DataDynamics.ActiveReports.Label label18;
        private DataDynamics.ActiveReports.Label label19;
        private DataDynamics.ActiveReports.Label label20;
        private DataDynamics.ActiveReports.Label label21;
        private DataDynamics.ActiveReports.TextBox txtNum_Over2001cc;
        private DataDynamics.ActiveReports.TextBox txtU_Over2001cc;
        private DataDynamics.ActiveReports.TextBox txtSum_Over2001cc;
        private DataDynamics.ActiveReports.TextBox txtNum_To2000From1000cc;
        private DataDynamics.ActiveReports.TextBox txtU_To2000From1000cc;
        private DataDynamics.ActiveReports.TextBox txtSum_To2000From1000cc;
        private DataDynamics.ActiveReports.TextBox txtNum_Over30;
        private DataDynamics.ActiveReports.TextBox txtU_Over30;
        private DataDynamics.ActiveReports.TextBox txtSum_Over30;
        private DataDynamics.ActiveReports.TextBox txtNum_LessThan29;
        private DataDynamics.ActiveReports.TextBox txtU_LessThan29;
        private DataDynamics.ActiveReports.TextBox txtSum_LessThan29;
        private DataDynamics.ActiveReports.TextBox txtSumSibuMemberFeeHeader;
        private DataDynamics.ActiveReports.TextBox txtU_MemberFee;
        private DataDynamics.ActiveReports.Label label22;
        private DataDynamics.ActiveReports.TextBox txtSumMemberFee;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.Label label23;
        private DataDynamics.ActiveReports.Label label24;
        private DataDynamics.ActiveReports.Line line1;
        private DataDynamics.ActiveReports.Line line2;
        private DataDynamics.ActiveReports.Line line3;
        private DataDynamics.ActiveReports.Label label25;
        private DataDynamics.ActiveReports.Label label26;
        private DataDynamics.ActiveReports.Label label27;
        private DataDynamics.ActiveReports.Label label28;
        private DataDynamics.ActiveReports.Label label29;
        private DataDynamics.ActiveReports.Label label30;
        private DataDynamics.ActiveReports.Line line4;
        private DataDynamics.ActiveReports.Line line5;
        private DataDynamics.ActiveReports.Label label10;
        private DataDynamics.ActiveReports.Label label11;
        private DataDynamics.ActiveReports.Label label12;
        private DataDynamics.ActiveReports.Label label13;
        private DataDynamics.ActiveReports.Label label31;
        private DataDynamics.ActiveReports.Label label32;
        private DataDynamics.ActiveReports.Label label33;
        private DataDynamics.ActiveReports.Line line6;
        private DataDynamics.ActiveReports.Line line7;
        private DataDynamics.ActiveReports.Line line8;
        private DataDynamics.ActiveReports.Line line9;
        private DataDynamics.ActiveReports.Line line10;
        private DataDynamics.ActiveReports.Line line11;
        private DataDynamics.ActiveReports.Line line12;
        private DataDynamics.ActiveReports.Line line13;
        private DataDynamics.ActiveReports.Line line14;
        private DataDynamics.ActiveReports.Line line15;
        private DataDynamics.ActiveReports.Line line16;
        private DataDynamics.ActiveReports.Line line17;
        private DataDynamics.ActiveReports.Line line18;
        private DataDynamics.ActiveReports.Line line19;
        private DataDynamics.ActiveReports.Line line20;
        private DataDynamics.ActiveReports.Line line21;
        private DataDynamics.ActiveReports.Line line22;
        private DataDynamics.ActiveReports.Line line23;
        private DataDynamics.ActiveReports.Line line24;
        private DataDynamics.ActiveReports.Line line25;
        private DataDynamics.ActiveReports.Line line26;
        private DataDynamics.ActiveReports.Line line27;
        private DataDynamics.ActiveReports.Line line28;
        private DataDynamics.ActiveReports.Line line29;
        private DataDynamics.ActiveReports.Line line30;
        private DataDynamics.ActiveReports.Line line31;
        private DataDynamics.ActiveReports.Line line32;
        private DataDynamics.ActiveReports.Line line33;
        private DataDynamics.ActiveReports.Line line34;
        private DataDynamics.ActiveReports.Line line35;
        private DataDynamics.ActiveReports.Line line36;
        private DataDynamics.ActiveReports.Label label34;
        private DataDynamics.ActiveReports.Label label35;
        private DataDynamics.ActiveReports.Label label36;
        private DataDynamics.ActiveReports.Label label37;
        private DataDynamics.ActiveReports.Label label38;
        private DataDynamics.ActiveReports.Label label39;
        private DataDynamics.ActiveReports.Label label40;
        private DataDynamics.ActiveReports.Label label41;
        private DataDynamics.ActiveReports.Label label42;
        private DataDynamics.ActiveReports.Label label43;
        private DataDynamics.ActiveReports.Label label44;
        private DataDynamics.ActiveReports.Label label45;
        private DataDynamics.ActiveReports.Label label46;
        private DataDynamics.ActiveReports.Label label47;
        private DataDynamics.ActiveReports.Label label48;
        private DataDynamics.ActiveReports.Label label49;
        private DataDynamics.ActiveReports.Label label50;
        private DataDynamics.ActiveReports.TextBox txtMonthRep0;
        private DataDynamics.ActiveReports.TextBox txtMonthRep1;
    }
}
