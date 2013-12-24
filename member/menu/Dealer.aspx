<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dealer.aspx.cs" Inherits="Jisseki_Report_Ibaraki.member.menu.Dealer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会員メニュー</title>
    <style type="text/css">
        /*新車登録台数入力*/
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
        #Content
        {
            /*margin-top: 50px;*/
            /*
        	border: 5px solid pink;
        	*/
        	margin-left : auto ; 
        	margin-right : auto ; 
            width:400px;
        	height:200px;
        }
        #btnInputJisseki
        {
        	height:3.11cm;
        	width:3.79cm;
        	background-color:#DCDCDC;
      	}
        
        /*登録済みデータ検索*/
        #btnSerachJisseki
        {
        	height:3.11cm;
        	width:3.79cm;
        	background-color:#DCDCDC;
        	
        }
        #Env
       {
            clear:left
       } 
        /*ログアウト*/
        #MemberLogOut
        {
        	clear:left;
        }
        #btnLogOut
        {
            background-color:#DCDCDC;
            width:6.67cm;
            height:0.94cm;
        }
    </style>
</head>
<body>
<div id="Wrap">
    <div id="Header">
        <h1>会員メニュー</h1>
    </div>
    <div id="Content">
        <form id="form1" runat="server">
        <table>
        <tr>
            <td>
                <asp:Button ID="btnInputJisseki" runat="server" Text="新車台数実績入力"   onclick="btnInputJisseki_Click" />
            </td>
            <td style="width:200px;">
              
            </td>
            <td>
                <asp:Button ID="btnSerachJisseki" runat="server" Text="新車台数実績検索"  onclick="btnSearchJisseki_Click" />
            </td>
        </tr>
        </table>
        <p>
        <br/>
        <table>
            <tr>
                <td style="width:70px;">
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td style="width:70px;">
                </td>
                <td>
                    <asp:Button ID="btnLogOut" runat="server" Text="ログアウト" onclick="btnLogOut_Click" />
                </td>
            </tr>
            <tr>
                <td style="width:70px;">
                </td>
                <td>
                    <a href="../../pdf/動作環境.pdf"  target="_blank" >動作環境について</a>
                </td>
            </tr>
        </table>
        </p>
        </form>
    </div>
</div>
</body>
</html>
