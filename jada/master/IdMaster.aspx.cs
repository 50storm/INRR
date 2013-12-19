using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Jisseki_Report_Ibaraki.Tools;

namespace Jisseki_Report_Ibaraki.jada.master
{
    public partial class IdMaster : System.Web.UI.Page
    {
        private string strConn;
        private void clearMsg(){
            this.lblMsg.Text="";
            
        }
        private Boolean UIDisRegisterd(out string strCOCODE,out string strCONAME)
        {
            try
            {
                string Sql = " SELECT * FROM [Jisseki_Report_Ibaraki].dbo.ID WHERE UID=@UID ";
                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                    {

                        cmd.Parameters.Add(new SqlParameter("@UID", this.txtUID.Text));

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                Reader.Read();
                                strCOCODE = Reader["COCODE"].ToString();
                                strCONAME = Reader["CONAME"].ToString();
                                return true;
                            }
                            else
                            {
                                strCOCODE = "";
                                strCONAME = "";
                                return false;
                            }

                        }
                    }

                }
            }
            catch
            {
                throw;

            }

        }
        private Boolean COCODEisRegisterd(out string strCONAME) {
            try
            {
                string Sql = " SELECT * FROM [Jisseki_Report_Ibaraki].dbo.ID WHERE COCODE=@COCODE ";
                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                    {

                        cmd.Parameters.Add(new SqlParameter("@COCODE", this.txtCOCODE.Text));

                        using (SqlDataReader Reader = cmd.ExecuteReader()) {
                            if (Reader.HasRows)
                            {
                                Reader.Read();
                                strCONAME = Reader["CONAME"].ToString();
                                return true;
                            }
                            else 
                            {
                                strCONAME = "";
                                return false;
                            }
                        
                        }
                    }
                    
                }
            }
            catch 
            {
                throw;

            }     
        
        }

        private void insertUnitPrice()
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
                        //登録
                        string InsertSQL = "INSERT INTO [Jisseki_Report_Ibaraki].[dbo].[UnitPrice] "
                                        + " ([Code] ,[BigSize] ,[MediumSmall] ,[Average] ,[Kamotu7t] ,[Kamotu6DP9_5t] "
                                        + "  ,[Kamotu4DP9_3t] ,[Kamotu2DP9_2DP5t] ,[Over2001cc] ,[To2000From1000cc] "
                                        + "  ,[Over30] ,[LessThan29] ,[MemberFee] ,[COCODE]) "
                                        + "VALUES"
                                        + "("
                                        +"  @Code"
                                        +" ,@BigSize"
                                        +" ,@MediumSmall"
                                        +" ,@Average"
                                        +" ,@Kamotu7t"
                                        +" ,@Kamotu6DP9_5t"
                                        +" ,@Kamotu4DP9_3t"
                                        +" ,@Kamotu2DP9_2DP5t"
                                        +" ,@Over2001cc"
                                        +" ,@To2000From1000cc"
                                        +" ,@Over30"
                                        +" ,@LessThan29"
                                        +" ,@MemberFee"
                                        +" ,@COCODE"
            
                                        + ")";
                        using (SqlConnection ConnIns = new SqlConnection(strConn))
                        {
                            ConnIns.Open();
                            //using (SqlTransaction Tran = ConnIns.BeginTransaction())
                            //{

                                SqlCommand InsertCmd = new SqlCommand();
                                InsertCmd.Connection = ConnIns;
                                InsertCmd.CommandText = InsertSQL;
                                //InsertCmd.Transaction = Tran;
                                InsertCmd.Parameters.Add(new SqlParameter("@Code", Reader["Code"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@BigSize", Reader["BigSize"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@MediumSmall", Reader["MediumSmall"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Average", Reader["Average"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Kamotu7t", Reader["Kamotu7t"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Kamotu6DP9_5t", Reader["Kamotu6DP9_5t"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Kamotu4DP9_3t", Reader["Kamotu4DP9_3t"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Kamotu2DP9_2DP5t", Reader["Kamotu2DP9_2DP5t"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Over2001cc", Reader["Over2001cc"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@To2000From1000cc", Reader["To2000From1000cc"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@Over30", Reader["Over30"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@LessThan29", Reader["LessThan29"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@MemberFee", Reader["MemberFee"].ToString()));
                                InsertCmd.Parameters.Add(new SqlParameter("@COCODE", this.txtCOCODE.Text));
                                InsertCmd.ExecuteNonQuery();


                            //}
                        }
                    }
                }
            }    
        
        }

        private void setGridView() {
            try
            {
                string Sql = " SELECT * FROM [Jisseki_Report_Ibaraki].dbo.ID ";
                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                    {
                        using (SqlDataAdapter Adapter = new SqlDataAdapter(Sql, Conn))
                        {
                            Adapter.SelectCommand = cmd;
                            DataTable ID = new DataTable("IDマスタ");
                            Adapter.Fill(ID);
                            if (ID.Rows.Count == 0)
                            {
                                GridView1.EmptyDataText = "IDマスタに登録がありません。";
                            }
                            else
                            {

                                GridView1.DataSource = ID;
                                GridView1.DataBind();
                            }
                        }
                    }
                    Conn.Close();
                }
            }
            catch
            {

            }        
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            try{

                //ログインしていなければ表示しない
                if (Session["COCODE"] == null)
                {
                    Response.Redirect(URL.LOGIN_DEALER);
                }


                //接続文字列
                strConn = ConfigurationManager.ConnectionStrings["JissekiConnectionString"].ConnectionString;
                setGridView();
                clearMsg();


            }catch{
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = GridView1.SelectedIndex;
                String Sql = " SELECT * FROM Jisseki_Report_Ibaraki.dbo.ID "
                           + " WHERE "
                           + " COCODE = @COCODE ";


                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                    {

                        cmd.Parameters.Add(new SqlParameter("@COCODE", GridView1.Rows[i].Cells[1].Text));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtCOCODE.Text = reader["COCODE"].ToString();
                                Session["tmpCOCODE"] = reader["COCODE"].ToString();

                                if (reader["UID"] == null)
                                {
                                    txtUID.Text = "";
                                }
                                else 
                                {
                                    txtUID.Text = reader["UID"].ToString();
                                }
                                
                                if(reader["CONAME"] == null )
                                {
                                    txtCONAME.Text = "";
                                }else
                                {
                                    txtCONAME.Text = reader["CONAME"].ToString();
                                }

                                if (reader["RepName"] == null)
                                {
                                    txtRepName.Text = "";
                                }
                                else
                                {
                                    txtRepName.Text = reader["RepName"].ToString();
                                }

                                if (reader["PostalCode"] == null)
                                {
                                    txtPostalCode.Text = "";
                                }
                                else
                                {
                                    txtPostalCode.Text = reader["PostalCode"].ToString();
                                }

                                if (reader["Address"] ==null)
                                {
                                    txtAddress.Text = "";
                                }else
                                {
                                    txtAddress.Text = reader["Address"].ToString();
                                }

                                if (reader["Tel"] == null)
                                {
                                    txtTel.Text = "";
                                }
                                else
                                {
                                    txtTel.Text = reader["Tel"].ToString();
                                }

                                if (reader["Password"] == null)
                                {
                                    txtPassword.Text = "";
                                }else
                                {
                                    txtPassword.Text = reader["Password"].ToString();
                                }

                                if (reader["Member"] == null)
                                {
                                    txtMember.Text = "";
                                }
                                else
                                {
                                    txtMember.Text = reader["Member"].ToString();
                                }
                                
                                if (reader["MemberType"] == null) 
                                {
                                    txtMemberType.Text = "";
                                }
                                else
                                {
                                    txtMemberType.Text = reader["MemberType"].ToString();
                                }
                                if (reader["short_CONAME"] == null)
                                {
                                    txtshort_CONAME.Text = "";
                                }
                                else 
                                {
                                    txtshort_CONAME.Text = reader["short_CONAME"].ToString();
                                }

                                
                                if (reader["Position"] == null)
                                {
                                    txtPosition.Text = "";
                                }
                                else
                                {
                                    txtPosition.Text = reader["Position"].ToString();
                                }

                                if (reader["isCanceled"] == null)
                                {
                                    txtisCanceled.Text = "";
                                }
                                else
                                {
                                    txtisCanceled.Text = reader["isCanceled"].ToString();
                                }
                                
                            }
                            else
                            {
                                return;
                            }

                        }

                    }
                    Conn.Close();
                }
            }
            catch { 
            
            
            }

        }
