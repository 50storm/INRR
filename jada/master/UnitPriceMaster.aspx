<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnitPriceMaster.aspx.cs" Inherits="Jisseki_Report_Ibaraki.jada.master.UnitPriceMaster" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="../../Css/input.css" type="text/css" />
<style type="text/css">
.txtUnitPrice
{
	width:130px;
	text-align:center;
	ime-mode:disabled;
}
</style>
<script type="text/javascript" src="../../Scripts/Utility.js"></script>
<script type="text/javascript" src="../../Scripts/UnitPrice.js"></script>
    <title>単価マスター【一括修正】</title>
</head>
<body onload="return setFocus();">
    <form id="form1" runat="server">
    <h1>単価マスター</h1>
    <div id="Wrapper">
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
    <div>
        <asp:Label ID="lblMsg" runat="server" BackColor="#FF66FF"></asp:Label>
    </div>
    <div>
        <table id="UnitPriceTable" style="width:360px;" border="1">
        <colgroup span="1" style="background-color:#1C5E55;color:White;"></colgroup>
        <colgroup span="1"></colgroup>
            <tr>
                <td>台数割会費　大型:</td>
                <td><asp:TextBox ID="txtBigSize" runat="server" class="txtUnitPrice" onFocus="select();" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>台数割会費　中・小型:</td>
                <td><asp:TextBox ID="txtMediumSmall" runat="server" class="txtUnitPrice" onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>均等割会費: </td>
                <td><asp:TextBox ID="txtAverage" runat="server" class="txtUnitPrice" onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>７ｔ以上: </td>
                <td><asp:TextBox ID="txtKamotu7t" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>６．９ｔ～５ｔ:</td>
                <td><asp:TextBox ID="txtKamotu6DP9_5t" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>４．９ｔ～３ｔ: </td>
                <td><asp:TextBox ID="txtKamotu4DP9_3t" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>２．９ｔ～２．５ｔ:</td>
                <td><asp:TextBox ID="txtKamotu2DP9_2DP5t" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>２，００１ｃｃ以上: </td>
                <td><asp:TextBox ID="txtOver2001cc" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>２，０００ｃｃ～１，０００ｃｃ: </td>
                <td><asp:TextBox ID="txtTo2000From1000cc" runat="server" class="txtUnitPrice"  onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>乗合定員３０人以上:</td>
                <td><asp:TextBox ID="txtOver30" runat="server" class="txtUnitPrice" onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>乗合定員２９人以下:</td>
                <td><asp:TextBox ID="txtLessThan29" runat="server" class="txtUnitPrice" onFocus="select();"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>会費:</td>
                <td><asp:TextBox ID="txtMemberFee" runat="server" class="txtUnitPrice" onFocus="select();"  ></asp:TextBox></td>
            </tr>
            
        </table>
        <br/>
        <div>
            <asp:Button ID="btnUpdate" runat="server" Text="更新"  onclick="btnUpdate_Click1" OnClientClick="return checkForm();" />
            <input id="btnReset" type="reset" value="リセット" />
        </div>
        <br/>
      </div>
    </div>
    </form>
</body>
</html>
