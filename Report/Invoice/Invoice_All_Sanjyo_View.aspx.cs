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
    public partial class Invoice_All_Sanjyo_View : System.Web.UI.Page
    {
        private string strConn;

        private string getSqlAll_Sanjyo()
        {

            string Sql = " SELECT "
                //{乗(大) +  貨(大)　+ バス(大) }*216
                               + "I.CONAME as CONAME, H.MonthRep as MonthRep, "
                //乗(中小」) +  貨(中小)　+ バス(中小)
                               + "("
                               + " G.JK_J1 "
                               + "  + G.Kamotu1  + G.Kamotu2 +  G.Kamotu3 "
                               + "  + G.Bus1"
                               + " ) as Num_BigSize ,"
                //単価
                               + " U.BigSize as U_BigSize ,"
                               + "("
                               + " G.JK_J1 "
                               + " + G.Kamotu1  + G.Kamotu2 +  G.Kamotu3 "
                               + " + G.Bus1"
                               + " )*U.BigSize as Sum_BigSize, "


                               //{乗(中小」) +  貨(中小)　+ バス(中小) }
                               +
                               "("
                               + "	G.JK_J2+G.JK_J3 "
                               + " +	G.Kamotu4+G.JK_K1+G.JK_K2+G.JK_K3 "
                               + " + G.Bus2 "
                               + " ) as Num_MediumSmall ,"
                //単価
                               + " U.MediumSmall as U_MediumSmall ,"
                //{乗(中小」) +  貨(中小)　+ バス(中小) }*120
                               +
                               "("
                               + "	G.JK_J2+G.JK_J3 "
                               + " +	G.Kamotu4+G.JK_K1+G.JK_K2+G.JK_K3 "
                               + " + G.Bus2 "
                               + " )*U.MediumSmall as Sum_MediumSmall ,"
                               +



                               //均等割会費
                               " U.Average as U_Average,"

                               //7t以上
                               +
                               "(G.Kamotu1) as Num_Kamotu7t ,"
                               +
                               "U.Kamotu7t as U_Kamotu7t,"
                               +
                               "(G.Kamotu1)*U.Kamotu7t as  Sum_Kamotu7t     , "
                               +
                //6.9t~5t
                               "(G.Kamotu2) as  Num_Kamotu6DP9_5t  ,"
                               +
                               "U.[Kamotu6DP9_5t]  as U_Kamotu6DP9_5t , "
                               +
                               "(G.Kamotu2)*U.[Kamotu6DP9_5t] as Sum_Kamotu6DP9_5t  ,"


                               //4.9t~3t
                               +
                               " (G.Kamotu3) as Num_Kamotu4DP9_3t  ,"
                               +
                               " U.[Kamotu4DP9_3t] as U_Kamotu4DP9_3t  ,"
                               +
                               "(G.Kamotu3)*U.[Kamotu4DP9_3t] as Sum_Kamotu4DP9_3t, "


                               //2.9t~2.5t
                               +
                               "(G.Kamotu4) as Num_Kamotu2DP9_2DP5t  ,"
                               +
                               " U.[Kamotu2DP9_2DP5t] as U_Kamotu2DP9_2DP5t  ,"
                               +
                               "(G.Kamotu4)*U.[Kamotu2DP9_2DP5t] as Sum_Kamotu2DP9_2DP5t  ,"


                               //2,001cc
                               +
                               "(G.JK_J1) as Num_Over2001cc , "
                               +
                               "U.Over2001cc as U_Over2001cc , "
                               +
                               "(G.JK_J1)*U.Over2001cc as Sum_Over2001cc , "

                               //2,000cc~1000cc
                               +
                               "(G.JK_J2 + G.JK_J3 + G.JK_K1 + G.JK_K2 + G.JK_K3) as Num_To2000From1000cc ,"
                               +
                               "U.[To2000From1000cc] as U_To2000From1000cc ,"
                               +
                               "(G.JK_J2 + G.JK_J3 + G.JK_K1 + G.JK_K2 + G.JK_K3) * U.[To2000From1000cc] as Sum_To2000From1000cc ,"

                               //30
                               +
                               "(G.Bus1) as Num_Over30 ,"
                               +
                               "U.Over30 as U_Over30 ,"
                               +
                               "(G.Bus1)*U.Over30 as Sum_Over30 ,"

                               //20
                               +
                               "(G.Bus2 ) as Num_LessThan29 , "
                               +
                               "U.LessThan29 as U_LessThan29 , "
                               +
                               "(G.Bus2 )*U.LessThan29 as Sum_LessThan29 , "
                               +
                               "U.MemberFee  as U_MemberFee "
                                  + " FROM "
                                  + "  [Prt_Invoice_S_Jisseki_Header]  H "
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
                                  + " INNER JOIN UnitPrice U "
                                  + " ON H.COCODE =  U.COCODE ";

            return Sql;

        }
        
        private void runInvoiceSanjyoAll()
        {

            ActiveReport rpt = new InvoiceSanjyo();

            // レポートを作成します。
            //try
            //{

            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = getSqlAll_Sanjyo();
                    cmd.Connection = Conn;

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

            //}
            //catch (DataDynamics.ActiveReports.ReportException eRunReport)
            //{
            //    // レポートの作成に失敗した場合、クライアントにエラーメッセージを表示します。
            //    Response.Clear();
            //    Response.Write("<h1>レポート生成時にエラーが発生しました。</h1>");
            //    Response.Write("<font face=\"MS UI Gothic\">" + eRunReport.ToString() + "</font>");
            //    return;
            //}

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

        protected void Page_Load(object sender, EventArgs e)
        {
         try { 
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }
            //接続文字列
            strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;


            //賛助会員
            this.runInvoiceSanjyoAll();


         }
         catch
         {

         }

      }
    }
}