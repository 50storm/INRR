using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Igarashi
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Net;
//Igarashi
using Jisseki_Report_Ibaraki.Tools;


namespace Jisseki_Report_Ibaraki.jada.search
{
    public partial class reported_member : System.Web.UI.Page
    {
        //接続文字列
        private String strConn;
        //Index for Gridview
        private const int GV_INDEX_会社コード = 0;
        private const int GV_INDEX_会社名 = 1;
        private const int GV_INDEX_会員担当者 = 2;
        private const int GV_INDEX_受信日付 = 3;
        private const int GV_INDEX_報告日付 = 4;
        private const int GV_INDEX_削除 = 5;
        private const int GV_INDEX_修正 = 6;
        private const int GV_INDEX_YEAR = 7;
        private const int GV_INDEX_MONTH = 8;
        private const int GV_INDEX_DAY = 9;
        private const int GV_INDEX_YEAR_REP = 10;
        private const int GV_INDEX_MONTH_REP = 11;




        //検索クエリー用
       // private string qCOCODE,qYearRep,qMonthRep;

        private void searchReportData( string qYearRepFrom, string qMonthRepFrom, string qYearRepTo, string qMonthRepTo)
        {
            //初期表示
            string Sql =
                " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header] H "
                + " INNER JOIN  [Jisseki_Report_Ibaraki].[dbo].[ID ] I "
                + " ON H.COCODE=I.COCODE "
                + " WHERE "
                + "  ( H.YearRep >= @YearRepFrom AND H.MonthRep >= @MonthRepFrom) "
                + " AND ( H.YearRep <= @YearRepTo AND H.MonthRep <= @MonthRepTo) ";


            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@YearRepFrom", qYearRepFrom));
                    cmd.Parameters.Add(new SqlParameter("@MonthRepFrom", qMonthRepFrom));
                    cmd.Parameters.Add(new SqlParameter("@YearRepTo", qYearRepTo));
                    cmd.Parameters.Add(new SqlParameter("@MonthRepTo", qMonthRepTo));

                    //送信日
                    Gridview1.Columns[GV_INDEX_YEAR].Visible = true;
                    Gridview1.Columns[GV_INDEX_MONTH].Visible = true;
                    Gridview1.Columns[GV_INDEX_DAY].Visible = true;
                    //報告台数提出日
                    Gridview1.Columns[GV_INDEX_YEAR_REP].Visible = true;
                    Gridview1.Columns[GV_INDEX_MONTH_REP].Visible = true;


                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Sql, Conn))
                    {
                        Adapter.SelectCommand = cmd;
                        DataTable header = new DataTable("新車台数ヘッダー");
                        Adapter.Fill(header);

                        if (header.Rows.Count == 0)
                        {
                            Gridview1.DataSource = header;
                            Gridview1.DataBind();
                            lblMsg.Text = "検索データはありません。";
                            lblMsg.BackColor = System.Drawing.Color.Pink;
                        }
                        else 
                        {
                            Gridview1.DataSource = header;
                            Gridview1.DataBind();
                            lblMsg.Text = "";
                            lblMsg.BackColor = System.Drawing.Color.White;
                        
                        }

                        
                    }

                    
                    string wEra;
                    string wYear;
                    string wDate;
                    JapaneseCalendar jCalender = new JapaneseCalendar();
                    for (int i = 0; i < Gridview1.Rows.Count; i++)
                    {
                        //Covert Christian Era To Japanese Era
                        DateTime JapaneseDate = DateTime.Parse(Gridview1.Rows[i].Cells[GV_INDEX_YEAR].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_DAY].Text);
                        wEra = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                        wYear = jCalender.GetYear(JapaneseDate).ToString();
                        wDate = wEra + wYear + "年" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH].Text + "月" + Gridview1.Rows[i].Cells[GV_INDEX_DAY].Text + "日";
                        Gridview1.Rows[i].Cells[GV_INDEX_受信日付].Text = wDate;

                        //報告台数提出日
                        DateTime JapaneseDateRep = DateTime.Parse(Gridview1.Rows[i].Cells[GV_INDEX_YEAR_REP].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH_REP].Text);
                        wEra = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDateRep));
                        wYear = jCalender.GetYear(JapaneseDateRep).ToString();
                        wDate = wEra + wYear + "年" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH_REP].Text + "月";
                        Gridview1.Rows[i].Cells[GV_INDEX_報告日付].Text = wDate;


                    }
                    //送信日
                    Gridview1.Columns[GV_INDEX_YEAR].Visible = false;
                    Gridview1.Columns[GV_INDEX_MONTH].Visible = false;
                    Gridview1.Columns[GV_INDEX_DAY].Visible = false;
                    //報告台数提出日
                    Gridview1.Columns[GV_INDEX_YEAR_REP].Visible = false;
                    Gridview1.Columns[GV_INDEX_MONTH_REP].Visible = false;
                }
                Conn.Close();
            }



        }

        
        protected void Page_Load(object sender, EventArgs e)
        {   
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }


            //接続文字列
            strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;
            
            if(Page.IsPostBack){
            
            }
            else
            {
                //初期表示は報告台数の報告年
                string strSql =
                    " SELECT *  FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header] H "
                      + " INNER JOIN  [Jisseki_Report_Ibaraki].[dbo].[ID ] I "
                      + " ON H.COCODE=I.COCODE "
                      + " WHERE YearRep = @YearRep ";

                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand(strSql, Conn);
                    //cmd.Parameters.Add(new SqlParameter("@COCODE", Session["COCODE"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", DateTime.Today.Year.ToString()));

                    using (SqlDataAdapter Adapter = new SqlDataAdapter(strSql, Conn))
                    {
                        Adapter.SelectCommand = cmd;
                        DataTable header = new DataTable("新車台数ヘッダー");
                        Adapter.Fill(header);

                        Gridview1.DataSource = header;
                        Gridview1.DataBind();

                        string wEra;
                        string wYear;
                        string wDate;
                        JapaneseCalendar jCalender = new JapaneseCalendar();
                        for (int i = 0; i < Gridview1.Rows.Count; i++)
                        {
                            //Covert Christian Era To Japanese Era
                            //送信(受信)日付
                            DateTime JapaneseDate = DateTime.Parse(Gridview1.Rows[i].Cells[GV_INDEX_YEAR].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_DAY].Text);
                            wEra = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                            wYear = jCalender.GetYear(JapaneseDate).ToString();
                            wDate = wEra + wYear + "年" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH].Text + "月" + Gridview1.Rows[i].Cells[GV_INDEX_DAY].Text + "日";
                            Gridview1.Rows[i].Cells[GV_INDEX_受信日付].Text = wDate;


                            //報告台数提出日
                            DateTime JapaneseDateRep = DateTime.Parse(Gridview1.Rows[i].Cells[GV_INDEX_YEAR_REP].Text + "/" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH_REP].Text);
                            wEra = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDateRep));
                            wYear = jCalender.GetYear(JapaneseDateRep).ToString();
                            wDate = wEra + wYear + "年" + Gridview1.Rows[i].Cells[GV_INDEX_MONTH_REP].Text + "月";
                            Gridview1.Rows[i].Cells[GV_INDEX_報告日付].Text = wDate;




                        }
                        //送信日
                        Gridview1.Columns[GV_INDEX_YEAR].Visible = false;
                        Gridview1.Columns[GV_INDEX_MONTH].Visible = false;
                        Gridview1.Columns[GV_INDEX_DAY].Visible = false;
                        //報告台数提出日
                        Gridview1.Columns[GV_INDEX_YEAR_REP].Visible = false;
                        Gridview1.Columns[GV_INDEX_MONTH_REP].Visible = false;
                        //初期値
                        this.txtYearRepFrom.Text = jCalender.GetYear(DateTime.Today).ToString();
                        this.txtMonthRepFrom.Text = "1";
                        this.txtYearRepTo.Text = jCalender.GetYear(DateTime.Today).ToString();
                        this.txtMonthRepTo.Text = "12";

                    }
            }
           
            }
        }

       
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //必須チェック
                if (this.txtYearRepFrom.Text.Trim() == string.Empty)
                {
                    this.txtYearRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtYearRepFrom.BackColor = System.Drawing.Color.White;
                }

                if (this.txtMonthRepFrom.Text.Trim() == string.Empty)
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.White;
                }

                if (this.txtYearRepTo.Text.Trim() == string.Empty)
                {
                    this.txtYearRepTo.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtYearRepTo.BackColor = System.Drawing.Color.White;
                }

                if (this.txtMonthRepTo.Text.Trim() == string.Empty)
                {
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.White;
                } 


                //数字以外はだめよ
                if (Utility.IsNotNumber(this.txtYearRepFrom.Text))
                {
                    this.txtYearRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtYearRepFrom.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtYearRepTo.Text))
                {
                    this.txtYearRepTo.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtYearRepTo.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtMonthRepFrom.Text))
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtMonthRepTo.Text))
                {
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.White;
                }

                //月範囲チェック。
                int ret = 0;
                int.TryParse(this.txtMonthRepFrom.Text, out ret);
                if (1 <= ret && ret <= 12)
                {
                    //OK
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                int.TryParse(this.txtMonthRepTo.Text, out ret);
                if (1 <= ret && ret <= 12)
                {
                    //OK
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.White;
                }                   
                else                
                {                   
                    this.txtMonthRepTo.BackColor = System.Drawing.Color.Pink;
                    return;
                }


                this.searchReportData(
                    Utility.HeiseiToChristianEra(this.txtYearRepFrom.Text), this.txtMonthRepFrom.Text,
                    Utility.HeiseiToChristianEra(this.txtYearRepTo.Text), this.txtMonthRepTo.Text);

            }
            catch 
            { 
            
            }
        }

        protected void btnlinkMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //自販連
                Response.Redirect(URL.MENU_JADA);
            }
            catch
            {

            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Session.Abandon();
                Response.Redirect(URL.LOGIN_DEALER);

            }
            catch
            {

            }
        }

        protected void Gridview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}