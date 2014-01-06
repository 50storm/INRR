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


namespace Jisseki_Report_Ibaraki.jada.print
{
    public partial class Jisseki : System.Web.UI.Page
    {
        //接続文字列
        private String strConn;

        #region "Insert Jisseki_Header"


        private void deleteHeader() 
        { 
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                String DeleteHeaderSql = "DELETE FROM [Prt_Jisseki_Header] "; 
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteHeaderSql, Conn);
                    cmd.CommandText = DeleteHeaderSql;
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    throw;

                }
        
            }
        }


        private void insertHeader(
                                  string _COCODE,string _TANTOU,string _Year,string _Month,string _Day,
                                  string _YearRep , string _MonthRep)
        {


            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                //INSERT作成

                String InsertHeaderSql = "INSERT INTO [Prt_Jisseki_Header] "
                               + "("
                               + "  [COCODE],[TANTOU],[Year],[Month],[Day],[YearRep],[MonthRep]"
                               + " ) "
                               + " VALUES "
                               + " ( @COCODE,@TANTOU,@Year,@Month,@Day,@YearRep,@MonthRep"
                               + "  ) ";


                //Sqlコネクション
                //try
                //{
                Conn.Open();
                SqlCommand cmd = new SqlCommand(InsertHeaderSql, Conn);
                cmd.CommandText = InsertHeaderSql;
                //Sqlインジェクション回避
                cmd.Parameters.Add(new SqlParameter("@COCODE", _COCODE));
                cmd.Parameters.Add(new SqlParameter("@TANTOU", _TANTOU));
                cmd.Parameters.Add(new SqlParameter("@Year", _Year));
                cmd.Parameters.Add(new SqlParameter("@Month", _Month));
                cmd.Parameters.Add(new SqlParameter("@Day", _Day));
                cmd.Parameters.Add(new SqlParameter("@YearRep", _YearRep));
                cmd.Parameters.Add(new SqlParameter("@MonthRep", _MonthRep));


                cmd.ExecuteNonQuery();

                //}
                //catch
                //{
                //    throw;

                //}
            }
        }

        #endregion

        #region "GridView Index"
        private const int GV_INDEX_会社コード = 0;
        private const int GV_INDEX_会社名 = 1;
        private const int GV_INDEX_会員担当者 = 2;
        private const int GV_INDEX_受信日付 = 3;
        private const int GV_INDEX_報告日付 = 4;
        private const int GV_INDEX_YEAR = 5;
        private const int GV_INDEX_MONTH = 6;
        private const int GV_INDEX_DAY = 7;
        private const int GV_INDEX_YEAR_REP = 8;
        private const int GV_INDEX_MONTH_REP = 9;
        #endregion

        #region "データ検索"


        private void showMessage()
        {
            //初期表示は事務処理年月
            string strSql = "SELECT * FROM ID WHERE "
                            + " COCODE NOT IN "
                            + "( "
                            + " SELECT I.COCODE FROM  [ID] I "
                            + " INNER JOIN  "
                            + " [Jisseki_Header] H "
                            + " ON I.COCODE = H.COCODE "
                            + " WHERE "
                            + " H.YearRep = @YearRep AND H.MonthRep = @MonthRep "//20131204
                            + " AND I.Member = '1' "
                            + " ) "
                            + " AND Member = '1' AND ( isCanceled is null OR isCanceled ='0' ) "
                            + " ORDER BY COCODE "
                            ;


            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(strSql, Conn);

                cmd.Parameters.Add(new SqlParameter("@YearRep", Utility.HeiseiToChristianEra(this.txtYearRepFrom.Text)));
                cmd.Parameters.Add(new SqlParameter("@MonthRep", this.txtMonthRepFrom.Text));


                using (SqlDataAdapter Adapter = new SqlDataAdapter(strSql, Conn))
                {
                    Adapter.SelectCommand = cmd;
                    DataTable header = new DataTable("新車台数ヘッダー");
                    Adapter.Fill(header);

                    if (header.Rows.Count == 0)
                    {
                        lblMsg.Text = "未受信データはありません。";
                        lblMsg.BackColor = System.Drawing.Color.Azure;
                        btnToNonReported.Visible = false;
                    }
                    else
                    {
                        lblMsg.Text = "未受信データがまだあります";
                        lblMsg.BackColor = System.Drawing.Color.Pink;
                        btnToNonReported.Visible = true;
                        btnToNonReported.BackColor = System.Drawing.Color.Pink;

                    }

                }
            }

        }

        private void showDataInit() {

            //初期値
            //20130106                
            //1月のときは、昨年度
            JapaneseCalendar jCalender = new JapaneseCalendar();
            if (DateTime.Today.Month == 1)
            {
                this.txtYearRepFrom.Text = jCalender.GetYear(DateTime.Today.AddYears(-1)).ToString();
                this.txtMonthRepFrom.Text = DateTime.Today.AddMonths(-1).Month.ToString();

            }
            else
            {
                this.txtYearRepFrom.Text = jCalender.GetYear(DateTime.Today).ToString();
                this.txtMonthRepFrom.Text = DateTime.Today.AddMonths(-1).Month.ToString();

            }
            this.From_COCODE.Text = "0000";
            this.To_COCODE.Text = "9999";

            //初期表示は報告台数の報告年
                string strSql =
                    " SELECT *  FROM [Jisseki_Header] H "
                      + " INNER JOIN  [ID ] I "
                      + " ON H.COCODE=I.COCODE "
                      + " WHERE YearRep = @YearRep "
                      + " AND MonthRep = @MonthRep "
                      ;

                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand(strSql, Conn);
                    //cmd.Parameters.Add(new SqlParameter("@COCODE", Session["COCODE"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", Utility.HeiseiToChristianEra(this.txtYearRepFrom.Text)));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", DateTime.Today.AddMonths(-1).Month.ToString()));

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


                    }
                }
        
        }

        private void searchReportData( string qYearRepFrom, string qMonthRepFrom, string _From_COCODE,string _To_COCODE)
        {
            //初期表示
            string Sql =
                " SELECT * FROM [Jisseki_Header] H "
                + " INNER JOIN  [ID ] I "
                + " ON H.COCODE=I.COCODE "
                + " WHERE "
                + "  ( H.YearRep = @YearRepFrom AND H.MonthRep = @MonthRepFrom) "
                + "  AND  H.COCODE >=  @From_COCODE AND H.COCODE <= @To_COCODE "
                ;
            

            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@YearRepFrom", qYearRepFrom));
                    cmd.Parameters.Add(new SqlParameter("@MonthRepFrom", qMonthRepFrom));
                    cmd.Parameters.Add(new SqlParameter("@From_COCODE", _From_COCODE));
                    cmd.Parameters.Add(new SqlParameter("@To_COCODE", _To_COCODE));

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
        #endregion

        #region "初期 イベント"
        protected void Page_Load(object sender, EventArgs e)
        {   
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }


            //接続文字列
            strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;
            
            if(Page.IsPostBack)
            {
            
            }
            else
            {
                //初期表示
                showDataInit();
                showMessage();

            }
         

        }
        #endregion

        #region "ボタン"
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

                if (Utility.IsNotNumber(this.txtMonthRepFrom.Text))
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtMonthRepFrom.BackColor = System.Drawing.Color.White;
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
                
                this.searchReportData(
                 Utility.HeiseiToChristianEra(this.txtYearRepFrom.Text),
                 this.txtMonthRepFrom.Text                             ,
                 this.From_COCODE.Text.Trim()                          ,
                 this.To_COCODE.Text.Trim()
                );
                this.showMessage();

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

        protected void CheckAll_Click(object sender, EventArgs e)
        {

            foreach (GridViewRow gvr in Gridview1.Rows)
            {
                CheckBox cb = (CheckBox)(gvr.FindControl("CheckBoxPrintOnt"));
                cb.Checked = true;
                
            }           

        }

        protected void UnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvr in Gridview1.Rows)
            {
                CheckBox cb = (CheckBox)(gvr.FindControl("CheckBoxPrintOnt"));
                cb.Checked = false;

            }         
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
         
                //削除
                deleteHeader();

                for (int i = 0; i < Gridview1.Rows.Count; i++)
                {
                    GridViewRow gvr = Gridview1.Rows[i];
                    CheckBox cb = (CheckBox)(gvr.FindControl("CheckBoxPrintOnt"));
                    if (cb.Checked)
                    {
      


                           insertHeader(
                                        Gridview1.Rows[i].Cells[GV_INDEX_会社コード].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_会員担当者].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_YEAR].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_MONTH].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_DAY].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_YEAR_REP].Text,
                                        Gridview1.Rows[i].Cells[GV_INDEX_MONTH_REP].Text
                                        );


             
                    }            
                
                }

                this.Session["PrintAll_Jisseki"] = true;

                string js = "";
                js += "<script language='JavaScript'>";
                js += "window.open(' " + "../../Report/Jisseki_Report/Jisseki_Report_View.aspx" + "')";
                js += "</script>";

                Page.ClientScript.RegisterStartupScript(this.GetType(), "startup", js);



            }
            catch
            {
                
            }

        }

        #endregion
        protected void Gridview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnToNonReported_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.SERCH_NON_REPORTED);
        }

    }
}