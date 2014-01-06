using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using Jisseki_Report_Ibaraki.Tools;

namespace Jisseki_Report_Ibaraki.jada.download
{
    public partial class Jisseki_Report : System.Web.UI.Page
    {

        private string strConn;
        //TODO　パスとファイルをデータベースか設定ファイルに
        string DownloadWritePath;
        string DownloadFileName ;
        
        public string getSql()
        { 
            
                string Sql = " SELECT  "
                            //Header and ID Master
                           + " H.COCODE as COCODE, I.CONAME as CONAME , H.YearRep as YearRep , H.MonthRep as MonthRep "
                            //Mito
                           + " , M.Kamotu1 as M_Kamotu1, M.Kamotu2 as M_Kamotu2, M.Kamotu3 as M_Kamotu3 , M.Kamotu4 as M_Kamotu4  "
                           + " , M.Bus1 as M_Bus1, M.Bus2 as M_Bus2 "
                           + " , M.JK_J1 as M_JK_J1  , M.JK_K1 as M_JK_K1 , M.JK_J2 as M_JK_J2 , M.JK_K2   as M_JK_K2 , M.JK_J3   as M_JK_J3 , M.JK_K3   as M_JK_K3 "
                           + " , M.SubTotal1 as M_SubTotal1 , M.Total1 as M_Total1 "

                           //Tuchiura	  
                           + " , TC.Kamotu1 as TC_Kamotu1, TC.Kamotu2 as TC_Kamotu2, TC.Kamotu3 as TC_Kamotu3 , TC.Kamotu4 as TC_Kamotu4  "
                           + " , TC.Bus1 as TC_Bus1, TC.Bus2 as TC_Bus2 "
                           + " , TC.JK_J1 as TC_JK_J1  , TC.JK_K1 as TC_JK_K1 , TC.JK_J2 as TC_JK_J2 , TC.JK_K2   as TC_JK_K2 , TC.JK_J3   as TC_JK_J3 , TC.JK_K3   as TC_JK_K3 "
                           + " , TC.SubTotal1 as TC_SubTotal1 , TC.Total1 as TC_Total1 "

                           //Tukuba
                           + " , TK.Kamotu1 as TK_Kamotu1, TK.Kamotu2 as TK_Kamotu2, TK.Kamotu3 as TK_Kamotu3 , TK.Kamotu4 as TK_Kamotu4  "
                           + " , TK.Bus1 as TK_Bus1, TK.Bus2 as TK_Bus2 "
                           + " , TK.JK_J1 as TK_JK_J1  , TK.JK_K1 as TK_JK_K1 , TK.JK_J2 as TK_JK_J2 , TK.JK_K2   as TK_JK_K2 , TK.JK_J3   as TK_JK_J3 , TK.JK_K3   as TK_JK_K3 "
                           + " , TK.SubTotal1 as TK_SubTotal1 , TK.Total1 as TK_Total1 "

                           //Sonota
                           + " , S.Kamotu1 as S_Kamotu1, S.Kamotu2 as S_Kamotu2, S.Kamotu3 as S_Kamotu3 , S.Kamotu4 as S_Kamotu4  "
                           + " , S.Bus1 as S_Bus1, S.Bus2 as S_Bus2 "
                           + " , S.JK_J1 as S_JK_J1  , S.JK_K1 as S_JK_K1 , S.JK_J2 as S_JK_J2 , S.JK_K2   as S_JK_K2 , S.JK_J3   as S_JK_J3 , S.JK_K3   as S_JK_K3 "
                           + " , S.SubTotal1 as S_SubTotal1 , S.Total1 as S_Total1 "


                           //Goukei
                           + " , G.Kamotu1 as G_Kamotu1, G.Kamotu2 as G_Kamotu2, G.Kamotu3 as G_Kamotu3 , G.Kamotu4 as G_Kamotu4  "
                           + " , G.Bus1 as G_Bus1, G.Bus2 as G_Bus2 "
                           + " , G.JK_J1 as G_JK_J1  , G.JK_K1 as G_JK_K1 , G.JK_J2 as G_JK_J2 , G.JK_K2   as G_JK_K2 , G.JK_J3   as G_JK_J3 , G.JK_K3   as G_JK_K3 "
                           + " , G.SubTotal1 as G_SubTotal1 , G.Total1 as G_Total1 "

                           //ポジション追加
                           + " , I.Position as Position "

                           + " FROM "
                           + "  [Jisseki_Header]  H "
                           + " INNER JOIN  "
                           + "   [Jisseki_Mito]   M "
                           + " ON H.COCODE = M.COCODE AND H.YearRep = M.YearRep AND H.MonthRep = M.MonthRep "
                           + " INNER JOIN "
                           + "  [Jisseki_Tuchiura]   TC "
                           + " ON H.COCODE = TC.COCODE AND H.YearRep = TC.YearRep AND H.MonthRep = TC.MonthRep "
                           + "  INNER JOIN "
                           + "   [Jisseki_Tukuba]   TK "
                           + " ON H.COCODE = TK.COCODE AND H.YearRep = TK.YearRep AND H.MonthRep = TK.MonthRep "
                           + "  INNER JOIN "
                           + "   [Jisseki_Sonota]   S "
                           + " ON H.COCODE = S.COCODE AND H.YearRep = S.YearRep AND H.MonthRep = S.MonthRep "
                           + "  INNER JOIN "
                           + "   [Jisseki_Goukei]   G "
                           + " ON H.COCODE = G.COCODE AND H.YearRep = G.YearRep AND H.MonthRep = G.MonthRep "
                           + "  INNER JOIN "
                           + "   [ID]   I "
                           + " ON H.COCODE = I.COCODE "
                           + " WHERE "
                           + " I.Member = 1 "//会員のみ(念のため)
                           + " AND "           
                           + " H.YearRep = @YearRep "
                           + " AND "           
                           + " H.MonthRep = @MonthRep ";

            return Sql;

        }

