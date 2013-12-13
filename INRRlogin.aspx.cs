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
using Jisseki_Report_Ibaraki.Tools;

namespace Jisseki_Report_Ibaraki
{
    public partial class INRRlogin: System.Web.UI.Page
    {
        //接続文字列
        private String strConn;
 
        protected void Page_Load(object sender, EventArgs e)
        {
            //PageLoad and PostBack
            //接続文字列
            strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;            

            //Only PostBack
            if (!IsPostBack)
            {
                //クッキーにあれば自動セット

                if (Request.Cookies["UID"] != null)
                {
                    txtCOCODE.Text = Server.HtmlEncode(Request.Cookies["UID"].Value);
                }

                if (Request.Cookies["Password"] != null)
                {
                   txtPassword.Text = Server.HtmlEncode(Request.Cookies["Password"].Value);
                }    
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    string strSQL = "SELECT * FROM Jisseki_Report_Ibaraki.dbo.ID WHERE UID = @UID AND Password = @Password ";

                    SqlCommand cmd = new SqlCommand(strSQL, Conn);
                    cmd.Parameters.Add(new SqlParameter("@UID", txtCOCODE.Text));
                    cmd.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //ログインOK

                        //クッキーに登録
                        HttpCookie cookieUID = new HttpCookie("UID");
                        cookieUID.Value = txtCOCODE.Text;
                        cookieUID.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(cookieUID);

                        HttpCookie cookiePassword = new HttpCookie("Password");
                        cookiePassword.Value = txtPassword.Text;
                        cookiePassword.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(cookiePassword);

                        //セッションに情報入力
                        reader.Read();
                        Session["COCODE"] = reader["COCODE"];
                        Session["CONAME"] = reader["CONAME"];
                        Session["Member"] = reader["Member"];
                        Session["MemberType"] = reader["MemberType"];//通常:0・賛助:1

                        if (reader["Member"].ToString().Trim().Equals("1"))
                        {
                            //会員メニュー
                            Response.Redirect(URL.MENU_DEALER);
                        }
                        else
                        {
                            //自販連メニュー
                            Response.Redirect(URL.MENU_JADA);
                        }
                    }
                    else
                    {
                        //ログインNG           
                        this.lblMsg.Text = "ログインIDまたはパスワードが違います。";
                        this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    }
                }
            }
            catch (Exception ex)
            {
                this.lblMsg.Text = ex.Message;
                this.lblMsg.BackColor = System.Drawing.Color.Pink;

            }
        }
    }
}