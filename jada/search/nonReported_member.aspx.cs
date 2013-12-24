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
using Jisseki_Report_Ibaraki.Tools;

namespace Jisseki_Report_Ibaraki.jada.search
{
    public partial class nonReported_member : System.Web.UI.Page
    {
        //接続文字列
        private String strConn;

        private const int GV_INDEX_会員コード = 0;
        private const int GV_INDEX_会員名 = 1;
        private const int GV_INDEX_代表者 = 2;
        private const int GV_INDEX_電話番号 = 3;
        private const int GV_INDEX_登録 = 4;

        private void showData() {
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

                cmd.Parameters.Add(new SqlParameter("@YearRep",Utility.HeiseiToChristianEra(this.txtYearRep.Text)));
                cmd.Parameters.Add(new SqlParameter("@MonthRep", this.txtMonthRep.Text));


                using (SqlDataAdapter Adapter = new SqlDataAdapter(strSql, Conn))
                {
                    Adapter.SelectCommand = cmd;
                    DataTable header = new DataTable("新車台数ヘッダー");
                    Adapter.Fill(header);

                    if (header.Rows.Count == 0)
                    {
                        Gridview1.DataSource = header;
                        Gridview1.DataBind();
                        lblMsg.Text = "未受信データはありません。";
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

            if (Page.IsPostBack) {
            
            } 
            else 
            {
                JapaneseCalendar jCalender = new JapaneseCalendar();

                this.txtYearRep.Text = jCalender.GetYear(DateTime.Today).ToString();
                this.txtMonthRep.Text = DateTime.Today.AddMonths(-1).Month.ToString();
            }
            

       
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                //必須チェック
                if (this.txtYearRep.Text.Trim() == string.Empty) {
                    this.txtYearRep.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtYearRep.BackColor = System.Drawing.Color.White;
                }

                if (this.txtMonthRep.Text.Trim() == string.Empty)
                {
                    this.txtMonthRep.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.txtMonthRep.BackColor = System.Drawing.Color.White;
                } 

                //数字チェック
                if (Utility.IsNotNumber(this.txtYearRep.Text))
                {
                    this.txtYearRep.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtYearRep.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtMonthRep.Text))
                {
                    this.txtMonthRep.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    this.txtMonthRep.BackColor = System.Drawing.Color.White;
                }

                //月範囲チェック。
                //誤って1～１２月以外で登録されたらいやなので。
                int ret=0;
                int.TryParse(this.txtMonthRep.Text, out ret);
                if (1 <= ret && ret <= 12){
                    //OK
                    this.txtMonthRep.BackColor = System.Drawing.Color.White;
                }else{
                    this.txtMonthRep.BackColor = System.Drawing.Color.Pink;
                    return;
                }

                this.showData();
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
            catch { 
            
            }
        }

   
        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //リダイレクトで渡す
            try
            {
                //画面の年月
                this.Session["YearRep"] = this.txtYearRep.Text.Trim();
                this.Session["MonthRep"] = this.txtMonthRep.Text.Trim();

                //会社コード
                int rowIndex = Convert.ToInt16(e.CommandArgument);
                GridView gridView = (GridView)e.CommandSource;
                GridViewRow row = gridView.Rows[rowIndex];
                this.Session["COCODE_MEMBER"] = row.Cells[0].Text;
                Response.Redirect(URL.INPUT_JISSEKI);
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