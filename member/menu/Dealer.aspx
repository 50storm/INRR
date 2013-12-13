<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dealer.aspx.cs" Inherits="Jisseki_Report_Ibaraki.member.menu.Dealer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会員メニュー</title>
    <style type="text/css">
        /*新車登録台数入力*/
        #MemberInputDiv
        {
      	   width:400px;height:345px; float:left; margin-bottom:32px; padding:0px;
        	
        }
        #MemberInputTitleDiv
        {
        	 margin:0px; padding:0px;           
        }
        #MemberInputBtnDiv
        {
        	width:320px;height:280px;border:1px solid black; padding:10px 10px 10px 10px;margin:0px
        }


        
        /*登録済みデータ検索*/
        #MemberSearchDiv
        {
            width:400px;height:345px; float:left; padding:0px;
        	
        }
        #MemberSearchTitleDiv
        {
        	margin:0px; padding:0px;
        }
        #MemberSearchBtnDiv
        {
        	width:230px;height:280px;border:1px solid black; padding:10px 10px 10px 10px;
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
        	/*LinkButtonが動作しない*/
        	/*LinkButton風にＣＳＳを当てる*/
        	text-decoration:underline;
            color:#0000ff;
            border:none;
            background:transparent;
        }
    </style>
</head>
<body>
    <h1>会員メニュー</h1>
    <div>
        <form id="form1" runat="server">
        <div id="MemberInputDiv">
            <div id ="MemberInputTitleDiv">
                <h2>新車登録台数入力</h2>
            </div>
            <div id ="MemberInputBtnDiv">
                <p><asp:Button ID="btnInputJisseki" runat="server" Text="新車台数実績入力"   onclick="btnInputJisseki_Click" /></p>
            </div>
        </div>
        <div id="MemberSearchDiv">
            <div id="MemberSearchTitleDiv">
                <h2>登録済みデータ検索</h2>
            </div>
            <div  id="MemberSearchBtnDiv" >
                <p><asp:Button ID="btnSerachJisseki" runat="server" Text="新車台数実績検索"  onclick="btnSearchJisseki_Click" /></p>
            </div>
        </div>
    <div id="Env">
        <p><a href="../../pdf/動作環境.pdf">動作環境について</a></p>
    </div>
        <div id="MemberLogOut">
            <asp:Button ID="btnLogOut" runat="server" Text="ログアウト" onclick="btnLogOut_Click" />
        </div>

        </form>
    </div>
</body>
</html>