#region"ボタン"
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (Session["tmpCOCODE"].ToString().Trim() != this.txtCOCODE.Text.Trim())
            {
                this.lblMsg.Text = "会員コード[" + Session["tmpCOCODE"].ToString().Trim() + "]が[" + this.txtCOCODE.Text + "]に変更されています。更新できません。";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            else 
            {
                this.lblMsg.Text = "";
                this.lblMsg.BackColor = System.Drawing.Color.White;
            }

            //Update
            string Sql= " UPDATE [Jisseki_Report_Ibaraki].[dbo].[ID] "
                      + " SET "
                      + "   [COCODE]       =  @COCODE       "
                      + "  ,[UID]          =  @UID          "
                      + "  ,[CONAME]       =  @CONAME       "
                      + "  ,[RepName]      =  @RepName      "
                      + "  ,[PostalCode]   =  @PostalCode   "
                      + "  ,[Address]      =  @Address      "
                      + "  ,[Tel]          =  @Tel          "
                      + "  ,[Password]     =  @Password     "
                      + "  ,[Member]       =  @Memeber      "
                      + "  ,[MemberType]   =  @MemeberType  "
                      + "  ,[short_CONAME] =  @short_CONAME "
                      + "  ,[Position]     =  @Position     "
                      + "  ,[isCanceled]   =  @isCanceled     "
                      + " WHERE   "
                            //Key
                      + " COCODE = @Key"
                      ;

            
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                using (SqlTransaction Tran = Conn.BeginTransaction())
                {
                    try
                    {
                        
                        using (SqlCommand cmd = new SqlCommand(Sql, Conn, Tran))
                        {
                            cmd.Parameters.Add(new SqlParameter("@COCODE", this.txtCOCODE.Text));
                            cmd.Parameters.Add(new SqlParameter("@UID", this.txtUID.Text));
                            cmd.Parameters.Add(new SqlParameter("@CONAME", this.txtCONAME.Text));
                            cmd.Parameters.Add(new SqlParameter("@RepName", this.txtRepName.Text));
                            cmd.Parameters.Add(new SqlParameter("@PostalCode", this.txtPostalCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@Address", this.txtAddress.Text));
                            cmd.Parameters.Add(new SqlParameter("@Tel", this.txtTel.Text));
                            cmd.Parameters.Add(new SqlParameter("@Password", this.txtPassword.Text));
                            cmd.Parameters.Add(new SqlParameter("@Memeber", this.txtMember.Text));
                            cmd.Parameters.Add(new SqlParameter("@MemeberType", this.txtMemberType.Text));
                            cmd.Parameters.Add(new SqlParameter("@short_CONAME", this.txtshort_CONAME.Text));
                            cmd.Parameters.Add(new SqlParameter("@Position", this.txtPosition.Text));
                            cmd.Parameters.Add(new SqlParameter("@isCanceled", this.txtisCanceled.Text));
                            cmd.Parameters.Add(new SqlParameter("@Key", this.txtCOCODE.Text));
                            
                            if (cmd.ExecuteNonQuery() == 0) 
                            {
                                this.lblMsg.Text = "";
                                return;
                            }


                        }

                        Tran.Commit();
                        setGridView();
                        this.lblMsg.Text = "更新しました。会員コード[" + this.txtCOCODE.Text + "]" + "　会員名[" + this.txtCONAME.Text + "]"; 
                        this.lblMsg.BackColor = System.Drawing.Color.Pink;

                    }
                    catch (Exception ex)
                    {
                        this.lblMsg.Text = ex.Message;
                        Tran.Rollback();

                    }
                }

            }

            //GridViewでバインド

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            //削除
            try
            {

                if (Session["tmpCOCODE"].ToString().Trim() != this.txtCOCODE.Text.Trim())
                {
                    this.lblMsg.Text = "会員コード[" + Session["tmpCOCODE"].ToString().Trim() + "]が[" + this.txtCOCODE.Text + "]に変更されています。削除できません。";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;
                }
                else
                {
                    this.lblMsg.Text = "";
                    this.lblMsg.BackColor = System.Drawing.Color.White;
                }

                string strCONAME=String.Empty;

                if (!COCODEisRegisterd(out strCONAME))
                {
                    //削除済
                    this.lblMsg.Text = "会員コード["   + this.txtCOCODE.Text + "]は会員マスターにありません";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    return;

                }
                else 
                {
                    this.lblMsg.Text = "";
                    this.lblMsg.BackColor = System.Drawing.Color.White;

                }
                //登録データを削除する
                //ID,単価,新車新規登録台数すべて削除
                string Sql = " DELETE FROM  [Jisseki_Report_Ibaraki].dbo.ID "
                           + " WHERE COCODE = @Key; "
                           + " DELETE FROM [Jisseki_Report_Ibaraki].[dbo].[UnitPrice] "
                           + " WHERE COCODE = @Key; "                          
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Header] "
                           + " WHERE COCODE = @Key; "
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Mito] "
                           + " WHERE COCODE = @Key; "
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tuchiura] "
                           + " WHERE COCODE = @Key; "
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Tukuba] "
                           + " WHERE COCODE = @Key; "
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Sonota] "
                           + " WHERE COCODE = @Key; "
                           + " DELETE [Jisseki_Report_Ibaraki].[dbo].[Jisseki_Goukei]"
                           + " WHERE COCODE = @Key; "
                           ;


                using (SqlConnection Conn = new SqlConnection(strConn))
                {
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, Conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Key", this.txtCOCODE.Text));
                        cmd.ExecuteNonQuery();

                        setGridView();
                        this.lblMsg.Text = "削除しました";
                        this.lblMsg.BackColor = System.Drawing.Color.Pink;

                    }
                }
            }
            catch (Exception ex)
            {
                this.lblMsg.Text = ex.Message;

            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //会員コード
            if (txtCOCODE.Text.Trim() == string.Empty)
            {
                this.lblMsg.Text = "会員コードは必須です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtCOCODE.Focus();
                return;

            }
            else 
            {
                this.lblMsg.Text = "";
                this.txtCOCODE.BackColor = System.Drawing.Color.White;
            }
            //ログインID
            if (txtUID.Text.Trim() == string.Empty)
            {
                this.lblMsg.Text = "ログインIDは必須です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtUID.Focus();
                return;

            }
            else
            {
                this.lblMsg.Text = "";
                this.txtUID.BackColor = System.Drawing.Color.White;
            }

            //会員フラグ
            if (txtMember.Text.Trim() == string.Empty)
            {
                this.lblMsg.Text = "会員フラグは必須です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMember.Focus();
                return;

            }
            else
            {
                this.lblMsg.Text = "";
                this.txtMember.BackColor = System.Drawing.Color.White;
            }
            if (txtMember.Text.Trim() != "0" && txtMember.Text.Trim() != "1")
            {
                this.lblMsg.Text = "会員フラグは0か1を入力してください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMember.Focus();
                return;
            }
            else 
            {
                this.lblMsg.Text = "";
                this.txtMember.BackColor = System.Drawing.Color.White;
            }
            //ポジション
            if (Utility.IsNotNumber(txtPosition.Text))
            {
                this.lblMsg.Text = "ポジションは数値を入力してください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtPosition.Focus();
                return;
            }
            else
            {
                this.lblMsg.Text = "";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
            }

            //会員種別
            if (txtMemberType.Text.Trim() == string.Empty)
            {
                this.lblMsg.Text = "会員種別は必須です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.lblMsg.BackColor = System.Drawing.Color.Pink; 
                this.txtMemberType.Focus();
                return;
            }
            else
            {
                this.lblMsg.BackColor = System.Drawing.Color.Pink; lblMsg.Text = "";
                this.txtMemberType.BackColor = System.Drawing.Color.White;
            }

            if (txtMemberType.Text.Trim() != "0" && txtMemberType.Text.Trim() != "1")
            {
                this.lblMsg.Text = "会員種別は0か1を入力してください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtMemberType.Focus();
                return;
            }
            else 
            {
                this.lblMsg.Text = "";
                this.txtMemberType.BackColor = System.Drawing.Color.White;
            }

            //退会フラグ
            if (Utility.IsNotNumber(txtisCanceled.Text))
            {
                this.lblMsg.Text = "退会フラグは数値を入力してください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtisCanceled.Focus();
                return;
            }
            else 
            {
                this.lblMsg.Text = "";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
            }
            if (txtisCanceled.Text.Trim() != "0" && txtisCanceled.Text.Trim() != "1")
            {
                this.lblMsg.Text = "退会フラグは0か1を入力してください";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                this.txtisCanceled.Focus();
                return;
            }
            else
            {
                this.lblMsg.Text = "";
                this.txtisCanceled.BackColor = System.Drawing.Color.White;
            }

            //重複チェック
            string strCOCODE = string.Empty;
            string strCONAME = string.Empty;
            if (COCODEisRegisterd(out strCONAME))
            {
                this.lblMsg.Text = "会員コード[" + this.txtCOCODE.Text + "]" +
                                   "は会員名[" + strCONAME +
                                   "]で既に登録済です";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            else
            {
                this.lblMsg.Text = "";
                this.txtCOCODE.BackColor = System.Drawing.Color.White;
            }

            if (UIDisRegisterd(out strCOCODE, out strCONAME))
            {
                this.lblMsg.Text = "ログインID[" + this.txtUID.Text + "]" +
                                   "は会員コード["   + strCOCODE + "]" + "[" + strCONAME + "]にて既に使われています";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;
                return;
            }
            else
            {
                this.lblMsg.Text = "";
                this.txtCOCODE.BackColor = System.Drawing.Color.White;
            }

            
            
            string Sql = " INSERT INTO [Jisseki_Report_Ibaraki].[dbo].[ID] "
                         + "(" 
                         + " [COCODE] "
                         + ",[UID] "
                         + ",[CONAME] "
                         + ",[RepName] "
                         + ",[PostalCode] "
                         + ",[Address] "
                         + ",[Tel] "
                         + ",[Password] "
                         + ",[Member] "
                         + ",[MemberType] "
                         + ",[short_CONAME] "
                         + ",[Position] "
                         + ",[isCanceled] " 
                         + ")"
                         + " VALUES "         
                         + "("
                         + " @COCODE "
                         + ",@UID    "
                         + ",@CONAME "
                         + ",@RepName "
                         + ",@PostalCode "
                         + ",@Address "
                         + ",@Tel "
                         + ",@Password "
                         + ",@Member "
                         + ",@MemberType "
                         + ",@short_CONAME "
                         + ",@Position "
                         + ",@isCanceled"
                         + ")";

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

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = Conn;
                            cmd.CommandText = Sql;
                            cmd.Transaction = Tran;
                            cmd.Parameters.Add(new SqlParameter("@COCODE", this.txtCOCODE.Text));
                            cmd.Parameters.Add(new SqlParameter("@UID", this.txtUID.Text));
                            cmd.Parameters.Add(new SqlParameter("@CONAME", this.txtCONAME.Text));
                            cmd.Parameters.Add(new SqlParameter("@RepName", this.txtRepName.Text));
                            cmd.Parameters.Add(new SqlParameter("@PostalCode", this.txtPostalCode.Text));
                            cmd.Parameters.Add(new SqlParameter("@Address", this.txtAddress.Text));
                            cmd.Parameters.Add(new SqlParameter("@Tel", this.txtTel.Text));
                            cmd.Parameters.Add(new SqlParameter("@Password", this.txtPassword.Text));
                            cmd.Parameters.Add(new SqlParameter("@Member", this.txtMember.Text));
                            cmd.Parameters.Add(new SqlParameter("@MemberType", this.txtMemberType.Text));
                            cmd.Parameters.Add(new SqlParameter("@short_CONAME", this.txtshort_CONAME.Text));
                            cmd.Parameters.Add(new SqlParameter("@Position", this.txtPosition.Text));
                            cmd.Parameters.Add(new SqlParameter("@isCanceled", this.txtisCanceled.Text));
                            cmd.ExecuteNonQuery();


                            //単価マスタも登録する
                            this.insertUnitPrice();



                            //Commit Transaction
                            Tran.Commit();
                            this.setGridView();
                            this.lblMsg.Text = "登録しました。 会員コード[" + this.txtCOCODE.Text + "]" +  "　会員名[" + this.txtCONAME.Text +"]";
                            this.lblMsg.BackColor = System.Drawing.Color.Pink;

                        }
                        catch
                        {
                            //Rollback Transaction
                            Tran.Rollback();
                            throw;

                        }

                    }
                }


            }
            catch (SqlException SqlEx)
            {
                if (SqlEx.Number == 2627)
                {                    
                    this.lblMsg.Text="既に登録済です";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                    //Response.Write("<p style=background-color:red;>既に登録済です</p>");
                }
                else
                {
                    //Response.Write("<p style=background-color:red;>" + SqlEx.Message + "</p>");
                    //Response.Write("<p style=background-color:red;>" + SqlEx.StackTrace + "</p>");
                    this.lblMsg.Text = "SQLエラー";
                    this.lblMsg.BackColor = System.Drawing.Color.Pink;
                 
                }


            }
            catch 
            {

                //Response.Write("<p style=background-color:red;>" + ex.Message + "</p>");
                //Response.Write("<p style=background-color:red;>" + ex.StackTrace + "</p>");
                this.lblMsg.Text = "エラー";
                this.lblMsg.BackColor = System.Drawing.Color.Pink;

            }

        }

        protected void btnlinkMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //自販連
                Session.Remove("tmpCOCODE");
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            this.txtCOCODE.Text = "";
            this.txtUID.Text = "";
            this.txtCONAME.Text = "";
            this.txtshort_CONAME.Text = "";
            this.txtRepName.Text = "";
            this.txtPostalCode.Text = "";
            this.txtAddress.Text = "";
            this.txtTel.Text = "";
            this.txtPassword.Text = "";
            this.txtMember.Text = "";
            this.txtMemberType.Text = "";
            this.txtPosition.Text = "";
            this.txtisCanceled.Text = "";
            this.txtCOCODE.Focus();

        }

#endregion 

    }
}