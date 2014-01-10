<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jihan.aspx.cs" Inherits="Jisseki_Report_Ibaraki.jada.menu.Jihan" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        /*新車登録台数報告*/
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
            width:500px;
        	height:200px;
        }
        
        #ReportDiv
        {
            width:280px;height:450px; float:left; margin-bottom:32px; padding:0px;
           /* border: 1px solid pink;*/
        }
        #ReportDivBtn
        {
            width:160px;height:400px;border:1px solid black; padding:10px 10px 10px 10px;margin:0px;
            background-color:#c0c0c0;
        }
        /*マスター保守*/
       #MasterDiv
       {
           width:200px;height:345px; float:left; padding:0px;
       }

       #MasterDivBtn
       {
            width:160px;height:400px;border:1px solid black; padding:10px 10px 10px 10px;
            background-color:#c0c0c0;
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
            background-color:#DCDCDC;
            width:6.67cm;
            height:0.94cm;
        }
        .btnClass
        {
            width:4.04cm;
            height:0.94cm;
             background-color:#DCDCDC;
        }
        #lblReport
        {
          font-size:14px;	
        }
    </style>
    <title>自販連メニュー</title>
</head>
<body>
<div id="Wrap">
   <div id="Header">
        <h1>自販連メニュー</h1>
    </div>
   <div id="Content">
    <form id="form1" runat="server">
    <div id="ReportDiv">
        <div id="ReportDivBtn" >
            <table>
                <tr  style="height:30px;">
                    <td align=center >
                        <asp:Label ID="lblReport" runat="server" Text="新車登録台数報告"></asp:Label>
                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button class="btnClass"  ID="btn_NonReportedSearch" runat="server" Text="未受信データ確認"   onclick="btn_NonReportedSearch_Click" />
                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  class="btnClass"   ID="btn_ReportedSearch" runat="server" Text="受信データ確認"   onclick="btn_ReportedSearch_Click" /> 
                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  class="btnClass"   ID="btn_Jisseki" runat="server" Text="一括印刷(台数報告書)"      onclick="btn_Jisseki_Click"   />
                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  class="btnClass"   ID="btn_PrintAtOnce" runat="server" Text="一括印刷(仮請求書)" 
                            onclick="btn_PrintAtOnce_Click"   /> 


                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button   class="btnClass"   ID="bnt_DownloadReortedData" runat="server"  Text="ダウンロード" onclick="bnt_DownloadReortedData_Click"/> 
                    </td>
                </tr>
            </table>
            
        </div>
    </div>
    <div id="MasterDiv">
        <div id="MasterDivBtn">
            <table>
                <tr  style="height:30px;">
                    <td  align=center >
                        <asp:Label ID="lblMaster" runat="server" Text="マスタ保守"></asp:Label>
                    </td>
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  class="btnClass" ID="btn_ID" runat="server" Text="会員マスタ" onclick="btn_ID_Click" />
                    </td>          
                </tr>
                <tr style="height:30px;">
                    <td>
                
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  class="btnClass" ID="btnUnitPrice" runat="server" Text="単価マスタ" onclick="btnUnitPrice_Click"  />
                    </td>          
                </tr>
            </table>
        </div>
    </div>
    <table>
        <tr>
            <td style="width:100px;">
            </td>
            <td>            
                <asp:Button ID="btnLogOut" runat="server" Text="ログアウト"   onclick="btnLogOut_Click" />
            </td>
        </tr>
        <tr>
            <td style="width:100px;">
            </td>
            <td>
                <a href="../../pdf/動作環境.pdf"  target="_blank" >動作環境について</a>
            </td>
        </tr>
    </table>

    </form>
    </div>
</div>
</body>
</html>
