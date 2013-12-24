<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="INRRlogin.aspx.cs" Inherits="Jisseki_Report_Ibaraki.INRRlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        H1
        {
        	text-align:center;
        	vertical-align:middle;
        	padding-top:15px;
        	width:900px;
        	height:50px;
        	background-color: #009090;
        	font-size:30px;
		    color:white;
        	/*height:200px;*/
        	/*background-color:blue;*/
        }
        Label
        {
        	height:35px;
        	background-color:white;
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
        	margin-top:0px;
        	margin-left:auto;
        	margin-right:auto;
        	margin-bottom:100px;
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
        	margin-left : auto ; 
        	margin-right : auto ; 
            width:300px;
        	height:200px;
        }
        #ContentTable
        {
            	width:300px;
        	
        }
        #txtCOCODE
        {
            ime-mode:inactive;
            width:160px;
            
        }
        #txtPassword
        {
            ime-mode:disabled;    
            width:160px;
        }
        #btnLogin
        {
        	width:3.89cm;
        	height:0.93cm;

        	/*background-color:#C0C0C0;*/
        	background-color:#DCDCDC;
        }
    </style>
    <title>新車登録台数報告システム</title>
</head>
<body>
<div id="Wrap">
        <div id="Header">
            <h1>新車登録台数報告システム</h1>
        </div>
        <div id="Content">
            <form id="form1" runat="server">
            <table id="ContentTable">
                <tr>
                    <td >
                        <label for="txtCOOCDE" >ログインＩＤ：</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCOCODE" runat="server" MaxLength="8" onFocus="select();" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtPassword" >パスワード：</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" 
                    runat="server" TextMode="Password" MaxLength="15"  onFocus="select();" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="ログイン" onclick="btnLogin_Click" /> 
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
           </table>
            </form>     
        </div>

</div>
</body>
</html>
