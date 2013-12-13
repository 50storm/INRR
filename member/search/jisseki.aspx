<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jisseki.aspx.cs" Inherits="Jisseki_Report_Ibaraki.member.search.jisseki" %>
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
        if (!isNumber("txtYearRepFrom")) {
            return false;
        }

        if (!isNumber("txtYearRepTo")) {
            return false;
        }

        if (!isNumber("txtMonthRepFrom")) {
            return false;
        }

        if (!isNumber("txtMonthRepTo")) {
            return false;
        }

    }
// ==============================
//  カーソル制御処理
// ==============================
    function setFocus() {
        document.getElementById('txtYearRepFrom').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtMonthRepFrom').focus();
                document.getElementById('txtMonthRepFrom').select();
                return false;
            }
        }

        document.getElementById('txtMonthRepFrom').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtYearRepTo').focus();
                document.getElementById('txtYearRepTo').select();
                return false;
            }
        }

        document.getElementById('txtYearRepTo').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtMonthRepTo').focus();
                document.getElementById('txtMonthRepTo').select();
                return false;
            }
        }

        document.getElementById('txtMonthRepTo').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnSearch').focus();
                document.getElementById('btnSearch').select();
                return false;
            }
        }
    }


</script>
    <title>送信確認画面</title>
</head>
<body  onload="return setFocus();">
<!--外枠-->	
<div id="Wrapper">
    <h1>送信確認画面</h1>
    <form id="form1" runat="server">
    <!--メニュー-->	
	<div id="Menu" >
        <div id="Menu_Link">
            <asp:Button ID="btnlinkMenu" runat="server" Text="メニュー"  onclick="btnlinkMenu_Click" class="BtnMenu" />
        </div>
        <div id="Menu_Btn">
            <asp:Button ID="btnLogOut" runat="server" Text="ログアウト"    onclick="btnLogOut_Click" />
        </div>
    </div>
    <!--改行-->
    <div>
        <br/><br/><br/>
    </div>
    <div>
        <asp:Label   ID="lblDateRep" runat="server" >新車登録台数報告年月：</asp:Label>        
        <asp:TextBox ID="txtYearRepFrom" runat="server" MaxLength="2" class="text2digit" onFocus="select();" ></asp:TextBox>
        <asp:Label   ID="lblYearRepFrom" runat="server" >年</asp:Label>
        <asp:TextBox ID="txtMonthRepFrom" runat="server" MaxLength="2"  class="text2digit" onFocus="select();"  ></asp:TextBox>
        <asp:Label 　ID="lblMonthRepFrom" runat="server">月</asp:Label>
        ～
        <asp:TextBox ID="txtYearRepTo" runat="server" MaxLength="2"  class="text2digit"  onFocus="select();"  ></asp:TextBox>
        <asp:Label   ID="lblYearRepTo" runat="server" >年</asp:Label>
        <asp:TextBox ID="txtMonthRepTo" runat="server" MaxLength="2"  class="text2digit" onFocus="select();"  ></asp:TextBox>
        <asp:Label 　ID="lblMonthRepTo" runat="server">月</asp:Label>
        <asp:Button  ID="btnSearch" runat="server" Text="検索" onclick="btnSearch_Click" 
            onclientclick="return validateForm();" />
        <asp:Label ID="lblMsg" runat="server" ></asp:Label>
    </div>
    <div>
    <asp:gridview ID="Gridview1" runat="server" AutoGenerateColumns="False" 
            style="margin-right: 0px" 
           >
    <Columns>
        <asp:BoundField DataField="TANTOU" HeaderText="担当者" />
        <asp:BoundField HeaderText="送信日付" />
        
            
        <asp:BoundField HeaderText="報告年月" />
        
            
        <asp:HyperLinkField Text="削除" DataNavigateUrlFields="COCODE,YearRep,MonthRep" 
            DataNavigateUrlFormatString="~/common/delete_jisseki.aspx?COCODE={0}&amp;YearRep={1}&amp;MonthRep={2}" 
            Target="_self" />
        
        <asp:HyperLinkField Text="修正" DataNavigateUrlFields="COCODE,YearRep,MonthRep,Year,Month,Day" 
            DataNavigateUrlFormatString="~/common/alter_jisseki.aspx?COCODE={0}&amp;YearRep={1}&amp;MonthRep={2}&amp;Year={3}&amp;Month={4}&amp;Day={5}" 
            Target="_self" />
        
        <asp:BoundField DataField="Year" HeaderText="Year" />
        <asp:BoundField DataField="Month" HeaderText="Month" />
        <asp:BoundField DataField="Day" HeaderText="Day" />
        
        <asp:BoundField DataField="YearRep" HeaderText="YearRep" />
        <asp:BoundField DataField="MonthRep" HeaderText="MonthRep" />
        
            
    </Columns>
        </asp:gridview>    
    </div>
    </form>
</div>
</body>

</html>
