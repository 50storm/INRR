/*
 *会員、自販連　 共通
 *
 * 
 */
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
using System.Text.RegularExpressions;



namespace Jisseki_Report_Ibaraki.common
{
    public partial class alter_jisseki : System.Web.UI.Page
    {
        //メンバ
        //接続文字列
        private String strConn;

        private bool jadaUser;


        private String qCOCODE;
        private String qYearRep;
        private String qMonthRep;

 #region "チェックメソッド"

        private bool HeaderIsValid()
        {
            if (this.txtYear.Text == string.Empty)
            {
                this.lblMsg.Text = "送信日は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtYear.Focus();
                return false;

            }        

            if (this.txtMonth.Text == string.Empty)
            {
                this.lblMsg.Text = "送信日は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMonth.Focus();
                return false;

            }
            

            if (this.txtDay.Text == string.Empty)
            {
                this.lblMsg.Text = "送信日は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtDay.Focus();
                return false;

            }

            if (this.txtSyamei.Text == string.Empty)
            {
                this.lblMsg.Text = "会社名は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtSyamei.Focus();
                return false;
            }

            if (this.txtTantou.Text == string.Empty)
            {
                this.lblMsg.Text = "担当者は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtTantou.Focus();
                return false;
            }


            if (this.txtYearRep0.Text == string.Empty)
            {
                this.lblMsg.Text = "報告日は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtYearRep0.Focus();
                return false;

            }

            if (this.txtMonthRep0.Text == string.Empty)
            {
                this.lblMsg.Text = "報告日は必須入力です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMonthRep0.Focus();
                return false;

            }


            //数値
            if (Utility.IsNotNumber(this.txtYear.Text)) 
            {
                this.lblMsg.Text = "送信日は半角数値を入れてください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtYear.Focus();
                return false;
            }

            if (Utility.IsNotNumber(this.txtMonth.Text))
            {
                this.lblMsg.Text = "送信日は半角数値を入れてください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMonth.Focus();
                return false;

            }

            if (Utility.IsNotNumber(this.txtDay.Text))
            {
                this.lblMsg.Text = "送信日は半角数値を入れてください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtDay.Focus();
                return false;
            }
            

            if (Utility.IsNotNumber(this.txtYearRep0.Text))
            {
                this.lblMsg.Text = "報告日は半角数値を入れてください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtYearRep0.Focus();
                return false;
            }

            if (Utility.IsNotNumber(this.txtMonthRep0.Text))
            {
                this.lblMsg.Text = "報告日は半角数値を入れてください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMonthRep0.Focus();
                return false;
            }

                      
            //年のチェック
            if (int.Parse(this.txtYear.Text) < 1)
            {
                this.txtYear.Focus();
                return false;

            }
            if (int.Parse(this.txtYearRep0.Text) < 1)
            {
                this.txtYearRep0.Focus();
                return false;

            }

            //月のチェック
            if (int.Parse(this.txtMonth.Text) > 12 || int.Parse(this.txtMonth.Text) < 1) 
            {
                this.txtMonth.Focus();
                return false;
            }

            if (int.Parse(this.txtMonthRep0.Text) > 12 || int.Parse(this.txtMonthRep0.Text) < 1)
            {
                this.txtMonthRep0.Focus();
                return false;
            }


            //日のチェック
            if (int.Parse(this.txtDay.Text) > 31 || int.Parse(this.txtDay.Text) < 1)
            {
                this.txtDay.Focus();
                return false;
            }



            return true;

        }

        /// <summary>
        /// 水戸入力チェック
        /// </summary>
        /// <returns></returns>
        private bool MitoIsValid()
        {
            //貨物
            if (Utility.IsNotNumber(this.txtMito_Kamotu1.Text))
            {
                this.txtMito_Kamotu1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Kamotu1.Focus();
                return false;
            }
            else 
            {
                this.txtMito_Kamotu1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_Kamotu2.Text))
            {
                this.txtMito_Kamotu2.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Kamotu2.Focus();
                return false;
            }
            else
            {
                this.txtMito_Kamotu2.BackColor = System.Drawing.Color.White;
            }
            
            if (Utility.IsNotNumber(this.txtMito_Kamotu3.Text))
            {
                this.txtMito_Kamotu3.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Kamotu3.Focus();
                return false;
            }
            else
            {
                this.txtMito_Kamotu3.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtMito_Kamotu4.Text))
            {
                this.txtMito_Kamotu4.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Kamotu4.Focus();
                return false;
            }
            else
            {
                this.txtMito_Kamotu4.BackColor = System.Drawing.Color.White;
            }

