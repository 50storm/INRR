using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Jisseki_Report_Ibaraki.Tools;

using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Export.Pdf;


namespace Jisseki_Report_Ibaraki.Report
{
    public partial class Jisseki_Report_View : System.Web.UI.Page
    {
        private string strConn;


        public string getSql()
        {

            string Sql = " SELECT  "
                     //Header and ID Master
                       + " H.COCODE as COCODE, I.CONAME as CONAME,H.TANTOU as TANTOU, H.YearRep as YearRep , H.MonthRep as MonthRep "
                       + " , H.Year as Year , H.Month as Month , H.Day as Day "
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
                       + " H.COCODE = @COCODE "
                       + " AND " 
                       + " H.YearRep = @YearRep "
                       + " AND "
                       + " H.MonthRep = @MonthRep ";

            return Sql;

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

            ActiveReport rpt = new Jisseki_Report();
           
            // レポートを作成します。
            try
            {

                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = getSql();
                        cmd.Connection = Conn;

                        //セッションで渡すとき
                        cmd.Parameters.Add(new SqlParameter("@COCODE", this.Session["Jisseki_Report_COCODE"].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@YearRep", this.Session["Jisseki_Report_YearRep"].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@MonthRep", this.Session["Jisseki_Report_MonthRep"].ToString()));

                        using (SqlDataAdapter Adapter = new SqlDataAdapter())
                        {
                            Adapter.SelectCommand = cmd;
                            DataTable dt = new DataTable();
                            Adapter.Fill(dt);
                            rpt.DataSource = dt;

                            rpt.Run(false);
                        }
                    }
                }

            }
            catch (DataDynamics.ActiveReports.ReportException eRunReport)
            {
                // レポートの作成に失敗した場合、クライアントにエラーメッセージを表示します。
                Response.Clear();
                Response.Write("<h1>レポート生成時にエラーが発生しました。</h1>");
                Response.Write("<font face=\"MS UI Gothic\">" + eRunReport.ToString() + "</font>");
                return;
            }

            //以下はサンプルコードをそのまま流用。

            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();

            //  ブラウザに対してPDFドキュメントの適切なビューワを使用するように指定します。
            Response.ContentType = "application/pdf";

            Response.AddHeader("content-disposition", "inline; filename=MyPDF.PDF");
            // 次のコードに置き換えると新しいウィンドウを開きます：
            // Response.AddHeader("content-disposition","attachment; filename=MyPDF.PDF");

            // PDFエクスポートクラスのインスタンスを作成します。
            PdfExport pdf = new PdfExport();

            // PDFの出力用のメモリストリームを作成します。
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();

            // メモリストリームにPDFエクスポートを行います。
            pdf.Export(rpt.Document, memStream);

            // 出力ストリームにPDFのストリームを出力します。
            Response.BinaryWrite(memStream.ToArray());

            // バッファリングされているすべての内容をクライアントへ送信します。
            Response.End();


        }
    }
}