        private bool writeData(string Sql , string qYearRep, string qMonthRep)
        {
            //using (SqlConnection Conn = new SqlConnection(strConn))
            //{
            SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, Conn);

                cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    string CsvLine = string.Empty;
                    using (StreamWriter Writer = new StreamWriter(DownloadWritePath + DownloadFileName, false, Encoding.Default))
                    {

                        //ヘッダーを書き出す
                        Writer.Write("COCODE, CONAME, YearRep, MonthRep,");
                        //Mito
                        Writer.Write("M_Kamotu1,M_Kamotu2,M_Kamotu3,M_Kamotu4,M_Bus1,M_Bus2,");
                        Writer.Write("M_JK_J1,M_JK_K1,M_JK_J2,M_JK_K2,M_JK_J3,M_JK_K3,");
                        Writer.Write("M_SubTotal1,M_Total1,");
                        //Tuchiura
                        Writer.Write("TC_Kamotu1,TC_Kamotu2,TC_Kamotu3,TC_Kamotu4,TC_Bus1,TC_Bus2,");
                        Writer.Write("TC_JK_J1,TC_JK_K1,TC_JK_J2,TC_JK_K2,TC_JK_J3,TC_JK_K3,");
                        Writer.Write("TC_SubTotal1,TC_Total1,");
                        //Tukuba
                        Writer.Write("TK_Kamotu1,TK_Kamotu2,TK_Kamotu3,TK_Kamotu4,TK_Bus1,TK_Bus2,");
                        Writer.Write("TK_JK_J1,TK_JK_K1,TK_JK_J2,TK_JK_K2,TK_JK_J3,TK_JK_K3,");
                        Writer.Write("TK_SubTotal1,TK_Total1,");
                        //Sonota
                        Writer.Write("S_Kamotu1,S_Kamotu2,S_Kamotu3,S_Kamotu4,S_Bus1,S_Bus2,");
                        Writer.Write("S_JK_J1,S_JK_K1,S_JK_J2,S_JK_K2,S_JK_J3,S_JK_K3,");
                        Writer.Write("S_SubTotal1,S_Total1,");
                        //Goukei
                        Writer.Write("G_Kamotu1,G_Kamotu2,G_Kamotu3,G_Kamotu4,G_Bus1,G_Bus2,");
                        Writer.Write("G_JK_J1,G_JK_K1,G_JK_J2,G_JK_K2,G_JK_J3,G_JK_K3,");
                        Writer.WriteLine("G_SubTotal1,G_Total1,Position");




                        while (Reader.Read())
                        {
                            //TODO NULLのとき

                            //Header
                            CsvLine = Reader["COCODE"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["CONAME"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["YearRep"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["MonthRep"].ToString();
                            CsvLine += ",";

                            //Mito
                            CsvLine += Reader["M_Kamotu1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Kamotu2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Kamotu3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Kamotu4"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Bus1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Bus2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_J1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_K1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_J2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_K2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_J3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_JK_K3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_SubTotal1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["M_Total1"].ToString();
                            CsvLine += ",";

                            //Tuchiura
                            CsvLine += Reader["TC_Kamotu1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Kamotu2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Kamotu3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Kamotu4"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Bus1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Bus2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_J1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_K1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_J2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_K2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_J3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_JK_K3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_SubTotal1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TC_Total1"].ToString();
                            CsvLine += ",";

                            //Tukuba
                            CsvLine += Reader["TK_Kamotu1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Kamotu2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Kamotu3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Kamotu4"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Bus1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Bus2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_J1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_K1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_J2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_K2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_J3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_JK_K3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_SubTotal1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["TK_Total1"].ToString();
                            CsvLine += ",";

                            //Sonota
                            CsvLine += Reader["S_Kamotu1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Kamotu2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Kamotu3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Kamotu4"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Bus1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Bus2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_J1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_K1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_J2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_K2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_J3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_JK_K3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_SubTotal1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["S_Total1"].ToString();
                            CsvLine += ",";

                            //Goukei
                            CsvLine += Reader["G_Kamotu1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Kamotu2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Kamotu3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Kamotu4"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Bus1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Bus2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_J1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_K1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_J2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_K2"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_J3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_JK_K3"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_SubTotal1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["G_Total1"].ToString();
                            CsvLine += ",";
                            CsvLine += Reader["Position"].ToString();
                            Writer.WriteLine(CsvLine);

                        }

                        Writer.Close();
                        return true;

                    }
                }
                else
                {
                     return false;
                    
                }
        
        }

        private void outData() {
            //Response.CleaarContent();
            Response.ContentType = "text/csv";//Defined in RFC4180 
            Response.AddHeader("Content-Disposition", "Attachment;filename=" + HttpUtility.UrlEncode(DownloadFileName));
            Response.WriteFile(DownloadWritePath + DownloadFileName);
            Response.End();

        }
#region "イベント"
        protected void Page_Load(object sender, EventArgs e)
        {
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }


            //接続文字列
            strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;
            DownloadWritePath = ConfigurationManager.AppSettings["DownloadWritePath"].ToString();

            JapaneseCalendar jCalender = new JapaneseCalendar();
            if (Page.IsPostBack)
            {
                //No28




            }
            else
            {

                //初期表示のみ
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
                //20130106                
                //1月のときは、昨年度
                if (DateTime.Today.Month == 1) {
                    this.txtYearRep.Text = jCalender.GetYear(DateTime.Today.AddYears(-1)).ToString();
                    this.txtMonthRep.Text = Utility.covertDigit2(DateTime.Today.AddMonths(-1).Month);

                }
                else 
                {
                    this.txtYearRep.Text = jCalender.GetYear(DateTime.Today).ToString();
                    this.txtMonthRep.Text = Utility.covertDigit2(DateTime.Today.AddMonths(-1).Month);

                }
                
                //string strYearMonthDay = (jCalender.GetYear(DateTime.Today).ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString());
                string strYearMonthDay = (DateTime.Today.Year.ToString() + Utility.covertDigit2(DateTime.Today.Month) + Utility.covertDigit2(DateTime.Today.Day));
                string strHourMinSec = (Utility.covertDigit2(DateTime.Now.Hour) + Utility.covertDigit2(DateTime.Now.Minute) + Utility.covertDigit2(DateTime.Now.Second));
                this.txtFileName.Text = Utility.HeiseiToChristianEra(this.txtYearRep.Text) + this.txtMonthRep.Text + "Jisseki" + strYearMonthDay + strHourMinSec + ".csv";


            }

        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                //入力チェック
                //TODO::JavaScriptでも
                if (this.txtYearRep.Text.Trim() == string.Empty)
                {
                    lblMsg.Text = "ダウンロードする実績報告書の年月を入力してください。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    lblMsg.Text = "";
                }

                if (this.txtMonthRep.Text.Trim() == string.Empty)
                {
                    lblMsg.Text = "ダウンロードする実績報告書の年月を入力してください。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    lblMsg.Text = "";
                }


                if (this.txtFileName.Text.Trim() == string.Empty)
                {
                    lblMsg.Text = "ファイル名を入力してください。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    lblMsg.Text = "";
                }

                //
                DownloadFileName = this.txtFileName.Text.Trim();

                //TODO::CSVファイルのディレクトリ、ファイルの存在チェック
                if (!Directory.Exists(this.DownloadWritePath))
                {
                    lblMsg.Text = "ディレクトリが存在しません。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else
                {
                    lblMsg.Text = "";
                }



                if (!File.Exists(this.DownloadWritePath + this.DownloadFileName))
                {
                    //            lblMsg.Text = "ファイル存在しません。";
                    using (File.Create(this.DownloadWritePath + this.DownloadFileName)) { };



                    //            return;

                }


                //SELECT
                //Key項目で結合
                string qYearRep = Utility.HeiseiToChristianEra(this.txtYearRep.Text);
                string qMonthRep = this.txtMonthRep.Text;

                //ファイルを作る
                string Sql = getSql();
                if (!this.writeData(Sql, qYearRep, qMonthRep))
                {
                    this.lblMsg.Text = "ダウンロードデータがありませんでした。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    //20130106
                    //ﾃﾞｰﾀがないとき
                    return;
                };

                //クライアントへ返す
                this.outData();

            }
            catch { 
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
#endregion
    }
}