            //バス
            if (Utility.IsNotNumber(this.txtMito_Bus1.Text))
            {
                this.txtMito_Bus1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Bus1.Focus();
                return false;
            }
            else
            {
                this.txtMito_Bus1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_Bus2.Text))
            {
                this.txtMito_Bus2.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Bus2.Focus();
                return false;
            }
            else
            {
                this.txtMito_Bus2.BackColor = System.Drawing.Color.White;
            }

            //乗用及び貨物車
            if (Utility.IsNotNumber(this.txtMito_JK_J1.Text))
            {
                this.txtMito_JK_J1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_J1.Focus();
                return false;
            }
            else
            {
                this.txtMito_JK_J1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_JK_K1.Text))
            {
                this.txtMito_JK_K1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_K1.Focus();
                return false;
            }
            else
            {
                this.txtMito_JK_K1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_JK_J2.Text))
            {
                this.txtMito_JK_J2.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_J2.Focus();
                return false;

            }
            else
            {
                this.txtMito_JK_J2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_JK_K2.Text))
            {
                this.txtMito_JK_K2.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_K2.Focus();
                return false;
            }
            else
            {
                this.txtMito_JK_K2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_JK_J3.Text))
            {
                this.txtMito_JK_J3.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_J3.Focus();
                return false;
            }
            else
            {
                this.txtMito_JK_J3.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtMito_JK_K3.Text))
            {
                this.txtMito_JK_K3.BackColor = System.Drawing.Color.Pink;
                this.txtMito_JK_K3.Focus();
                return false;
            }
            else
            {
                this.txtMito_JK_K3.BackColor = System.Drawing.Color.White;
            }

            //小計
            if (Utility.IsNotNumber(this.txtMito_SubTotal1.Text))
            {
                this.txtMito_SubTotal1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_SubTotal1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtMito_SubTotal1.BackColor = System.Drawing.Color.White;
            //}

            //合計
            if (Utility.IsNotNumber(this.txtMito_Total1.Text))
            {
                this.txtMito_Total1.BackColor = System.Drawing.Color.Pink;
                this.txtMito_Total1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtMito_Total1.BackColor = System.Drawing.Color.White;
            //}


            return true;
        }

        private bool TuchiuraIsValid()
        {
            //貨物
            if (Utility.IsNotNumber(this.txtTuchiura_Kamotu1.Text))
            {
                this.txtTuchiura_Kamotu1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Kamotu1.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Kamotu1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_Kamotu2.Text))
            {
                this.txtTuchiura_Kamotu2.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Kamotu2.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Kamotu2.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtTuchiura_Kamotu3.Text))
            {
                this.txtTuchiura_Kamotu3.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Kamotu3.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Kamotu3.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtTuchiura_Kamotu4.Text))
            {
                this.txtTuchiura_Kamotu4.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Kamotu4.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Kamotu4.BackColor = System.Drawing.Color.White;
            }

            //バス
            if (Utility.IsNotNumber(this.txtTuchiura_Bus1.Text))
            {
                this.txtTuchiura_Bus1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Bus1.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Bus1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_Bus2.Text))
            {
                this.txtTuchiura_Bus2.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Bus2.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_Bus2.BackColor = System.Drawing.Color.White;
            }

            //乗用及び貨物車
            if (Utility.IsNotNumber(this.txtTuchiura_JK_J1.Text))
            {
                this.txtTuchiura_JK_J1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_J1.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_JK_J1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_JK_K1.Text))
            {
                this.txtTuchiura_JK_K1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_K1.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_JK_K1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_JK_J2.Text))
            {
                this.txtTuchiura_JK_J2.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_J2.Focus();
                return false;

            }
            else
            {
                this.txtTuchiura_JK_J2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_JK_K2.Text))
            {
                this.txtTuchiura_JK_K2.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_K2.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_JK_K2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_JK_J3.Text))
            {
                this.txtTuchiura_JK_J3.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_J3.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_JK_J3.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTuchiura_JK_K3.Text))
            {
                this.txtTuchiura_JK_K3.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_JK_K3.Focus();
                return false;
            }
            else
            {
                this.txtTuchiura_JK_K3.BackColor = System.Drawing.Color.White;
            }

            //小計
            if (Utility.IsNotNumber(this.txtTuchiura_SubTotal1.Text))
            {
                this.txtTuchiura_SubTotal1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_SubTotal1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtTuchiura_SubTotal1.BackColor = System.Drawing.Color.White;
            //}

            //合計
            if (Utility.IsNotNumber(this.txtTuchiura_Total1.Text))
            {
                this.txtTuchiura_Total1.BackColor = System.Drawing.Color.Pink;
                this.txtTuchiura_Total1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtTuchiura_Total1.BackColor = System.Drawing.Color.White;
            //}


            return true;
        }

        private bool TukubaIsValid()
        {
            //貨物
            if (Utility.IsNotNumber(this.txtTukuba_Kamotu1.Text))
            {
                this.txtTukuba_Kamotu1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Kamotu1.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Kamotu1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_Kamotu2.Text))
            {
                this.txtTukuba_Kamotu2.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Kamotu2.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Kamotu2.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtTukuba_Kamotu3.Text))
            {
                this.txtTukuba_Kamotu3.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Kamotu3.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Kamotu3.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtTukuba_Kamotu4.Text))
            {
                this.txtTukuba_Kamotu4.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Kamotu4.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Kamotu4.BackColor = System.Drawing.Color.White;
            }

            //バス
            if (Utility.IsNotNumber(this.txtTukuba_Bus1.Text))
            {
                this.txtTukuba_Bus1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Bus1.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Bus1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_Bus2.Text))
            {
                this.txtTukuba_Bus2.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Bus2.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_Bus2.BackColor = System.Drawing.Color.White;
            }

            //乗用及び貨物車
            if (Utility.IsNotNumber(this.txtTukuba_JK_J1.Text))
            {
                this.txtTukuba_JK_J1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_J1.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_JK_J1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_JK_K1.Text))
            {
                this.txtTukuba_JK_K1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_K1.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_JK_K1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_JK_J2.Text))
            {
                this.txtTukuba_JK_J2.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_J2.Focus();
                return false;

            }
            else
            {
                this.txtTukuba_JK_J2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_JK_K2.Text))
            {
                this.txtTukuba_JK_K2.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_K2.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_JK_K2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_JK_J3.Text))
            {
                this.txtTukuba_JK_J3.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_J3.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_JK_J3.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtTukuba_JK_K3.Text))
            {
                this.txtTukuba_JK_K3.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_JK_K3.Focus();
                return false;
            }
            else
            {
                this.txtTukuba_JK_K3.BackColor = System.Drawing.Color.White;
            }

            //小計
            if (Utility.IsNotNumber(this.txtTukuba_SubTotal1.Text))
            {
                this.txtTukuba_SubTotal1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_SubTotal1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtTukuba_SubTotal1.BackColor = System.Drawing.Color.White;
            //}

            //合計
            if (Utility.IsNotNumber(this.txtTukuba_Total1.Text))
            {
                this.txtTukuba_Total1.BackColor = System.Drawing.Color.Pink;
                this.txtTukuba_Total1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtTukuba_Total1.BackColor = System.Drawing.Color.White;
            //}


            return true;
        }

        private bool SonotaIsValid()
        {
            //貨物
            if (Utility.IsNotNumber(this.txtSonota_Kamotu1.Text))
            {
                this.txtSonota_Kamotu1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Kamotu1.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Kamotu1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_Kamotu2.Text))
            {
                this.txtSonota_Kamotu2.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Kamotu2.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Kamotu2.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtSonota_Kamotu3.Text))
            {
                this.txtSonota_Kamotu3.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Kamotu3.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Kamotu3.BackColor = System.Drawing.Color.White;
            }

            if (Utility.IsNotNumber(this.txtSonota_Kamotu4.Text))
            {
                this.txtSonota_Kamotu4.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Kamotu4.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Kamotu4.BackColor = System.Drawing.Color.White;
            }

            //バス
            if (Utility.IsNotNumber(this.txtSonota_Bus1.Text))
            {
                this.txtSonota_Bus1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Bus1.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Bus1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_Bus2.Text))
            {
                this.txtSonota_Bus2.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Bus2.Focus();
                return false;
            }
            else
            {
                this.txtSonota_Bus2.BackColor = System.Drawing.Color.White;
            }

            //乗用及び貨物車
            if (Utility.IsNotNumber(this.txtSonota_JK_J1.Text))
            {
                this.txtSonota_JK_J1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_J1.Focus();
                return false;
            }
            else
            {
                this.txtSonota_JK_J1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_JK_K1.Text))
            {
                this.txtSonota_JK_K1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_K1.Focus();
                return false;
            }
            else
            {
                this.txtSonota_JK_K1.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_JK_J2.Text))
            {
                this.txtSonota_JK_J2.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_J2.Focus();
                return false;

            }
            else
            {
                this.txtSonota_JK_J2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_JK_K2.Text))
            {
                this.txtSonota_JK_K2.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_K2.Focus();
                return false;
            }
            else
            {
                this.txtSonota_JK_K2.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_JK_J3.Text))
            {
                this.txtSonota_JK_J3.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_J3.Focus();
                return false;
            }
            else
            {
                this.txtSonota_JK_J3.BackColor = System.Drawing.Color.White;
            }
            if (Utility.IsNotNumber(this.txtSonota_JK_K3.Text))
            {
                this.txtSonota_JK_K3.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_JK_K3.Focus();
                return false;
            }
            else
            {
                this.txtSonota_JK_K3.BackColor = System.Drawing.Color.White;
            }

            //小計
            if (Utility.IsNotNumber(this.txtSonota_SubTotal1.Text))
            {
                this.txtSonota_SubTotal1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_SubTotal1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtSonota_SubTotal1.BackColor = System.Drawing.Color.White;
            //}

            //合計
            if (Utility.IsNotNumber(this.txtSonota_Total1.Text))
            {
                this.txtSonota_Total1.BackColor = System.Drawing.Color.Pink;
                this.txtSonota_Total1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtSonota_Total1.BackColor = System.Drawing.Color.White;
            //}


            return true;
        }

        private bool GoukeiIsValid()
        {
            //貨物
            if (Utility.IsNotNumber(this.txtGoukei_Kamotu1.Text))
            {
                this.txtGoukei_Kamotu1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Kamotu1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Kamotu1.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_Kamotu2.Text))
            {
                this.txtGoukei_Kamotu2.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Kamotu2.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Kamotu2.BackColor = System.Drawing.Color.White;
            //}

            if (Utility.IsNotNumber(this.txtGoukei_Kamotu3.Text))
            {
                this.txtGoukei_Kamotu3.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Kamotu3.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Kamotu3.BackColor = System.Drawing.Color.White;
            //}

            if (Utility.IsNotNumber(this.txtGoukei_Kamotu4.Text))
            {
                this.txtGoukei_Kamotu4.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Kamotu4.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Kamotu4.BackColor = System.Drawing.Color.White;
            //}

            //バス
            if (Utility.IsNotNumber(this.txtGoukei_Bus1.Text))
            {
                this.txtGoukei_Bus1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Bus1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Bus1.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_Bus2.Text))
            {
                this.txtGoukei_Bus2.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Bus2.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Bus2.BackColor = System.Drawing.Color.White;
            //}

            //乗用及び貨物車
            if (Utility.IsNotNumber(this.txtGoukei_JK_J1.Text))
            {
                this.txtGoukei_JK_J1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_J1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_JK_J1.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_JK_K1.Text))
            {
                this.txtGoukei_JK_K1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_K1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_JK_K1.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_JK_J2.Text))
            {
                this.txtGoukei_JK_J2.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_J2.Focus();
                return false;

            }
            //else
            //{
            //    this.txtGoukei_JK_J2.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_JK_K2.Text))
            {
                this.txtGoukei_JK_K2.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_K2.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_JK_K2.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_JK_J3.Text))
            {
                this.txtGoukei_JK_J3.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_J3.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_JK_J3.BackColor = System.Drawing.Color.White;
            //}
            if (Utility.IsNotNumber(this.txtGoukei_JK_K3.Text))
            {
                this.txtGoukei_JK_K3.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_JK_K3.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_JK_K3.BackColor = System.Drawing.Color.White;
            //}

            //小計
            if (Utility.IsNotNumber(this.txtGoukei_SubTotal1.Text))
            {
                this.txtGoukei_SubTotal1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_SubTotal1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_SubTotal1.BackColor = System.Drawing.Color.White;
            //}

            //合計
            if (Utility.IsNotNumber(this.txtGoukei_Total1.Text))
            {
                this.txtGoukei_Total1.BackColor = System.Drawing.Color.Pink;
                this.txtGoukei_Total1.Focus();
                return false;
            }
            //else
            //{
            //    this.txtGoukei_Total1.BackColor = System.Drawing.Color.White;
            //}


            return true;
        }



 #endregion
        
 #region "コンバートメソッド" 

        //private void Header_ConvertNothingTo0() {

        //    this.txtYear.Text = Utility.ToHankaku(this.txtYear.Text.Trim());

        //    this.txtMonth.Text = Utility.ToHankaku(this.txtMonth.Text.Trim());

        //    this.txtDay.Text = Utility.ToHankaku(this.txtDay.Text.Trim());
            
        //    this.txtYearRep0.Text = Utility.ToHankaku(this.txtYearRep0.Text.Trim());

        //    this.txtMonthRep0.Text = Utility.ToHankaku(this.txtMonthRep0.Text.Trim());

        //}


        /// <summary>
        /// 何も入力されてないときは、半角の0に強制変換
        /// </summary>
        private void Mito_ConvertNothingTo0()
        {
            //貨物
            this.txtMito_Kamotu1.Text = Utility.ToHankaku(this.txtMito_Kamotu1.Text.Trim());
            if (this.txtMito_Kamotu1.Text == string.Empty)
            {
                this.txtMito_Kamotu1.Text = "0";

            }

            this.txtMito_Kamotu2.Text = Utility.ToHankaku(this.txtMito_Kamotu2.Text.Trim());
            if (this.txtMito_Kamotu2.Text == string.Empty)
            {
                this.txtMito_Kamotu2.Text = "0";

            }

            this.txtMito_Kamotu3.Text = Utility.ToHankaku(this.txtMito_Kamotu3.Text.Trim());
            if (this.txtMito_Kamotu3.Text == string.Empty)
            {
                this.txtMito_Kamotu3.Text = "0";

            }

            this.txtMito_Kamotu4.Text = Utility.ToHankaku(this.txtMito_Kamotu4.Text.Trim());
            if (this.txtMito_Kamotu4.Text == string.Empty)
            {
                this.txtMito_Kamotu4.Text = "0";

            }


            //バス
            this.txtMito_Bus1.Text = Utility.ToHankaku(this.txtMito_Bus1.Text.Trim());
            if (this.txtMito_Bus1.Text == string.Empty)
            {
                this.txtMito_Bus1.Text = "0";

            }

            this.txtMito_Bus2.Text = Utility.ToHankaku(this.txtMito_Bus2.Text.Trim());
            if (this.txtMito_Bus2.Text == string.Empty)
            {
                this.txtMito_Bus2.Text = "0";

            }


            //乗用及び貨物車                
            this.txtMito_JK_J1.Text = Utility.ToHankaku(this.txtMito_JK_J1.Text.Trim());
            if (this.txtMito_JK_J1.Text == string.Empty)
            {
                this.txtMito_JK_J1.Text = "0";

            }

            this.txtMito_JK_K1.Text = Utility.ToHankaku(this.txtMito_JK_K1.Text.Trim());
            if (this.txtMito_JK_K1.Text == string.Empty)
            {
                this.txtMito_JK_K1.Text = "0";

            }

            this.txtMito_JK_J2.Text = Utility.ToHankaku(this.txtMito_JK_J2.Text.Trim());
            if (this.txtMito_JK_J2.Text == string.Empty)
            {
                this.txtMito_JK_J2.Text = "0";

            }

            this.txtMito_JK_K2.Text = Utility.ToHankaku(this.txtMito_JK_K2.Text.Trim());
            if (this.txtMito_JK_K2.Text == string.Empty)
            {
                this.txtMito_JK_K2.Text = "0";

            }

            this.txtMito_JK_J3.Text = Utility.ToHankaku(this.txtMito_JK_J3.Text.Trim());
            if (this.txtMito_JK_J3.Text == string.Empty)
            {
                this.txtMito_JK_J3.Text = "0";

            }

            this.txtMito_JK_K3.Text = Utility.ToHankaku(this.txtMito_JK_K3.Text.Trim());
            if (this.txtMito_JK_K3.Text == string.Empty)
            {
                this.txtMito_JK_K3.Text = "0";

            }

            //小計
            this.txtMito_SubTotal1.Text = Utility.ToHankaku(this.txtMito_SubTotal1.Text.Trim());
            if (this.txtMito_SubTotal1.Text == string.Empty)
            {
                this.txtMito_SubTotal1.Text = "0";

            }

            //合計
            this.txtMito_Total1.Text = Utility.ToHankaku(this.txtMito_Total1.Text.Trim());
            if (this.txtMito_Total1.Text == string.Empty)
            {
                this.txtMito_Total1.Text = "0";

            }

        }

        /// <summary>
        /// 何も入力されてないときは、半角の0に強制変換
        /// </summary>
        private void Tuchiura_ConvertNothingTo0()
        {
            //貨物
            this.txtTuchiura_Kamotu1.Text = Utility.ToHankaku(this.txtTuchiura_Kamotu1.Text.Trim());
            if (this.txtTuchiura_Kamotu1.Text == string.Empty)
            {
                this.txtTuchiura_Kamotu1.Text = "0";

            }

            this.txtTuchiura_Kamotu2.Text = Utility.ToHankaku(this.txtTuchiura_Kamotu2.Text.Trim());
            if (this.txtTuchiura_Kamotu2.Text == string.Empty)
            {
                this.txtTuchiura_Kamotu2.Text = "0";

            }

            this.txtTuchiura_Kamotu3.Text = Utility.ToHankaku(this.txtTuchiura_Kamotu3.Text.Trim());
            if (this.txtTuchiura_Kamotu3.Text == string.Empty)
            {
                this.txtTuchiura_Kamotu3.Text = "0";

            }

            this.txtTuchiura_Kamotu4.Text = Utility.ToHankaku(this.txtTuchiura_Kamotu4.Text.Trim());
            if (this.txtTuchiura_Kamotu4.Text == string.Empty)
            {
                this.txtTuchiura_Kamotu4.Text = "0";

            }


            //バス
            this.txtTuchiura_Bus1.Text = Utility.ToHankaku(this.txtTuchiura_Bus1.Text.Trim());
            if (this.txtTuchiura_Bus1.Text == string.Empty)
            {
                this.txtTuchiura_Bus1.Text = "0";

            }

            this.txtTuchiura_Bus2.Text = Utility.ToHankaku(this.txtTuchiura_Bus2.Text.Trim());
            if (this.txtTuchiura_Bus2.Text == string.Empty)
            {
                this.txtTuchiura_Bus2.Text = "0";

            }


            //乗用及び貨物車                
            this.txtTuchiura_JK_J1.Text = Utility.ToHankaku(this.txtTuchiura_JK_J1.Text.Trim());
            if (this.txtTuchiura_JK_J1.Text == string.Empty)
            {
                this.txtTuchiura_JK_J1.Text = "0";

            }

            this.txtTuchiura_JK_K1.Text = Utility.ToHankaku(this.txtTuchiura_JK_K1.Text.Trim());
            if (this.txtTuchiura_JK_K1.Text == string.Empty)
            {
                this.txtTuchiura_JK_K1.Text = "0";

            }

            this.txtTuchiura_JK_J2.Text = Utility.ToHankaku(this.txtTuchiura_JK_J2.Text.Trim());
            if (this.txtTuchiura_JK_J2.Text == string.Empty)
            {
                this.txtTuchiura_JK_J2.Text = "0";

            }

            this.txtTuchiura_JK_K2.Text = Utility.ToHankaku(this.txtTuchiura_JK_K2.Text.Trim());
            if (this.txtTuchiura_JK_K2.Text == string.Empty)
            {
                this.txtTuchiura_JK_K2.Text = "0";

            }

            this.txtTuchiura_JK_J3.Text = Utility.ToHankaku(this.txtTuchiura_JK_J3.Text.Trim());
            if (this.txtTuchiura_JK_J3.Text == string.Empty)
            {
                this.txtTuchiura_JK_J3.Text = "0";

            }

            this.txtTuchiura_JK_K3.Text = Utility.ToHankaku(this.txtTuchiura_JK_K3.Text.Trim());
            if (this.txtTuchiura_JK_K3.Text == string.Empty)
            {
                this.txtTuchiura_JK_K3.Text = "0";

            }

            //小計
            this.txtTuchiura_SubTotal1.Text = Utility.ToHankaku(this.txtTuchiura_SubTotal1.Text.Trim());
            if (this.txtTuchiura_SubTotal1.Text == string.Empty)
            {
                this.txtTuchiura_SubTotal1.Text = "0";

            }

            //合計
            this.txtTuchiura_Total1.Text = Utility.ToHankaku(this.txtTuchiura_Total1.Text.Trim());
            if (this.txtTuchiura_Total1.Text == string.Empty)
            {
                this.txtTuchiura_Total1.Text = "0";

            }

        }

        /// <summary>
        /// 何も入力されてないときは、半角の0に強制変換
        /// </summary>
        private void Tukuba_ConvertNothingTo0()
        {
            //貨物
            this.txtTukuba_Kamotu1.Text = Utility.ToHankaku(this.txtTukuba_Kamotu1.Text.Trim());
            if (this.txtTukuba_Kamotu1.Text == string.Empty)
            {
                this.txtTukuba_Kamotu1.Text = "0";

            }

            this.txtTukuba_Kamotu2.Text = Utility.ToHankaku(this.txtTukuba_Kamotu2.Text.Trim());
            if (this.txtTukuba_Kamotu2.Text == string.Empty)
            {
                this.txtTukuba_Kamotu2.Text = "0";

            }

            this.txtTukuba_Kamotu3.Text = Utility.ToHankaku(this.txtTukuba_Kamotu3.Text.Trim());
            if (this.txtTukuba_Kamotu3.Text == string.Empty)
            {
                this.txtTukuba_Kamotu3.Text = "0";

            }

            this.txtTukuba_Kamotu4.Text = Utility.ToHankaku(this.txtTukuba_Kamotu4.Text.Trim());
            if (this.txtTukuba_Kamotu4.Text == string.Empty)
            {
                this.txtTukuba_Kamotu4.Text = "0";

            }


            //バス
            this.txtTukuba_Bus1.Text = Utility.ToHankaku(this.txtTukuba_Bus1.Text.Trim());
            if (this.txtTukuba_Bus1.Text == string.Empty)
            {
                this.txtTukuba_Bus1.Text = "0";

            }

            this.txtTukuba_Bus2.Text = Utility.ToHankaku(this.txtTukuba_Bus2.Text.Trim());
            if (this.txtTukuba_Bus2.Text == string.Empty)
            {
                this.txtTukuba_Bus2.Text = "0";

            }


            //乗用及び貨物車                
            this.txtTukuba_JK_J1.Text = Utility.ToHankaku(this.txtTukuba_JK_J1.Text.Trim());
            if (this.txtTukuba_JK_J1.Text == string.Empty)
            {
                this.txtTukuba_JK_J1.Text = "0";

            }

            this.txtTukuba_JK_K1.Text = Utility.ToHankaku(this.txtTukuba_JK_K1.Text.Trim());
            if (this.txtTukuba_JK_K1.Text == string.Empty)
            {
                this.txtTukuba_JK_K1.Text = "0";

            }

            this.txtTukuba_JK_J2.Text = Utility.ToHankaku(this.txtTukuba_JK_J2.Text.Trim());
            if (this.txtTukuba_JK_J2.Text == string.Empty)
            {
                this.txtTukuba_JK_J2.Text = "0";

            }

            this.txtTukuba_JK_K2.Text = Utility.ToHankaku(this.txtTukuba_JK_K2.Text.Trim());
            if (this.txtTukuba_JK_K2.Text == string.Empty)
            {
                this.txtTukuba_JK_K2.Text = "0";

            }

            this.txtTukuba_JK_J3.Text = Utility.ToHankaku(this.txtTukuba_JK_J3.Text.Trim());
            if (this.txtTukuba_JK_J3.Text == string.Empty)
            {
                this.txtTukuba_JK_J3.Text = "0";

            }

            this.txtTukuba_JK_K3.Text = Utility.ToHankaku(this.txtTukuba_JK_K3.Text.Trim());
            if (this.txtTukuba_JK_K3.Text == string.Empty)
            {
                this.txtTukuba_JK_K3.Text = "0";

            }

            //小計
            this.txtTukuba_SubTotal1.Text = Utility.ToHankaku(this.txtTukuba_SubTotal1.Text.Trim());
            if (this.txtTukuba_SubTotal1.Text == string.Empty)
            {
                this.txtTukuba_SubTotal1.Text = "0";

            }

            //合計
            this.txtTukuba_Total1.Text = Utility.ToHankaku(this.txtTukuba_Total1.Text.Trim());
            if (this.txtTukuba_Total1.Text == string.Empty)
            {
                this.txtTukuba_Total1.Text = "0";

            }

        }

        /// <summary>
        /// 何も入力されてないときは、半角の0に強制変換
        /// </summary>
        private void Sonota_ConvertNothingTo0()
        {
            //貨物
            this.txtSonota_Kamotu1.Text = Utility.ToHankaku(this.txtSonota_Kamotu1.Text.Trim());
            if (this.txtSonota_Kamotu1.Text == string.Empty)
            {
                this.txtSonota_Kamotu1.Text = "0";

            }

            this.txtSonota_Kamotu2.Text = Utility.ToHankaku(this.txtSonota_Kamotu2.Text.Trim());
            if (this.txtSonota_Kamotu2.Text == string.Empty)
            {
                this.txtSonota_Kamotu2.Text = "0";

            }

            this.txtSonota_Kamotu3.Text = Utility.ToHankaku(this.txtSonota_Kamotu3.Text.Trim());
            if (this.txtSonota_Kamotu3.Text == string.Empty)
            {
                this.txtSonota_Kamotu3.Text = "0";

            }

            this.txtSonota_Kamotu4.Text = Utility.ToHankaku(this.txtSonota_Kamotu4.Text.Trim());
            if (this.txtSonota_Kamotu4.Text == string.Empty)
            {
                this.txtSonota_Kamotu4.Text = "0";

            }


            //バス
            this.txtSonota_Bus1.Text = Utility.ToHankaku(this.txtSonota_Bus1.Text.Trim());
            if (this.txtSonota_Bus1.Text == string.Empty)
            {
                this.txtSonota_Bus1.Text = "0";

            }

            this.txtSonota_Bus2.Text = Utility.ToHankaku(this.txtSonota_Bus2.Text.Trim());
            if (this.txtSonota_Bus2.Text == string.Empty)
            {
                this.txtSonota_Bus2.Text = "0";

            }


            //乗用及び貨物車                
            this.txtSonota_JK_J1.Text = Utility.ToHankaku(this.txtSonota_JK_J1.Text.Trim());
            if (this.txtSonota_JK_J1.Text == string.Empty)
            {
                this.txtSonota_JK_J1.Text = "0";

            }

            this.txtSonota_JK_K1.Text = Utility.ToHankaku(this.txtSonota_JK_K1.Text.Trim());
            if (this.txtSonota_JK_K1.Text == string.Empty)
            {
                this.txtSonota_JK_K1.Text = "0";

            }

            this.txtSonota_JK_J2.Text = Utility.ToHankaku(this.txtSonota_JK_J2.Text.Trim());
            if (this.txtSonota_JK_J2.Text == string.Empty)
            {
                this.txtSonota_JK_J2.Text = "0";

            }

            this.txtSonota_JK_K2.Text = Utility.ToHankaku(this.txtSonota_JK_K2.Text.Trim());
            if (this.txtSonota_JK_K2.Text == string.Empty)
            {
                this.txtSonota_JK_K2.Text = "0";

            }

            this.txtSonota_JK_J3.Text = Utility.ToHankaku(this.txtSonota_JK_J3.Text.Trim());
            if (this.txtSonota_JK_J3.Text == string.Empty)
            {
                this.txtSonota_JK_J3.Text = "0";

            }

            this.txtSonota_JK_K3.Text = Utility.ToHankaku(this.txtSonota_JK_K3.Text.Trim());
            if (this.txtSonota_JK_K3.Text == string.Empty)
            {
                this.txtSonota_JK_K3.Text = "0";

            }

            //小計
            this.txtSonota_SubTotal1.Text = Utility.ToHankaku(this.txtSonota_SubTotal1.Text.Trim());
            if (this.txtSonota_SubTotal1.Text == string.Empty)
            {
                this.txtSonota_SubTotal1.Text = "0";

            }

            //合計
            this.txtSonota_Total1.Text = Utility.ToHankaku(this.txtSonota_Total1.Text.Trim());
            if (this.txtSonota_Total1.Text == string.Empty)
            {
                this.txtSonota_Total1.Text = "0";

            }

        }

        /// <summary>
        /// 何も入力されてないときは、半角の0に強制変換
        /// </summary>
        private void Goukei_ConvertNothingTo0()
        {
            //貨物
            this.txtGoukei_Kamotu1.Text = Utility.ToHankaku(this.txtGoukei_Kamotu1.Text.Trim());
            if (this.txtGoukei_Kamotu1.Text == string.Empty)
            {
                this.txtGoukei_Kamotu1.Text = "0";

            }

            this.txtGoukei_Kamotu2.Text = Utility.ToHankaku(this.txtGoukei_Kamotu2.Text.Trim());
            if (this.txtGoukei_Kamotu2.Text == string.Empty)
            {
                this.txtGoukei_Kamotu2.Text = "0";

            }

            this.txtGoukei_Kamotu3.Text = Utility.ToHankaku(this.txtGoukei_Kamotu3.Text.Trim());
            if (this.txtGoukei_Kamotu3.Text == string.Empty)
            {
                this.txtGoukei_Kamotu3.Text = "0";

            }

            this.txtGoukei_Kamotu4.Text = Utility.ToHankaku(this.txtGoukei_Kamotu4.Text.Trim());
            if (this.txtGoukei_Kamotu4.Text == string.Empty)
            {
                this.txtGoukei_Kamotu4.Text = "0";

            }


            //バス
            this.txtGoukei_Bus1.Text = Utility.ToHankaku(this.txtGoukei_Bus1.Text.Trim());
            if (this.txtGoukei_Bus1.Text == string.Empty)
            {
                this.txtGoukei_Bus1.Text = "0";

            }

            this.txtGoukei_Bus2.Text = Utility.ToHankaku(this.txtGoukei_Bus2.Text.Trim());
            if (this.txtGoukei_Bus2.Text == string.Empty)
            {
                this.txtGoukei_Bus2.Text = "0";

            }


            //乗用及び貨物車                
            this.txtGoukei_JK_J1.Text = Utility.ToHankaku(this.txtGoukei_JK_J1.Text.Trim());
            if (this.txtGoukei_JK_J1.Text == string.Empty)
            {
                this.txtGoukei_JK_J1.Text = "0";

            }

            this.txtGoukei_JK_K1.Text = Utility.ToHankaku(this.txtGoukei_JK_K1.Text.Trim());
            if (this.txtGoukei_JK_K1.Text == string.Empty)
            {
                this.txtGoukei_JK_K1.Text = "0";

            }

            this.txtGoukei_JK_J2.Text = Utility.ToHankaku(this.txtGoukei_JK_J2.Text.Trim());
            if (this.txtGoukei_JK_J2.Text == string.Empty)
            {
                this.txtGoukei_JK_J2.Text = "0";

            }

            this.txtGoukei_JK_K2.Text = Utility.ToHankaku(this.txtGoukei_JK_K2.Text.Trim());
            if (this.txtGoukei_JK_K2.Text == string.Empty)
            {
                this.txtGoukei_JK_K2.Text = "0";

            }

            this.txtGoukei_JK_J3.Text = Utility.ToHankaku(this.txtGoukei_JK_J3.Text.Trim());
            if (this.txtGoukei_JK_J3.Text == string.Empty)
            {
                this.txtGoukei_JK_J3.Text = "0";

            }

            this.txtGoukei_JK_K3.Text = Utility.ToHankaku(this.txtGoukei_JK_K3.Text.Trim());
            if (this.txtGoukei_JK_K3.Text == string.Empty)
            {
                this.txtGoukei_JK_K3.Text = "0";

            }

            //小計
            this.txtGoukei_SubTotal1.Text = Utility.ToHankaku(this.txtGoukei_SubTotal1.Text.Trim());
            if (this.txtGoukei_SubTotal1.Text == string.Empty)
            {
                this.txtGoukei_SubTotal1.Text = "0";

            }

            //合計
            this.txtGoukei_Total1.Text = Utility.ToHankaku(this.txtGoukei_Total1.Text.Trim());
            if (this.txtGoukei_Total1.Text == string.Empty)
            {
                this.txtGoukei_Total1.Text = "0";

            }

        }

#endregion

        #region"セッター"
        private void setHeaderForJada() {
            string SqlHeader =
                " SELECT H.COCODE AS COCODE, "
                + "      H.Year AS Year ,"
                + "      H.Month AS Month ,"
                + "      H.Day AS Day ,"
                + "      H.YearRep AS YearRep ,"
                + "      H.MonthRep AS MonthRep ,"
                + "      H.TANTOU AS TANTOU  ,"
                + "      I.CONAME AS CONAME  "
                + " FROM [Jisseki_Header] H "
                + " INNER JOIN  [ID] I"
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
        private void setHeader(){
            //初期表示


            string SqlHeader =
                " SELECT * FROM [Jisseki_Header]  "
                +" WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";//TODO

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
                      　this.txtSyamei.Text = Session["CONAME"].ToString();//TODO 自販連からきたときと別
                        

                        this.txtTantou.Text = Reader["TANTOU"].ToString();

                    }
                }
                Conn.Close();
            }
        }



        /// <summary>
        /// setMitoData
        /// </summary>
        private void setMito() {
            string SqlMito =
                    " SELECT * FROM [Jisseki_Mito]  "
                    //+ " WHERE COCODE=@COCODE AND Year = @Year AND Month = @Month AND Day = @Day";
                    +" WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
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
                        //this.txtMito_Kamotu1.Text   = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtMito_Kamotu2.Text   = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtMito_Kamotu3.Text   = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtMito_Kamotu4.Text   = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtMito_Bus1.Text      = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtMito_Bus2.Text      = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtMito_JK_J1.Text     = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtMito_JK_K1.Text     = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtMito_JK_J2.Text     = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtMito_JK_K2.Text     = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtMito_JK_J3.Text     = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtMito_JK_K3.Text     = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtMito_SubTotal1.Text = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtMito_Total1.Text    = Utility.zeroToSpace(Reader["Total1"].ToString());

                        this.txtMito_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtMito_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtMito_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtMito_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtMito_Bus1.Text    = Reader["Bus1"].ToString();
                        this.txtMito_Bus2.Text    = Reader["Bus2"].ToString();
                        this.txtMito_JK_J1.Text   = Reader["JK_J1"].ToString();
                        this.txtMito_JK_K1.Text   = Reader["JK_K1"].ToString();
                        this.txtMito_JK_J2.Text   = Reader["JK_J2"].ToString();
                        this.txtMito_JK_K2.Text   = Reader["JK_K2"].ToString();
                        this.txtMito_JK_J3.Text   = Reader["JK_J3"].ToString();
                        this.txtMito_JK_K3.Text   = Reader["JK_K3"].ToString();
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
                    " SELECT * FROM [Jisseki_Tuchiura]  "
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
                        this.txtTuchiura_Bus1.Text  = Reader["Bus1"].ToString();
                        this.txtTuchiura_Bus2.Text  = Reader["Bus2"].ToString();
                        this.txtTuchiura_JK_J1.Text = Reader["JK_J1"].ToString();
                        this.txtTuchiura_JK_K1.Text = Reader["JK_K1"].ToString();
                        this.txtTuchiura_JK_J2.Text = Reader["JK_J2"].ToString();
                        this.txtTuchiura_JK_K2.Text = Reader["JK_K2"].ToString();
                        this.txtTuchiura_JK_J3.Text = Reader["JK_J3"].ToString();
                        this.txtTuchiura_JK_K3.Text = Reader["JK_K3"].ToString();
                        this.txtTuchiura_SubTotal1.Text = Reader["SubTotal1"].ToString();
                        this.txtTuchiura_Total1.Text =  Reader["Total1"].ToString();

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
                    " SELECT * FROM [Jisseki_Tukuba]  "
                    +" WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
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
                    " SELECT * FROM [Jisseki_Sonota]  "
                    +" WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
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
                        this.txtSonota_Bus1.Text    =  Reader["Bus1"].ToString();
                        this.txtSonota_Bus2.Text    =  Reader["Bus2"].ToString();
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
                    " SELECT * FROM [Jisseki_Goukei]  "
                    +" WHERE COCODE=@COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
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
                        //this.txtGoukei_Kamotu1.Text     = Utility.zeroToSpace(Reader["Kamotu1"].ToString());
                        //this.txtGoukei_Kamotu2.Text     = Utility.zeroToSpace(Reader["Kamotu2"].ToString());
                        //this.txtGoukei_Kamotu3.Text     = Utility.zeroToSpace(Reader["Kamotu3"].ToString());
                        //this.txtGoukei_Kamotu4.Text     = Utility.zeroToSpace(Reader["Kamotu4"].ToString());
                        //this.txtGoukei_Bus1.Text        = Utility.zeroToSpace(Reader["Bus1"].ToString());
                        //this.txtGoukei_Bus2.Text        = Utility.zeroToSpace(Reader["Bus2"].ToString());
                        //this.txtGoukei_JK_J1.Text       = Utility.zeroToSpace(Reader["JK_J1"].ToString());
                        //this.txtGoukei_JK_K1.Text       = Utility.zeroToSpace(Reader["JK_K1"].ToString());
                        //this.txtGoukei_JK_J2.Text       = Utility.zeroToSpace(Reader["JK_J2"].ToString());
                        //this.txtGoukei_JK_K2.Text       = Utility.zeroToSpace(Reader["JK_K2"].ToString());
                        //this.txtGoukei_JK_J3.Text       = Utility.zeroToSpace(Reader["JK_J3"].ToString());
                        //this.txtGoukei_JK_K3.Text       = Utility.zeroToSpace(Reader["JK_K3"].ToString());
                        //this.txtGoukei_SubTotal1.Text   = Utility.zeroToSpace(Reader["SubTotal1"].ToString());
                        //this.txtGoukei_Total1.Text      = Utility.zeroToSpace(Reader["Total1"].ToString());

                        this.txtGoukei_Kamotu1.Text = Reader["Kamotu1"].ToString();
                        this.txtGoukei_Kamotu2.Text = Reader["Kamotu2"].ToString();
                        this.txtGoukei_Kamotu3.Text = Reader["Kamotu3"].ToString();
                        this.txtGoukei_Kamotu4.Text = Reader["Kamotu4"].ToString();
                        this.txtGoukei_Bus1.Text  = Reader["Bus1"].ToString();
                        this.txtGoukei_Bus2.Text  = Reader["Bus2"].ToString();
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
            }
            else
            {
                this.setHeader();
            }
            this.setMito();
            this.setTuchiura();
            this.setTukuba();
            this.setSonota();
            this.setGoukei();

            //Key項目
            //EnableをFalse
            this.txtYearRep0.Enabled = false;
            this.txtMonthRep0.Enabled = false;

            this.txtYear.Enabled = false;
            this.txtMonth.Enabled = false;
            this.txtDay.Enabled = false;

            this.txtSyamei.Enabled = false;

           //TODO this.txtGoukei_Bus1.Enabled = false;


            this.txtTantou.Focus();

        }
        #endregion

        #region "更新メソッド"

        private void updateHeader(SqlConnection Conn, SqlTransaction Tran)
        {

            String UpdateMitoSql = "UPDATE [Jisseki_Header] "
                                    + " SET "
                                    + "    [Year]   = @Year"
                                    + "   ,[Month]  = @Month "
                                    + "   ,[Day]    = @Day "
                                    + "   ,[COCODE] = @COCODE "
                                    + "   ,[TANTOU] = @TANTOU "
                                    + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";


            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(UpdateMitoSql, Conn, Tran);
                cmd.CommandText = UpdateMitoSql;
                //Sqlインジェクション回避
                //キー項目
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

                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));
                cmd.Parameters.Add(new SqlParameter("@TANTOU", txtTantou.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }

        /// <summary>
        /// Update Mito's Data
        /// </summary>
        private void updateMito(SqlConnection Conn,SqlTransaction Tran){
            
            //INSERT作成
            //SqlConnection sn = new ;
            String updateMitoSql = "UPDATE [Jisseki_Mito] "
                                 + " SET"
                                 + "  [Year]      = @Year "
                                 + " ,[Month]     = @Month "
                                 + " ,[Day]       = @Day "
                                 + " ,[COCODE]    = @COCODE "
                                 + " ,[Kamotu1]   = @Kamotu1 "
                                 + " ,[Kamotu2]   = @Kamotu2 "
                                 + " ,[Kamotu3]   = @Kamotu3 "
                                 + " ,[Kamotu4]   = @Kamotu4 "
                                 + " ,[Bus1]      = @Bus1  "
                                 + " ,[Bus2]      = @Bus2 "
                                 + " ,[JK_J1]     = @JK_J1 "
                                 + " ,[JK_K1]     = @JK_K1 "
                                 + " ,[JK_J2]     = @JK_J2 "
                                 + " ,[JK_K2]     = @JK_K2 "
                                 + " ,[JK_J3]     = @JK_J3 "
                                 + " ,[JK_K3]     = @JK_K3 "
                                 + " ,[SubTotal1] = @SubTotal1 "
                                 + " ,[Total1]    = @Total1 "
                                 + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";
                                 
                           
            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(updateMitoSql, Conn, Tran);
                cmd.CommandText = updateMitoSql;
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

                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));


                //貨物
                cmd.Parameters.Add(new SqlParameter("@Kamotu1", txtMito_Kamotu1.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu2", txtMito_Kamotu2.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu3", txtMito_Kamotu3.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu4", txtMito_Kamotu4.Text));
                //バス
                cmd.Parameters.Add(new SqlParameter("@Bus1", txtMito_Bus1.Text));
                cmd.Parameters.Add(new SqlParameter("@Bus2", txtMito_Bus2.Text));
                //乗用　貨物
                cmd.Parameters.Add(new SqlParameter("@JK_J1", txtMito_JK_J1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K1", txtMito_JK_K1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J2", txtMito_JK_J2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K2", txtMito_JK_K2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J3", txtMito_JK_J3.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K3", txtMito_JK_K3.Text));
                cmd.Parameters.Add(new SqlParameter("@SubTotal1", txtMito_SubTotal1.Text));
                cmd.Parameters.Add(new SqlParameter("@Total1", txtMito_Total1.Text));
                cmd.ExecuteNonQuery();

            }
            catch 
            {
                throw ;

            }
        
        }


        /// <summary>
        /// Update Tuchiura's Data
        /// </summary>
        private void updateTuchiura(SqlConnection Conn, SqlTransaction Tran)
        {

            //INSERT作成
            //SqlConnection sn = new ;
            String updateTuchiuraSql = "UPDATE [Jisseki_Tuchiura] "
                                 + " SET"
                                 + "  [Year]      = @Year "
                                 + " ,[Month]     = @Month "
                                 + " ,[Day]       = @Day "
                                 + " ,[COCODE]    = @COCODE "
                                 + " ,[Kamotu1]   = @Kamotu1 "
                                 + " ,[Kamotu2]   = @Kamotu2 "
                                 + " ,[Kamotu3]   = @Kamotu3 "
                                 + " ,[Kamotu4]   = @Kamotu4 "
                                 + " ,[Bus1]      = @Bus1  "
                                 + " ,[Bus2]      = @Bus2 "
                                 + " ,[JK_J1]     = @JK_J1 "
                                 + " ,[JK_K1]     = @JK_K1 "
                                 + " ,[JK_J2]     = @JK_J2 "
                                 + " ,[JK_K2]     = @JK_K2 "
                                 + " ,[JK_J3]     = @JK_J3 "
                                 + " ,[JK_K3]     = @JK_K3 "
                                 + " ,[SubTotal1] = @SubTotal1 "
                                 + " ,[Total1]    = @Total1 "
                                 + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";


            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(updateTuchiuraSql, Conn, Tran);
                cmd.CommandText = updateTuchiuraSql;
                //Sqlインジェクション回避
                //キー項目
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


                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));



                //貨物
                cmd.Parameters.Add(new SqlParameter("@Kamotu1", txtTuchiura_Kamotu1.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu2", txtTuchiura_Kamotu2.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu3", txtTuchiura_Kamotu3.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu4", txtTuchiura_Kamotu4.Text));
                //バス
                cmd.Parameters.Add(new SqlParameter("@Bus1", txtTuchiura_Bus1.Text));
                cmd.Parameters.Add(new SqlParameter("@Bus2", txtTuchiura_Bus2.Text));
                //乗用　貨物
                cmd.Parameters.Add(new SqlParameter("@JK_J1", txtTuchiura_JK_J1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K1", txtTuchiura_JK_K1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J2", txtTuchiura_JK_J2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K2", txtTuchiura_JK_K2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J3", txtTuchiura_JK_J3.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K3", txtTuchiura_JK_K3.Text));
                cmd.Parameters.Add(new SqlParameter("@SubTotal1", txtTuchiura_SubTotal1.Text));
                cmd.Parameters.Add(new SqlParameter("@Total1", txtTuchiura_Total1.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }


        /// <summary>
        /// Update Tukuba's Data
        /// </summary>
        private void updateTukuba(SqlConnection Conn, SqlTransaction Tran)
        {

            //INSERT作成
            //SqlConnection sn = new ;
            String updateTukubaSql = "UPDATE [Jisseki_Tukuba] "
                                 + " SET"
                                 + "  [Year]      = @Year "
                                 + " ,[Month]     = @Month "
                                 + " ,[Day]       = @Day "
                                 + " ,[COCODE]    = @COCODE "
                                 + " ,[Kamotu1]   = @Kamotu1 "
                                 + " ,[Kamotu2]   = @Kamotu2 "
                                 + " ,[Kamotu3]   = @Kamotu3 "
                                 + " ,[Kamotu4]   = @Kamotu4 "
                                 + " ,[Bus1]      = @Bus1  "
                                 + " ,[Bus2]      = @Bus2 "
                                 + " ,[JK_J1]     = @JK_J1 "
                                 + " ,[JK_K1]     = @JK_K1 "
                                 + " ,[JK_J2]     = @JK_J2 "
                                 + " ,[JK_K2]     = @JK_K2 "
                                 + " ,[JK_J3]     = @JK_J3 "
                                 + " ,[JK_K3]     = @JK_K3 "
                                 + " ,[SubTotal1] = @SubTotal1 "
                                 + " ,[Total1]    = @Total1 "
                                 + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";


            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(updateTukubaSql, Conn, Tran);
                cmd.CommandText = updateTukubaSql;
                //Sqlインジェクション回避
                //キー項目
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

                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));


                //貨物
                cmd.Parameters.Add(new SqlParameter("@Kamotu1", txtTukuba_Kamotu1.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu2", txtTukuba_Kamotu2.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu3", txtTukuba_Kamotu3.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu4", txtTukuba_Kamotu4.Text));
                //バス
                cmd.Parameters.Add(new SqlParameter("@Bus1", txtTukuba_Bus1.Text));
                cmd.Parameters.Add(new SqlParameter("@Bus2", txtTukuba_Bus2.Text));
                //乗用　貨物
                cmd.Parameters.Add(new SqlParameter("@JK_J1", txtTukuba_JK_J1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K1", txtTukuba_JK_K1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J2", txtTukuba_JK_J2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K2", txtTukuba_JK_K2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J3", txtTukuba_JK_J3.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K3", txtTukuba_JK_K3.Text));
                cmd.Parameters.Add(new SqlParameter("@SubTotal1", txtTukuba_SubTotal1.Text));
                cmd.Parameters.Add(new SqlParameter("@Total1", txtTukuba_Total1.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }


        /// <summary>
        /// Update Sonota's Data
        /// </summary>
        private void updateSonota(SqlConnection Conn, SqlTransaction Tran)
        {

            //INSERT作成
            //SqlConnection sn = new ;
            String updateSonotaSql = "UPDATE [Jisseki_Sonota] "
                                 + " SET"
                                 + "  [Year]      = @Year "
                                 + " ,[Month]     = @Month "
                                 + " ,[Day]       = @Day "
                                 + " ,[COCODE]    = @COCODE "
                                 + " ,[Kamotu1]   = @Kamotu1 "
                                 + " ,[Kamotu2]   = @Kamotu2 "
                                 + " ,[Kamotu3]   = @Kamotu3 "
                                 + " ,[Kamotu4]   = @Kamotu4 "
                                 + " ,[Bus1]      = @Bus1  "
                                 + " ,[Bus2]      = @Bus2 "
                                 + " ,[JK_J1]     = @JK_J1 "
                                 + " ,[JK_K1]     = @JK_K1 "
                                 + " ,[JK_J2]     = @JK_J2 "
                                 + " ,[JK_K2]     = @JK_K2 "
                                 + " ,[JK_J3]     = @JK_J3 "
                                 + " ,[JK_K3]     = @JK_K3 "
                                 + " ,[SubTotal1] = @SubTotal1 "
                                 + " ,[Total1]    = @Total1 "
                                 + " WHERE COCODE = @COCODE AND YearRep = @YearRep AND MonthRep = @MonthRep ";


            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(updateSonotaSql, Conn, Tran);
                cmd.CommandText = updateSonotaSql;
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

                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));


                //貨物
                cmd.Parameters.Add(new SqlParameter("@Kamotu1", txtSonota_Kamotu1.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu2", txtSonota_Kamotu2.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu3", txtSonota_Kamotu3.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu4", txtSonota_Kamotu4.Text));
                //バス
                cmd.Parameters.Add(new SqlParameter("@Bus1", txtSonota_Bus1.Text));
                cmd.Parameters.Add(new SqlParameter("@Bus2", txtSonota_Bus2.Text));
                //乗用　貨物
                cmd.Parameters.Add(new SqlParameter("@JK_J1", txtSonota_JK_J1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K1", txtSonota_JK_K1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J2", txtSonota_JK_J2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K2", txtSonota_JK_K2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J3", txtSonota_JK_J3.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K3", txtSonota_JK_K3.Text));
                cmd.Parameters.Add(new SqlParameter("@SubTotal1", txtSonota_SubTotal1.Text));
                cmd.Parameters.Add(new SqlParameter("@Total1", txtSonota_Total1.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }


        /// <summary>
        /// Update Goukei's Data
        /// </summary>
        private void updateGoukei(SqlConnection Conn, SqlTransaction Tran)
        {

            //INSERT作成
            //SqlConnection sn = new ;
            String updateGoukeiSql = "UPDATE [Jisseki_Goukei] "
                                 + " SET"
                                 + "  [Year]      = @Year "
                                 + " ,[Month]     = @Month "
                                 + " ,[Day]       = @Day "
                                 + " ,[COCODE]    = @COCODE "
                                 + " ,[Kamotu1]   = @Kamotu1 "
                                 + " ,[Kamotu2]   = @Kamotu2 "
                                 + " ,[Kamotu3]   = @Kamotu3 "
                                 + " ,[Kamotu4]   = @Kamotu4 "
                                 + " ,[Bus1]      = @Bus1  "
                                 + " ,[Bus2]      = @Bus2 "
                                 + " ,[JK_J1]     = @JK_J1 "
                                 + " ,[JK_K1]     = @JK_K1 "
                                 + " ,[JK_J2]     = @JK_J2 "
                                 + " ,[JK_K2]     = @JK_K2 "
                                 + " ,[JK_J3]     = @JK_J3 "
                                 + " ,[JK_K3]     = @JK_K3 "
                                 + " ,[SubTotal1] = @SubTotal1 "
                                 + " ,[Total1]    = @Total1 "
                                 + " WHERE COCODE = @COCODE AND Year = @Year AND Month = @Month AND Day = @Day";


            //Sqlコネクション
            try
            {
                SqlCommand cmd = new SqlCommand(updateGoukeiSql, Conn, Tran);
                cmd.CommandText = updateGoukeiSql;
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
                cmd.Parameters.Add(new SqlParameter("@Year", Utility.HeiseiToChristianEra(txtYear.Text)));
                cmd.Parameters.Add(new SqlParameter("@Month", txtMonth.Text));
                cmd.Parameters.Add(new SqlParameter("@Day", txtDay.Text));


                //貨物
                cmd.Parameters.Add(new SqlParameter("@Kamotu1", txtGoukei_Kamotu1.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu2", txtGoukei_Kamotu2.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu3", txtGoukei_Kamotu3.Text));
                cmd.Parameters.Add(new SqlParameter("@Kamotu4", txtGoukei_Kamotu4.Text));
                //バス
                cmd.Parameters.Add(new SqlParameter("@Bus1", txtGoukei_Bus1.Text));
                cmd.Parameters.Add(new SqlParameter("@Bus2", txtGoukei_Bus2.Text));
                //乗用　貨物
                cmd.Parameters.Add(new SqlParameter("@JK_J1", txtGoukei_JK_J1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K1", txtGoukei_JK_K1.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J2", txtGoukei_JK_J2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K2", txtGoukei_JK_K2.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_J3", txtGoukei_JK_J3.Text));
                cmd.Parameters.Add(new SqlParameter("@JK_K3", txtGoukei_JK_K3.Text));
                cmd.Parameters.Add(new SqlParameter("@SubTotal1", txtGoukei_SubTotal1.Text));
                cmd.Parameters.Add(new SqlParameter("@Total1", txtGoukei_Total1.Text));
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }

        }

        private void updateIdMaster(SqlConnection Conn, SqlTransaction Tran)
        {
            //Update
            string Sql = " UPDATE [ID] "
                      + " SET "
                      + "  [RepName]      =  @RepName      "
                      + " WHERE   "
                      + " COCODE = @COCODE";

            try
            {

                using (SqlCommand cmd = new SqlCommand(Sql, Conn, Tran))
                {
                    cmd.Parameters.Add(new SqlParameter("@COCODE", this.Session["COCODE"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@RepName", this.txtTantou.Text));
                    cmd.ExecuteNonQuery();
                }


            }
            catch
            {
                throw;

            }
        }
        #endregion

        #region "イベント"
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
                     qCOCODE = Session["COCODE"].ToString();
                     qYearRep = Page.Request.QueryString.Get("YearRep");
                     qMonthRep = Page.Request.QueryString.Get("MonthRep");
                 }
                 else 
                 {
                    //自販連
                     jadaUser = true;
                     qCOCODE = Page.Request.QueryString.Get("COCODE");
                     qYearRep = Page.Request.QueryString.Get("YearRep");//西暦
                     qMonthRep = Page.Request.QueryString.Get("MonthRep"); 
    
                 }

                 //接続文字列
                 strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;

                 //Receive Keys by GET
                 //qCOCODE = Page.Request.QueryString.Get("COCODE");
                 //qYearRep = Page.Request.QueryString.Get("YearRep");//西暦
                 //qMonthRep = Page.Request.QueryString.Get("MonthRep"); 



            //     Response.Write(qCOCODE);
            //     Response.Write(qYearRep);
            //     Response.Write(qMonthRep);
            //

                 if (!Page.IsPostBack)
                 {
                     initializeForm();
                     //会員の場合閉め日を過ぎてたら修正できないようにする
                     if (!jadaUser) 
                     {

                         //1～11月の報告書の場合
                         if ( int.Parse(qMonthRep) >= 1 && int.Parse(qMonthRep) <= 11)
                         {
                             if (int.Parse(qYearRep) == DateTime.Today.Year)
                             {
                                 
                                 if (int.Parse(qMonthRep) == DateTime.Today.Month)
                                 {
                                     //同じ月なら編集OK

                                 }
                                 else if (int.Parse(qMonthRep) <= DateTime.Today.AddMonths(-1).Month && DateTime.Today.Day < 6)
                                 {
                                     //翌月で5日以内

                                 }
                                 else if (int.Parse(qMonthRep) <= DateTime.Today.AddMonths(-1).Month && DateTime.Today.Day >= 6)
                                 {
                                     //翌月で6日以降
                                     this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                     this.lblMsg.BackColor = System.Drawing.Color.Pink;
                                     this.btnSubmit.Enabled = false;
                                 }
                             }
                             else 
                             {
                                 this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                 this.lblMsg.BackColor = System.Drawing.Color.Pink;
                                 this.btnSubmit.Enabled = false;
                             
                             }                             
                             
                         }
                         else
                         {
                             //12月の報告書の場合
                             if (int.Parse(qYearRep) == DateTime.Today.Year)
                             {
                                 //編集OK
                             }
                             else 
                             {

                                 if (int.Parse(qMonthRep) == DateTime.Today.Month)
                                 {
                                     //同じ年なら編集OK

                                 }
                                 else if (DateTime.Today.Day < 6)
                                 {
                                     //翌月で5日以内

                                 }
                                 else if (DateTime.Today.Day >= 6)
                                 {
                                     //翌月で6日以降
                                     this.lblMsg.Text = "５日を過ぎているので修正できません。";
                                     this.lblMsg.BackColor = System.Drawing.Color.Pink;
                                     this.btnSubmit.Enabled = false;
                                 }

                             }
                             
                         }
                   
                     }

                 }
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

            }
            catch
            {

            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //入力チェックTODO サーバーサイドのチェック
            //サーバー再度でも念のため
            
            //データを整える
            //何もないときは0に変換する
            ////ヘッダー
            //this.Header_ConvertNothingTo0();
            //水戸
            this.Mito_ConvertNothingTo0();
            //土浦
            this.Tuchiura_ConvertNothingTo0();
            //つくば
            this.Tukuba_ConvertNothingTo0();
            //その他
            this.Sonota_ConvertNothingTo0();
            //合計
            this.Goukei_ConvertNothingTo0();

            /**********/
            //チェック//
            /**********/
            //ヘッダー
            if (!this.HeaderIsValid()) {
                return;
            }

            //水戸
            if (!this.MitoIsValid()) {
                this.lblMsg.Text="水戸の欄に整数以外の項目が入力されています。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return ;
            }
            //土浦
            if (!this.TuchiuraIsValid()) {
                this.lblMsg.Text = "土浦の欄に整数以外の項目が入力されています。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            //つくば
            if (!this.TukubaIsValid()) {
                this.lblMsg.Text = "つくばの欄に整数以外の項目が入力されています。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            //その他
            if (!this.SonotaIsValid()) {
                this.lblMsg.Text = "その他の欄に整数以外の項目が入力されています。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            //合計
            if (!this.GoukeiIsValid()) {
                this.lblMsg.Text = "合計の欄に整数以外の項目が入力されています。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }


            try
            {
                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlTransaction Tran = Conn.BeginTransaction())
                    {
                        try
                        {
                            //ヘッダー
                            this.updateHeader(Conn, Tran);

                            //水戸
                            this.updateMito(Conn,Tran);

                            //土浦
                            this.updateTuchiura(Conn, Tran);

                            //つくば
                            this.updateTukuba(Conn, Tran);

                            //その他
                            this.updateSonota(Conn, Tran);

                            //合計
                            this.updateGoukei(Conn, Tran);

                            //会員のとき
                            if (this.Session["Member"].ToString().Trim() == "1")
                            {

                                this.updateIdMaster(Conn, Tran);
                             
                            }

                            //Commit Transaction
                            Tran.Commit();
                            btnSubmit.Enabled = false;
                            this.lblMsg.Text = "修正しました";
                            this.lblMsg.BackColor = System.Drawing.Color.Pink;
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
                //Response.Write("<p style=background-color:red;>" + ex.Message + "</p>");
                //Response.Write("<p style=background-color:red;>" + ex.StackTrace + "</p>");
            }           
                        
       }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

           //セッションで渡す
            if (jadaUser)
            {

                //自販連ユーザー
                this.Session["Jisseki_Report_COCODE"] = qCOCODE;
                this.Session["Jisseki_Report_YearRep"] = Utility.HeiseiToChristianEra(this.txtYearRep0.Text);
                this.Session["Jisseki_Report_MonthRep"] = this.txtMonthRep0.Text;
       
                
            }
            else 
            {
                //会員
                this.Session["Jisseki_Report_COCODE"] = this.Session["COCODE"];
                this.Session["Jisseki_Report_YearRep"] = Utility.HeiseiToChristianEra(this.txtYearRep0.Text);
                this.Session["Jisseki_Report_MonthRep"] = this.txtMonthRep0.Text;
            }
             
            string js = "";
            js += "<script language='JavaScript'>";
            js += "window.open('" + URL.REPORT_JISSEKI_REPORT_JS + "')";
            js += "</script>";
          
            Page.ClientScript.RegisterStartupScript(this.GetType(), "startup", js);

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(URL.LOGIN_DEALER);
        }

        protected void btnKariInvoice_Click(object sender, EventArgs e)
        {

            //セッションで渡す
            if (jadaUser)
            {

                //自販連ユーザー
                this.Session["Jisseki_Report_COCODE"] = qCOCODE;
                this.Session["Jisseki_Report_YearRep"] = Utility.HeiseiToChristianEra(this.txtYearRep0.Text);
                this.Session["Jisseki_Report_MonthRep"] = this.txtMonthRep0.Text;


            }
            else
            {
                //会員
                this.Session["Jisseki_Report_COCODE"] = this.Session["COCODE"];
                this.Session["Jisseki_Report_YearRep"] = Utility.HeiseiToChristianEra(this.txtYearRep0.Text);
                this.Session["Jisseki_Report_MonthRep"] = this.txtMonthRep0.Text;
            }

            string js = "";
            js += "<script language='JavaScript'>";
            js += "window.open('" + URL.REPORT_KARI_INVOICE_REPORT_JS + "')";
            js += "</script>";

            Page.ClientScript.RegisterStartupScript(this.GetType(), "startup", js);

        }

        #endregion

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
            catch { 
            
            }
        }
    }
}