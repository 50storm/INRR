<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="Jisseki_Report_Ibaraki.jada.print.Invoice" %>
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
.txtCOCODE
{
	ime-mode:disabled;
}
#Wrapper
{
    width:900px;	

}
#btnToNonReported
{
	width:120px;
	height:30px;
}

</style>
<script type="text/javascript" src="../../Scripts/Utility.js"></script> 

<script type="text/javascript">
    function validateForm() {
        if (!isNumber("txtYearRepFrom")) {
            return false;
        }

        if (!isNumber("txtMonthRepFrom")) {
            return false;
        }

        if (!isNumber("From_COCODE")) {
            return false;
        }


        if (!isNumber("To_COCODE")) {
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
                document.getElementById('From_COCODE').focus();
                document.getElementById('From_COCODE').select();
                return false;
            }
        }

        document.getElementById('From_COCODE').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('To_COCODE').focus();
                document.getElementById('To_COCODE').select();
                return false;
            }
        }

        document.getElementById('To_COCODE').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('CheckAll').focus();
                document.getElementById('CheckAll').select();
                return false;
            }
        }

        document.getElementById('CheckAll').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnSearch').focus();
                document.getElementById('btnSearch').select();
                return false;
            }
        }

        document.getElementById('btnSearch').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnPrint').focus();
                document.getElementById('btnPrint').select();
                return false;
            }
        }

        document.getElementById('btnPrint').onkeydown
        = function () {
            if (event.keyCode == 13) {
                document.getElementById('txtYearRepFrom').focus();
                document.getElementById('txtYearRepFrom').select();
                return false;
            }
        }



    }
</script>
    <title>受信データ確認画面</title>
</head>
<body  onload="return setFocus();">
<!--外枠-->	
<div id="Wrapper">
    <h1>一括印刷(仮請求書)</h1>
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
                <td>
                    <asp:Button ID="btnToNonReported" runat="server" Text="未受信データ検索" onclick="btnToNonReported_Click"   />
                </td>
            </tr>
        </table>
    </div>
    <!--改行-->
    <div>
        <br/><br/><br/>
    </div>
    <div>
        <table>
        <tr>    
            <td><asp:Label   ID="lblDateRep" runat="server" >新車登録台数報告年月：</asp:Label>        </td>
            <td>
                <asp:TextBox ID="txtYearRepFrom" runat="server" MaxLength="2"  class="text2digit" onFocus="select();" ></asp:TextBox>
                <asp:Label   ID="lblYearRepFrom" runat="server" >年</asp:Label>
                <asp:TextBox ID="txtMonthRepFrom" runat="server" MaxLength="2"   class="text2digit" onFocus="select();"></asp:TextBox>
                <asp:Label 　ID="lblMonthRepFrom" runat="server">月</asp:Label>
            </td>
            <td rowspan="2" colspan="2">
                <asp:Label ID="lblMsg" runat="server" ></asp:Label><br/>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label   ID="Label1" runat="server" >会員コード：</asp:Label>        
            </td>
            <td>
                <asp:TextBox ID="From_COCODE" runat="server" MaxLength="4" Width="80px" onFocus="select();" class="txtCOCODE" ></asp:TextBox>
                <asp:Label   ID="Label2" runat="server" >～</asp:Label>        
                <asp:TextBox ID="To_COCODE" runat="server" MaxLength="4" Width="80px" onFocus="select();"  class="txtCOCODE"></asp:TextBox>                
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label   ID="Label3" runat="server" >一括選択：</asp:Label>        
            </td>
            <td>

                <asp:Button ID="CheckAll" runat="server" Text="すべて選択" 
                    onclick="CheckAll_Click" />
                <asp:Button ID="UnCheckAll" runat="server" Text="すべて解除" 
                    onclick="UnCheckAll_Click" />
            </td>
            <td>
                
            </td>
            <td>

            </td>
        </tr>
        
        </table>      
        <br/>
        <table>
        <tr>
            <td>
                <asp:Button  ID="btnSearch" runat="server" Text="検索" onclick="btnSearch_Click"    onclientclick="return validateForm();" />
            </td>
            <td>
                <asp:Button ID="btnPrint" runat="server" Text="印刷" onclick="btnPrint_Click" />
            </td>
        </tr>
        </table>
        
        
    </div>
    <div>
    <asp:gridview ID="Gridview1" runat="server" AutoGenerateColumns="False" 
            style="margin-right: 0px" 
            onselectedindexchanged="Gridview1_SelectedIndexChanged" CellPadding="4" 
            ForeColor="#333333" GridLines="None" >
        <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="COCODE" HeaderText="会社コード" />
        <asp:BoundField DataField="CONAME" HeaderText="会社名" />
        <asp:BoundField DataField="RepName" HeaderText="会員担当者" />
        <asp:BoundField HeaderText="受信日付" Visible="False" />
        <asp:BoundField HeaderText="報告年月" Visible="False" />
        
        <asp:BoundField DataField="Year" HeaderText="Year" />
        <asp:BoundField DataField="Month" HeaderText="Month" />
        <asp:BoundField DataField="Day" HeaderText="Day" />
        
        <asp:BoundField DataField="YearRep" HeaderText="YearRep" />
        <asp:BoundField DataField="MonthRep" HeaderText="MonthRep" />
        <asp:TemplateField>
        <ItemTemplate>
            <asp:CheckBox ID="CheckBoxPrintOnt" runat="server"　Text="印刷する"  />

        </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="MemberType" HeaderText="MemberType" 
            Visible="False" />
    </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:gridview>    
    </div>
    </form>
</div>
</body>

</html>
