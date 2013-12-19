<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="INRRlogin.aspx.cs" Inherits="Jisseki_Report_Ibaraki.INRRlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        H1
        {
        	text-align:center;
        	width:900px;
        	/*height:200px;*/
        	/*background-color:blue;*/
        }
        Label
        {
        	background-color:Gray;
        }
        #Wrap
        {
	        width: 900px;  
	        height:auto;
	        margin: 0 auto;
	        margin: 0 auto 0 auto;
	        /*text-align: left;  */
	        /*border: 5px solid #FF00FF;*/
	        
        }
        #Header
        {
        	margin-top:150px;
        	margin-left:auto;
        	margin-right:auto;
        	margin-bottom:20px;
        	/*border: 5px solid blue;*/
        	width:900px;
        	height:50px;
        	float:left;
        }
        #Content
        {
            /*margin-top: 50px;*/
            /*
        	border: 5px solid pink;
        	*/
            width:600px;
        	height:200px;
        }
        
        #txtCOCODE
        {
            ime-mode:inactive;
            width:100px;
            
        }
        #txtPassword
        {
            ime-mode:disabled;    
            width:100px;
        }
    </style>
    <title>新車登録台数報告システム</title>
</head>
<body>
<div id="Wrap">
        <div id="Header">
            <h1 style="background-color: #00FFFF">新車登録台数報告システム</h1>
        </div>
        <div id="Content">
            <form id="form1" runat="server">
            <p><label for="txtCOOCDE" >ログインＩＤ：</label><asp:TextBox ID="txtCOCODE" 
                    runat="server" MaxLength="8" onFocus="select();" ></asp:TextBox></p>
            <p><label for="txtPassword" >パスワード：</label><asp:TextBox ID="txtPassword" 
                    runat="server" TextMode="Password" MaxLength="15"  onFocus="select();" ></asp:TextBox></p>
            <p>
                <asp:Button ID="btnLogin" runat="server" Text="ログイン" onclick="btnLogin_Click" />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </p>
            
            </form>
        </div>
</div>
</body>
</html>
