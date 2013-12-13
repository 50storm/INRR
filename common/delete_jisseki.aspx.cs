using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Igarashi
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Globalization;
using System.Net;
using Jisseki_Report_Ibaraki.Tools;

//using System.Transactions;//エラー


namespace Jisseki_Report_Ibaraki.common
{
    public partial class delete_jisseki : System.Web.UI.Page
    {
        //メンバ
        //接続文字列
        private String strConn;

        private bool jadaUser;

        private String qCOCODE;
        private String qYearRep;
        private String qMonthRep;

        private void setHeaderForJada()
        {
            string SqlHeader =
                " SELECT H.COCODE AS COCODE, "
                + "      H.Year AS Year ,"
                + "      H.Month AS Month ,"
                + "      H.Day AS Day ,"
                + "      H.YearRep AS YearRep ,"
                + "      H.MonthRep AS MonthRep ,"
                + "      H.TANTOU AS TANTOU  ,"
                + "      I.CONAME AS CONAME  "
                + " FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header] H "
                + " INNER JOIN  [Jisseki_Report_Ibaraki].[dbo].[ID] I"
                + " ON H.COCODE = I.COCODE "
                + " WHERE H.COCODE=@COCODE AND H.YearRep = @YearRep AND H.MonthRep = @MonthRep ";//TODO

            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlHeader, Conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //Convert Christian Era To  Japanese Era
                        DateTime JapaneseDate = DateTime.Parse(
                                                Reader["Year"].ToString()
                                                + "/" + Reader["Month"].ToString()
                                                + "/" + Reader["Day"].ToString()
                                               );
                        JapaneseCalendar jCalender = new JapaneseCalendar();
                        this.lblEra.Text = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                        this.lblEraRep0.Text = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                        this.txtYear.Text = jCalender.GetYear(JapaneseDate).ToString();
                        this.txtYearRep0.Text = jCalender.GetYear(JapaneseDate).ToString();
                        this.txtMonth.Text = Reader["Month"].ToString();
                        this.txtMonthRep0.Text = Reader["MonthRep"].ToString();
                        this.txtDay.Text = Reader["Day"].ToString();
                        this.txtSyamei.Text = Reader["CONAME"].ToString();
                        this.txtTantou.Text = Reader["TANTOU"].ToString();

                    }
                }
                Conn.Close();
            }

        }


        /// <summary>
        /// setHeader
        /// </summary>
        private void setHeader()
        {
            //初期表示
            string SqlHeader =
                " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header]  "
                + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";

            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlHeader, Conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //Convert Christian Era To  Japanese Era
                        DateTime JapaneseDate = DateTime.Parse(
                                                Reader["Year"].ToString()
                                                + "/" + Reader["Month"].ToString()
                                                + "/" + Reader["Day"].ToString()
                                               );
                        JapaneseCalendar jCalender = new JapaneseCalendar();
                        this.lblEra.Text = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                        this.lblEraRep0.Text = Utility.getJapaneseEra(jCalender.GetEra(JapaneseDate));
                        this.txtYear.Text = jCalender.GetYear(JapaneseDate).ToString();
                        this.txtYearRep0.Text = jCalender.GetYear(JapaneseDate).ToString();
                      
                        this.txtMonth.Text = Reader["Month"].ToString();
                        this.txtMonthRep0.Text = Reader["MonthRep"].ToString();
                        this.txtDay.Text = Reader["Day"].ToString();
                        this.txtSyamei.Text = Session["CONAME"].ToString();
                        this.txtTantou.Text = Reader["TANTOU"].ToString();

                    }
                }
                Conn.Close();
            }



        }

        /// <summary>
        /// setMitoData
        /// </summary>
        private void setMito()
        {
            string SqlMito =
                    " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Mito]  "
                    + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlMito, Conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //this.txtMito_Kamotu1.Text = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtMito_Kamotu2.Text = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtMito_Kamotu3.Text = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtMito_Kamotu4.Text = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtMito_Bus1.Text = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtMito_Bus2.Text = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtMito_JK_J1.Text = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtMito_JK_K1.Text = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtMito_JK_J2.Text = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtMito_JK_K2.Text = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtMito_JK_J3.Text = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtMito_JK_K3.Text = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtMito_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtMito_Total1.Text = Utility.zeroToSpace(Reader["Total1"].ToString());



                        this.txtMito_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtMito_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtMito_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtMito_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtMito_Bus1.Text = Reader["Bus1"].ToString();
                        this.txtMito_Bus2.Text = Reader["Bus2"].ToString();
                        this.txtMito_JK_J1.Text = Reader["JK_J1"].ToString();
                        this.txtMito_JK_K1.Text = Reader["JK_K1"].ToString();
                        this.txtMito_JK_J2.Text = Reader["JK_J2"].ToString();
                        this.txtMito_JK_K2.Text = Reader["JK_K2"].ToString();
                        this.txtMito_JK_J3.Text = Reader["JK_J3"].ToString();
                        this.txtMito_JK_K3.Text = Reader["JK_K3"].ToString();
                        this.txtMito_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtMito_Total1.Text = Reader["Total1"].ToString();


                    }
                }
                Conn.Close();
            }

        }

        /// <summary>
        /// setTuchiuraData
        /// </summary>
        private void setTuchiura()
        {
            string SqlTuchiura =
                    " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tuchiura]  "
                    + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlTuchiura, Conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //this.txtTuchiura_Kamotu1.Text = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtTuchiura_Kamotu2.Text = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtTuchiura_Kamotu3.Text = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtTuchiura_Kamotu4.Text = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtTuchiura_Bus1.Text = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtTuchiura_Bus2.Text = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtTuchiura_JK_J1.Text = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtTuchiura_JK_K1.Text = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtTuchiura_JK_J2.Text = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtTuchiura_JK_K2.Text = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtTuchiura_JK_J3.Text = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtTuchiura_JK_K3.Text = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtTuchiura_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtTuchiura_Total1.Text = Utility.zeroToSpace(Reader["Total1"].ToString());

                        this.txtTuchiura_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtTuchiura_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtTuchiura_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtTuchiura_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtTuchiura_Bus1.Text = Reader["Bus1"].ToString();
                        this.txtTuchiura_Bus2.Text = Reader["Bus2"].ToString();
                        this.txtTuchiura_JK_J1.Text =Reader["JK_J1"].ToString();
                        this.txtTuchiura_JK_K1.Text =Reader["JK_K1"].ToString();
                        this.txtTuchiura_JK_J2.Text =Reader["JK_J2"].ToString();
                        this.txtTuchiura_JK_K2.Text =Reader["JK_K2"].ToString();
                        this.txtTuchiura_JK_J3.Text =Reader["JK_J3"].ToString();
                        this.txtTuchiura_JK_K3.Text =Reader["JK_K3"].ToString();
                        this.txtTuchiura_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtTuchiura_Total1.Text = Reader["Total1"].ToString();


                    }
                }
                Conn.Close();
            }

        }

        /// <summary>
        /// setTukubaData
        /// </summary>
        private void setTukuba()
        {
            string SqlTukuba =
                    " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tukuba]  "
                //+ " WHERE COCODE=@COCODE AND Year = @Year AND Month = @Month AND Day = @Day";
                    + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlTukuba, Conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //this.txtTukuba_Kamotu1.Text = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtTukuba_Kamotu2.Text = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtTukuba_Kamotu3.Text = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtTukuba_Kamotu4.Text = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtTukuba_Bus1.Text = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtTukuba_Bus2.Text = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtTukuba_JK_J1.Text = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtTukuba_JK_K1.Text = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtTukuba_JK_J2.Text = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtTukuba_JK_K2.Text = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtTukuba_JK_J3.Text = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtTukuba_JK_K3.Text = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtTukuba_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtTukuba_Total1.Text = Utility.zeroToSpace(Reader["Total1"].ToString());


                        this.txtTukuba_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtTukuba_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtTukuba_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtTukuba_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtTukuba_Bus1.Text = Reader["Bus1"].ToString();
                        this.txtTukuba_Bus2.Text = Reader["Bus2"].ToString();
                        this.txtTukuba_JK_J1.Text = Reader["JK_J1"].ToString();
                        this.txtTukuba_JK_K1.Text = Reader["JK_K1"].ToString();
                        this.txtTukuba_JK_J2.Text = Reader["JK_J2"].ToString();
                        this.txtTukuba_JK_K2.Text = Reader["JK_K2"].ToString();
                        this.txtTukuba_JK_J3.Text = Reader["JK_J3"].ToString();
                        this.txtTukuba_JK_K3.Text = Reader["JK_K3"].ToString();
                        this.txtTukuba_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtTukuba_Total1.Text = Reader["Total1"].ToString();

                    }
                }
                Conn.Close();
            }

        }

        /// <summary>
        /// setSonotaData
        /// </summary>
        private void setSonota()
        {
            string SqlSonota =
                    " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Sonota]  "
                    + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlSonota, Conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //this.txtSonota_Kamotu1.Text = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtSonota_Kamotu2.Text = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtSonota_Kamotu3.Text = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtSonota_Kamotu4.Text = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtSonota_Bus1.Text = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtSonota_Bus2.Text = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtSonota_JK_J1.Text = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtSonota_JK_K1.Text = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtSonota_JK_J2.Text = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtSonota_JK_K2.Text = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtSonota_JK_J3.Text = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtSonota_JK_K3.Text = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtSonota_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtSonota_Total1.Text = Utility.zeroToSpace(Reader["Total1"].ToString());

                        this.txtSonota_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtSonota_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtSonota_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtSonota_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtSonota_Bus1.Text = Reader["Bus1"].ToString();
                        this.txtSonota_Bus2.Text = Reader["Bus2"].ToString();
                        this.txtSonota_JK_J1.Text = Reader["JK_J1"].ToString();
                        this.txtSonota_JK_K1.Text = Reader["JK_K1"].ToString();
                        this.txtSonota_JK_J2.Text = Reader["JK_J2"].ToString();
                        this.txtSonota_JK_K2.Text = Reader["JK_K2"].ToString();
                        this.txtSonota_JK_J3.Text = Reader["JK_J3"].ToString();
                        this.txtSonota_JK_K3.Text = Reader["JK_K3"].ToString();
                        this.txtSonota_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtSonota_Total1.Text = Reader["Total1"].ToString();

                    }
                }
                Conn.Close();
            }

        }

        /// <summary>
        /// setGoukeiData
        /// </summary>
        private void setGoukei()
        {
            string SqlGoukei =
                    " SELECT * FROM [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Goukei]  "
                    + " WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlGoukei, Conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                    cmd.Parameters.Add(new SqlParameter("@YearRep", qYearRep));
                    cmd.Parameters.Add(new SqlParameter("@MonthRep", qMonthRep));
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        Reader.Read();
                        //this.txtGoukei_Kamotu1.Text = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtGoukei_Kamotu2.Text = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtGoukei_Kamotu3.Text = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtGoukei_Kamotu4.Text = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtGoukei_Bus1.Text = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtGoukei_Bus2.Text = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtGoukei_JK_J1.Text = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtGoukei_JK_K1.Text = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtGoukei_JK_J2.Text = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtGoukei_JK_K2.Text = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtGoukei_JK_J3.Text = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtGoukei_JK_K3.Text = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtGoukei_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtGoukei_Total1.Text = Utility.zeroToSpace(Reader["Total1"].ToString());

                        this.txtGoukei_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtGoukei_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtGoukei_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtGoukei_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtGoukei_Bus1.Text = Reader["Bus1"].ToString();
                        this.txtGoukei_Bus2.Text = Reader["Bus2"].ToString();
                        this.txtGoukei_JK_J1.Text = Reader["JK_J1"].ToString();
                        this.txtGoukei_JK_K1.Text = Reader["JK_K1"].ToString();
                        this.txtGoukei_JK_J2.Text = Reader["JK_J2"].ToString();
                        this.txtGoukei_JK_K2.Text = Reader["JK_K2"].ToString();
                        this.txtGoukei_JK_J3.Text = Reader["JK_J3"].ToString();
                        this.txtGoukei_JK_K3.Text = Reader["JK_K3"].ToString();
                        this.txtGoukei_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtGoukei_Total1.Text = Reader["Total1"].ToString();


                    }
                }
                Conn.Close();
            }

        }




        /// <summary>
        /// InitializeForm
        /// </summary>
        private void initializeForm() {
            if (jadaUser) 
            {
                this.setHeaderForJada();
                //this.linkMenu.NavigateUrl = URL.MENU_JADA;
  
            }
            else
            {
                this.setHeader();
                //this.linkMenu.NavigateUrl = URL.MENU_DEALER;
            
            }
            this.setMito();
            this.setTuchiura();
            this.setTukuba();
            this.setSonota();
            this.setGoukei();
            
            //Key項目
            //EnableをFalse
            //Key項目
            //EnableをFalse
            this.txtYearRep0.Enabled = false;
            this.txtMonthRep0.Enabled = false;

            this.txtYear.Enabled = false;
            this.txtMonth.Enabled = false;
            this.txtDay.Enabled = false;

            this.txtSyamei.Enabled = false;


        }


        private void deleteAll(SqlConnection Conn, SqlTransaction Tran)
        {
            String DeleteAll = "DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                               + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Mito] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                               + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tuchiura] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                               + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tukuba] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                               + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Sonota] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                               + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Goukei] "
                               + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep "
                                ;
            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(DeleteAll, Conn, Tran);
                cmd.CommandText = DeleteAll;
                //Sqlインジェクション回避
                //キー項目
                if (jadaUser)
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", qCOCODE));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", Session["COCODE"].ToString()));
                }
                cmd.Parameters.Add(new SqlParameter("@YearRep", Utility.HeiseiToChristianEra(txtYearRep0.Text)));
                cmd.Parameters.Add(new SqlParameter("@MonthRep", txtMonthRep0.Text));
                cmd.Parameters.Add(new SqlParameter("@TANTOU", txtTantou.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            try{
                 //ログインしていなければ表示しない
                 if (Session["COCODE"] == null) {
                     Response.Redirect(URL.LOGIN_DEALER);          
                 }

                 if (Session["Member"].ToString().Trim() == "1")
                 { //TODO自販連ユーザーと振り分け
                     //会員
                     jadaUser = false;
                 }
                 else
                 {
                     //自販連
                     jadaUser = true;

                 }

                 //接続文字列
                 strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;

                 //Receive Keys by GET
                 qCOCODE = Page.Request.QueryString.Get("COCODE");
                 qYearRep = Page.Request.QueryString.Get("YearRep");
                 qMonthRep = Page.Request.QueryString.Get("MonthRep");
               //  Response.Write(qYear);
               //  Response.Write(qMonth);
          

                 if (!Page.IsPostBack)
                 {
                     initializeForm();
                     //会員の場合閉め日を過ぎてたら修正できないようにする
                     if (!jadaUser)
                     {
                         if (DateTime.Today.Day < 6)
                         {
                             //前の月で取得
                             if (DateTime.Today.AddMonths(-1).Month > int.Parse(qMonthRep))
                             {

                                 this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                 this.btnSubmit.Enabled = false;
                             }
                         }
                         else
                         {
                             //1～11月
                             if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 11)
                             {
                                 if (DateTime.Today.Month > int.Parse(qMonthRep))
                                 {
                                     this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                     this.btnSubmit.Enabled = false;
                                 }
                             }
                             else
                             {
                                 //12月
                                 if (DateTime.Today.Month < int.Parse(qMonthRep))
                                 {
                                     this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                     this.btnSubmit.Enabled = false;
                                 }
                             }
                         }
                     }
                 }
                 ////一ヶ月過ぎてたら削除できないようにする
                 //入力しない箇所の色対応
                 this.txtGoukei_Kamotu1.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Kamotu2.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Kamotu3.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Kamotu4.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Bus1.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Bus2.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_J1.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_J2.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_J3.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_K1.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_K2.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_JK_K3.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_SubTotal1.BackColor = System.Drawing.Color.Silver;
                 this.txtGoukei_Total1.BackColor = System.Drawing.Color.Silver;

                 this.txtMito_SubTotal1.BackColor = System.Drawing.Color.Silver;
                 this.txtMito_Total1.BackColor = System.Drawing.Color.Silver;

                 this.txtTuchiura_SubTotal1.BackColor = System.Drawing.Color.Silver;
                 this.txtTuchiura_Total1.BackColor = System.Drawing.Color.Silver;

                 this.txtTukuba_SubTotal1.BackColor = System.Drawing.Color.Silver;
                 this.txtTukuba_Total1.BackColor = System.Drawing.Color.Silver;

                 this.txtSonota_SubTotal1.BackColor = System.Drawing.Color.Silver;
                 this.txtSonota_Total1.BackColor = System.Drawing.Color.Silver;


           }catch{
           
           }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //入力チェック
            try
            {
                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlTransaction Tran = Conn.BeginTransaction())
                    {
                        try
                        {
                            //delete All related records
                            this.deleteAll(Conn,Tran);

                            //Commit Transaction
                            Tran.Commit();
                            this.btnSubmit.Enabled = false;
                            this.lblMsg.Text = "削除しました";
                            this.lblMsg.BackColor = System.Drawing.Color.Pink;
                            //btnSubmit.Enabled = false;
                        }
                        catch
                        {
                            //Rollback Transaction
                            Tran.Rollback();
                            throw ;
                           
                        }
                     
                    }
                }

  
            }
            catch (Exception ex)
            {
                this.lblMsg.Text = ex.Message;
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
             //   Response.Write("<p style=background-color:red;>" + ex.Message + "</p>");
             //   Response.Write("<p style=background-color:red;>" + ex.StackTrace + "</p>");
            }           
                        
       }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(URL.LOGIN_DEALER);
        }

        protected void btnlinkMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["Member"].ToString().Trim() == "1")
                {
                    //会員
                    Response.Redirect(URL.MENU_DEALER);
                }
                else
                {
                    //自販連
                    Response.Redirect(URL.MENU_JADA);

                }
            }
            catch
            {
            }

        }
    }
}