using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Jisseki_Report_Ibaraki.Tools;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Jisseki_Report_Ibaraki.jada.master
{
    public partial class UnitPriceMaster : System.Web.UI.Page
    {
        private string strConn;
        //private string Key;

        private void getUnitPrice(){
            try{
                if (!Page.IsPostBack)
                {
                    string Sql = "SELECT TOP 1 *  FROM [dbo].[UnitPrice]";
                    using (SqlConnection Conn = new SqlConnection(strConn))
                    {
                        Conn.Open();
                        using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                        {

                            SqlDataReader Reader = cmd.ExecuteReader();
                            if (Reader.HasRows)
                            {
                                Reader.Read();
                                this.txtBigSize.Text = Reader["BigSize"].ToString();
                                this.txtMediumSmall.Text = Reader["MediumSmall"].ToString();
                                this.txtAverage.Text = Reader["Average"].ToString();
                                this.txtShibuFee.Text = Reader["ShibuFee"].ToString();//20140106 Igarashi 支部費追加
                                this.txtKamotu7t.Text = Reader["Kamotu7t"].ToString();
                                this.txtKamotu6DP9_5t.Text = Reader["Kamotu6DP9_5t"].ToString();
                                this.txtKamotu4DP9_3t.Text = Reader["Kamotu4DP9_3t"].ToString();
                                this.txtKamotu2DP9_2DP5t.Text = Reader["Kamotu2DP9_2DP5t"].ToString();
                                this.txtOver2001cc.Text = Reader["Over2001cc"].ToString();
                                this.txtTo2000From1000cc.Text = Reader["To2000From1000cc"].ToString();
                                this.txtOver30.Text = Reader["Over30"].ToString();
                                this.txtLessThan29.Text = Reader["LessThan29"].ToString();
                                this.txtMemberFee.Text = Reader["MemberFee"].ToString();
                                this.ViewState["Code"] = Reader["Code"].ToString();

                            }
                        }
                    }
            
                 }
            }
            catch
            {

            }
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //ログインしていなければ表示しない
                if (Session["COCODE"] == null)
                {
                    Response.Redirect(URL.LOGIN_DEALER);
                }

                //接続文字列
                strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;

                getUnitPrice();
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

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {

            try
            {
                //入力チェック
                if (Utility.IsNotNumber(this.txtBigSize.Text))
                {
                    this.txtBigSize.BackColor = System.Drawing.Color.Pink;
                    this.txtBigSize.Focus();
                    return;
                }
                else
                {
                    this.txtBigSize.BackColor = System.Drawing.Color.White;
                }


                if (Utility.IsNotNumber(this.txtMediumSmall.Text))
                {
                    this.txtMediumSmall.BackColor = System.Drawing.Color.Pink;
                    this.txtMediumSmall.Focus();
                    return;
                }
                else
                {
                    this.txtMediumSmall.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtAverage.Text))
                {
                    this.txtAverage.BackColor = System.Drawing.Color.Pink;
                    this.txtAverage.Focus();
                    return;
                }
                else
                {
                    this.txtAverage.BackColor = System.Drawing.Color.White;
                }

                //20140106 Igarashi 支部費追加
                if (Utility.IsNotNumber(this.txtShibuFee.Text))
                {
                    this.txtShibuFee.BackColor = System.Drawing.Color.Pink;
                    this.txtShibuFee.Focus();
                    return;
                }
                else
                {
                    this.txtShibuFee.BackColor = System.Drawing.Color.White;
                }


                if (Utility.IsNotNumber(this.txtKamotu7t.Text))
                {
                    this.txtKamotu7t.BackColor = System.Drawing.Color.Pink;
                    this.txtKamotu7t.Focus();
                    return;
                }
                else
                {
                    this.txtKamotu7t.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtKamotu6DP9_5t.Text))
                {
                    this.txtKamotu6DP9_5t.BackColor = System.Drawing.Color.Pink;
                    this.txtKamotu6DP9_5t.Focus();
                    return;
                }
                else
                {
                    this.txtKamotu6DP9_5t.BackColor = System.Drawing.Color.White;
                }


                if (Utility.IsNotNumber(this.txtKamotu4DP9_3t.Text))
                {
                    this.txtKamotu4DP9_3t.BackColor = System.Drawing.Color.Pink;
                    this.txtKamotu4DP9_3t.Focus();
                    return;
                }
                else
                {
                    this.txtKamotu4DP9_3t.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtKamotu2DP9_2DP5t.Text))
                {
                    this.txtKamotu2DP9_2DP5t.BackColor = System.Drawing.Color.Pink;
                    this.txtKamotu2DP9_2DP5t.Focus();
                    return;
                }
                else
                {
                    this.txtKamotu2DP9_2DP5t.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtOver2001cc.Text))
                {
                    this.txtOver2001cc.BackColor = System.Drawing.Color.Pink;
                    this.txtOver2001cc.Focus();
                    return;
                }
                else
                {
                    this.txtOver2001cc.BackColor = System.Drawing.Color.White;
                }


                if (Utility.IsNotNumber(this.txtTo2000From1000cc.Text))
                {
                    this.txtTo2000From1000cc.BackColor = System.Drawing.Color.Pink;
                    this.txtTo2000From1000cc.Focus();
                    return;
                }
                else
                {
                    this.txtTo2000From1000cc.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtOver30.Text))
                {
                    this.txtOver30.BackColor = System.Drawing.Color.Pink;
                    this.txtOver30.Focus();
                    return;
                }
                else
                {
                    this.txtOver30.BackColor = System.Drawing.Color.White;
                }


                if (Utility.IsNotNumber(this.txtLessThan29.Text))
                {
                    this.txtLessThan29.BackColor = System.Drawing.Color.Pink;
                    this.txtLessThan29.Focus();
                    return;
                }
                else
                {
                    this.txtLessThan29.BackColor = System.Drawing.Color.White;
                }

                if (Utility.IsNotNumber(this.txtMemberFee.Text))
                {
                    this.txtMemberFee.BackColor = System.Drawing.Color.Pink;
                    this.txtMemberFee.Focus();
                    return;
                }
                else
                {
                    this.txtMemberFee.BackColor = System.Drawing.Color.White;
                }


            }
            catch 
            { 
            
            }
            String Sql = "UPDATE [dbo].[UnitPrice]"
                        + "  SET  "
                        + "      [BigSize]          = @BigSize "
                        + "     ,[MediumSmall]      = @MediumSmall "
                        + "     ,[Average]          = @Average"
                        + "     ,[ShibuFee]         = @ShibuFee"//20140106 Igarashi 支部費追加
                        + "     ,[Kamotu7t]         = @Kamotu7t "
                        + "     ,[Kamotu6DP9_5t]    = @Kamotu6DP9_5t "
                        + "     ,[Kamotu4DP9_3t]    = @Kamotu4DP9_3t "
                        + "     ,[Kamotu2DP9_2DP5t] = @Kamotu2DP9_2DP5t "
                        + "     ,[Over2001cc]       = @Over2001cc "
                        + "     ,[To2000From1000cc] = @To2000From1000cc "
                        + "     ,[Over30]           = @Over30 "
                        + "     ,[LessThan29]       = @LessThan29 "
                        + "     ,[MemberFee]        = @MemberFee "
                        + "WHERE [Code] = @Code ";

            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlTransaction Tran = Conn.BeginTransaction())
                {
                    try
                    {

                        using (SqlCommand cmd = new SqlCommand(Sql, Conn, Tran))
                        {
                            cmd.Parameters.Add(new SqlParameter("@BigSize", this.txtBigSize.Text));
                            cmd.Parameters.Add(new SqlParameter("@MediumSmall", this.txtMediumSmall.Text));
                            cmd.Parameters.Add(new SqlParameter("@Average", this.txtAverage.Text));
                            cmd.Parameters.Add(new SqlParameter("@ShibuFee", this.txtShibuFee.Text));//20140106 Igarashi 支部費追加
                            cmd.Parameters.Add(new SqlParameter("@Kamotu7t", this.txtKamotu7t.Text));
                            cmd.Parameters.Add(new SqlParameter("@Kamotu6DP9_5t", this.txtKamotu6DP9_5t.Text));
                            cmd.Parameters.Add(new SqlParameter("@Kamotu4DP9_3t", this.txtKamotu4DP9_3t.Text));
                            cmd.Parameters.Add(new SqlParameter("@Kamotu2DP9_2DP5t", this.txtKamotu2DP9_2DP5t.Text));

                            cmd.Parameters.Add(new SqlParameter("@Over2001cc", this.txtOver2001cc.Text));
                            cmd.Parameters.Add(new SqlParameter("@To2000From1000cc", this.txtTo2000From1000cc.Text));

                            cmd.Parameters.Add(new SqlParameter("@Over30", this.txtOver30.Text));
                            cmd.Parameters.Add(new SqlParameter("@LessThan29", this.txtLessThan29.Text));
                            cmd.Parameters.Add(new SqlParameter("@MemberFee", this.txtMemberFee.Text));

                            cmd.Parameters.Add(new SqlParameter("@Code", this.ViewState["Code"].ToString()));
                            cmd.ExecuteNonQuery();


                        }

                        Tran.Commit();
                        //setGridView();
                        this.lblMsg.Text = "更新しました";
                        this.lblMsg.BackColor = System.Drawing.Color.Pink;

                    }
                    catch 
                    {
                        this.lblMsg.Text = "更新できませんでした。";
                        Tran.Rollback();

                    }
                }

            }
        }

    }
}