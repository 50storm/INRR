<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nonReported_member.aspx.cs" Inherits="Jisseki_Report_Ibaraki.jada.search.nonReported_member" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="../../Css/input.css" type="text/css" />
<style type="text/css">
.text2digit
{
	width:20px;
	height:20px;
	text-align:center;
	ime-mode:disabled;
	
}
</style>
<script type="text/javascript" src="../../Scripts/Utility.js"></script>
<script type="text/javascript">
    function validateForm() {
        if (!isNumber("txtYearRep")) {
            return false;
        }

        if (!isNumber("txtMonthRep")) {
            return false;
        }

    }
    // ==============================
    //  カーソル制御処理
    // ==============================
    function setFocus() {
        document.getElementById('txtYearRep').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtMonthRep').focus();
                document.getElementById('txtMonthRep').select();
                return false;
            }
        }

        document.getElementById('txtMonthRep').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnSearch').focus();
                document.getElementById('btnSearch').select();
                return false;
            }
        }
    }
</script>

    <title>未受信データ会員</title>
</head>
<body  onload="return setFocus();">
<!--外枠-->	
<div id="Wrapper">
    <h1>未受信データ確認画面</h1>
    <form id="form1" runat="server">
    <!--メニュー-->	
	<div id="Menu" >
        <table id="MenuTable" cellpadding="1" cellspacing="5" style="border-collapse: separate;">
            <tr >            
                <td >
                   <asp:Button ID="btnlinkMenu" runat="server" Text="メニュー"  onclick="btnlinkMenu_Click" class="BtnMenu" />
                </td>
                <td >
                    <asp:Button ID="btnLogOut" runat="server" Text="ログアウト"    onclick="btnLogOut_Click" />
                </td>
            </tr>
        </table>
    </div>
    <!--改行-->
    <div>
        <br/><br/><br/>
    </div>
    <div id="Query">
        <asp:Label   ID="lblDateRep" runat="server" >新車登録台数報告年月：</asp:Label>        
        <asp:TextBox ID="txtYearRep" runat="server" MaxLength="2"  class="text2digit" onFocus="select();" ></asp:TextBox>
        <asp:Label   ID="lblYearRep" runat="server" >年</asp:Label>
        <asp:TextBox ID="txtMonthRep" runat="server" MaxLength="2"   class="text2digit" onFocus="select();" ></asp:TextBox>
        <asp:Label 　ID="lblMonthRep" runat="server">月</asp:Label>
        <asp:Button  ID="btnSearch" runat="server" Text="検索" onclick="btnSearch_Click" 
        onclientclick="return validateForm();"/>
        <asp:Label ID="lblMsg" runat="server" ></asp:Label>
    </div>
    <div>
        <asp:gridview ID="Gridview1" runat="server" AutoGenerateColumns="False"  
            Caption="未受信データ会員" onrowcommand="Gridview1_RowCommand" 
            onselectedindexchanged="Gridview1_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="COCODE" HeaderText="会員コード" />
                <asp:BoundField DataField="CONAME" HeaderText="会員名" />
                <asp:BoundField DataField="RepName" HeaderText="担当者" />
                <asp:BoundField DataField="Tel" HeaderText="電話番号" />
                <asp:ButtonField Text="登録" />
            </Columns>
        </asp:gridview>    
    </div>
    </form>
</div>
</body>
</html>
