<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jihan.aspx.cs" Inherits="Jisseki_Report_Ibaraki.jada.menu.Jihan" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        /*新車登録台数報告*/
        #ReportDiv
        {
            width:400px;height:345px; float:left; margin-bottom:32px; padding:0px;
           /* border: 1px solid pink;*/
        }
        #ReportDivTitle
        {
            margin:0px; padding:0px;           
        }
        #ReportDivBtn
        {
            width:320px;height:280px;border:1px solid black; padding:10px 10px 10px 10px;margin:0px
        }
        /*マスター保守*/
       #MasterDiv
       {
           width:400px;height:345px; float:left; padding:0px;
       }
       #MasterDivTitle
       {
            margin:0px; padding:0px;
       }
       #MasterDivBtn
       {
            width:230px;height:280px;border:1px solid black; padding:10px 10px 10px 10px;
       }
       #Env
       {
            clear:left
       }
       
       #jadaLogOut
       {
       	    clear:left;
       	}
       	#btnLogOut
       	{
       		/*LinkButtonが動作しない*/
        	/*LinkButton風にＣＳＳを当てる*/
        	border-style: none;
            border-color: inherit;
            border-width: medium;
            text-decoration:underline;
            color:#0000ff;
            background:transparent;
            height: 17px;
        }
    </style>
    <title>自販連メニュー</title>
</head>
<body>
<h1>自販連メニュー</h1>
    <form id="form1" runat="server">
    <div id="ReportDiv">
        <div id="ReportDivTitle" >
            <h2>新車登録台数報告</h2>
        </div>
        <div id="ReportDivBtn" >
            <h3>【未受信データ】</h3>
            <p><asp:Button  style="width:300px;"  ID="btn_NonReportedSearch" runat="server" Text="新車台数実績報告"   onclick="btn_NonReportedSearch_Click" /></p>
            <h3>【受信データ】</h3>
            <p><asp:Button  style="width:300px;"  ID="btn_ReportedSearch" runat="server" Text="新車台数実績報告"   onclick="btn_ReportedSearch_Click" /></p>
            <h3>【ダウンロード】</h3>
            <p><asp:Button  style="width:300px;"  ID="bnt_DownloadReortedData" runat="server"  Text="新車台数実績報告" onclick="bnt_DownloadReortedData_Click"/></p>
        </div>
    </div>
    <div id="MasterDiv">
        <div id="MasterDivTitle" >
            <h2>マスター保守</h2>
        </div>
        <div id="MasterDivBtn">
            <p><asp:Button ID="btn_ID" runat="server" Text="会員マスタ" onclick="btn_ID_Click" /></p>
            <p><asp:Button ID="btnUnitPrice" runat="server" Text="単価マスタ" 
                    onclick="btnUnitPrice_Click"  /></p>
        </div>
    </div>
    <div id="Env">
        <p><a href="../../pdf/動作環境.pdf">動作環境について</a></p>
    </div>
    <div id="jadaLogOut">
        <asp:Button ID="btnLogOut" runat="server" Text="ログアウト" 
            onclick="btnLogOut_Click" />
    </div>

    </form>
</body>
</html>
