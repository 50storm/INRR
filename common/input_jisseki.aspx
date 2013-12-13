<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="input_jisseki.aspx.cs" Inherits="Jisseki_Report_Ibaraki.common.input_jisseki" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript" src="../Scripts/Utility.js"></script>
<script type="text/javascript" src="../Scripts/inputJisseki.js"></script>
<script type="text/javascript" src="../Scripts/inputJisseki_AutoSum.js"></script>
<script type="text/javascript" src="../Scripts/inputJisseki_Key.js"></script>
<meta charset="UTF-8" />
<meta http-equiv="X-UA-Compatible" content="IE=6;IE=7;IE=8;IE=9;IE=10">
<link rel="stylesheet" href="../Css/input.css" type="text/css" />
   <title>新車登録台数報告書【登録】</title>
</head>
<body onload="return setFocus();">
<!--外枠-->	
<div id="Wrapper">
    <form id="form1" runat="server" >
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
    <!--タイトル-->
    <div>
        <asp:Label ID="lblEraRep0" runat="server" Text="元号" ></asp:Label>
	    <asp:TextBox ID="txtYearRep0" runat="server"  MaxLength="2" ></asp:TextBox>年
	    <asp:TextBox ID="txtMonthRep0" runat="server" Text="99"   MaxLength="2"></asp:TextBox>
        月分新車新規登録台数報告書
    </div>
    <!--登録日-->
    <div>
        <table>
            <tr>
                <td>
                    登録日
                </td>
                <td>
                    <asp:Label ID="lblEra"  runat="server" Text="元号"></asp:Label>
                    <asp:TextBox ID="txtYear" runat="server"  MaxLength="2" class="Era"></asp:TextBox>
	    		    年
	    		    <asp:TextBox  ID="txtMonth" runat="server"  MaxLength="2"   class="Era"></asp:TextBox>
	    		    月
	    		    <asp:TextBox  ID="txtDay" runat="server"  MaxLength="2"   class="Era"></asp:TextBox>
	    		    日
                </td>
                <td rowspan="3" style="width:425px; text-align:center; vertical-align:middle;">
                    <asp:Label ID="lblMsg" runat="server" Height="69px"  Width="330px" Font-Size="X-Large"  ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>社　名</td>
                <td><asp:TextBox ID="txtSyamei" runat="server" MaxLength="40"></asp:TextBox></td>

            </tr>
            <tr>
                <td>担当者</td>
                <td><asp:TextBox ID="txtTantou" runat="server" MaxLength="50" onfocus="select();" ></asp:TextBox></td>
               
            </tr>
        </table>
    </div>
	<!--テーブル-->    
	<div id="TableDiv" >
		<table id="tblReport"  >
        <colgroup  id="" class="class1">
        </colgroup>
        <colgroup span="2" id="" class="class2">
            <col  style="width:120px;" />
            <col />
        </colgroup>
        <colgroup span="9" id="" class="class3">
        </colgroup>
		<thead>
		<tr>
			<th class="col"></th><th>区　分</th><th colspan="2">水　戸</th><th colspan="2">土　浦</th><th colspan="2">つ　く　ば</th><th colspan="2">その他</th><th  style="background:gray;"  colspan="2">合計</th>
		</tr>
		</thead>
		<tbody>
		<!--貨物車-->
		<tr>
			<td rowspan="4"><p>貨</p><p>物</p><p>車</p></td>
			<td class="Category">7t以上</td>
			<td colspan="2"><asp:TextBox ID="txtMito_Kamotu1" runat="server"  class="txtTableType1"   MaxLength="3"   onfocus="select();"  onBlur="SumRow1();SumMito();SumGoukei();">0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTuchiura_Kamotu1" runat="server" class="txtTableType1" MaxLength="3"  onfocus="select();"   onBlur="SumRow1();SumTuchiura();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTukuba_Kamotu1" runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();"  onBlur="SumRow1();SumTukuba();SumGoukei();">0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtSonota_Kamotu1" runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();"  onBlur="SumRow1();SumSonota();SumGoukei();">0</asp:TextBox></td>
			<td style="background:gray;" colspan="2"><asp:TextBox ID="txtGoukei_Kamotu1" 
                    runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();"  
                    onBlur="SumRow1();SumGoukei();" BackColor="Silver">0</asp:TextBox></td>
		</tr>
		<tr>
			<td  class="Category">6.9t ～ 5t以上</td>
			<td colspan="2"><asp:TextBox ID="txtMito_Kamotu2" runat="server" class="txtTableType1"     MaxLength="3"  onfocus="select();"  onBlur="SumRow2();SumMito();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTuchiura_Kamotu2" runat="server" class="txtTableType1" MaxLength="3"  onfocus="select();"  onBlur="SumRow2();SumTuchiura();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTukuba_Kamotu2" runat="server" class="txtTableType1"   MaxLength="3"  onfocus="select();"  onBlur="SumRow2();SumTukuba();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtSonota_Kamotu2" runat="server" class="txtTableType1"   MaxLength="3"  onfocus="select();"  onBlur="SumRow2();SumSonota();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Kamotu2" 
                    runat="server" class="txtTableType1"   MaxLength="3"  onfocus="select();"  
                    onBlur="SumRow2();SumGoukei();"  BackColor="Silver"   >0</asp:TextBox></td>
		</tr>
		<tr>
		<td  class="Category">4.9t ～ 3t以上</td>
			<td colspan="2"><asp:TextBox ID="txtMito_Kamotu3" runat="server" class="txtTableType1"      MaxLength="3"   onfocus="select();" onBlur="SumRow3();SumMito();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTuchiura_Kamotu3" runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();" onBlur="SumRow3();SumTuchiura();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTukuba_Kamotu3" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" onBlur="SumRow3();SumTukuba();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtSonota_Kamotu3" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" onBlur="SumRow3();SumSonota();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Kamotu3" 
                    runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" 
                    onBlur="SumRow3();SumGoukei();" BackColor="Silver" >0</asp:TextBox></td>
		
		</tr>
		<tr>
		<td class="Category">2.9t ～ 2.5t以上</td>
			<td colspan="2"><asp:TextBox ID="txtMito_Kamotu4" runat="server" class="txtTableType1"      MaxLength="3"   onfocus="select();" onBlur="SumRow4();SumMito();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTuchiura_Kamotu4" runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();" onBlur="SumRow4();SumTuchiura();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTukuba_Kamotu4" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" onBlur="SumRow4();SumTukuba();SumGoukei();" >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtSonota_Kamotu4" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" onBlur="SumRow4();SumSonota();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Kamotu4" 
                    runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();" 
                    onBlur="SumRow4();SumGoukei();" BackColor="Silver" >0</asp:TextBox></td>
		</tr>
		<!--バス-->
		<tr>
			<td rowspan="2"><p>バ</p><p>ス</p></td>
			<td  class="Category">定員30人以上</td>
			<td colspan="2"><asp:TextBox ID="txtMito_Bus1" runat="server" class="txtTableType1"      MaxLength="3"    onfocus="select();" onBlur="SumBus1();SumMito();SumGoukei();"  >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTuchiura_Bus1" runat="server" class="txtTableType1"  MaxLength="3"    onfocus="select();" onBlur="SumBus1();SumTuchiura();SumGoukei();"  >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtTukuba_Bus1" runat="server" class="txtTableType1"    MaxLength="3"    onfocus="select();" onBlur="SumBus1();SumTukuba();SumGoukei();"  >0</asp:TextBox></td>
			<td colspan="2"><asp:TextBox ID="txtSonota_Bus1" runat="server" class="txtTableType1"    MaxLength="3"    onfocus="select();" onBlur="SumBus1();SumSonota();SumGoukei();"  >0</asp:TextBox></td>
			<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Bus1" 
                    runat="server" class="txtTableType1"    MaxLength="3"    onfocus="select();" 
                    onBlur="SumBus1();SumGoukei();" BackColor="Silver"  >0</asp:TextBox></td>
		</tr>
		<tr>
		<td  class="Category">定員29人以下<br/>(乗用車を除く)</td>
		<td colspan="2"><asp:TextBox ID="txtMito_Bus2" runat="server" class="txtTableType1"      MaxLength="3"   onfocus="select();"   onBlur="SumBus2();SumMito();SumGoukei();" >0</asp:TextBox></td>
		<td colspan="2"><asp:TextBox ID="txtTuchiura_Bus2" runat="server" class="txtTableType1"  MaxLength="3"   onfocus="select();"   onBlur="SumBus2();SumTuchiura();SumGoukei();" >0</asp:TextBox></td>
		<td colspan="2"><asp:TextBox ID="txtTukuba_Bus2" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();"   onBlur="SumBus2();SumTukuba();SumGoukei();" >0</asp:TextBox></td>
		<td colspan="2"><asp:TextBox ID="txtSonota_Bus2" runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();"   onBlur="SumBus2();SumSonota();SumGoukei();" >0</asp:TextBox></td>
		<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Bus2" 
                runat="server" class="txtTableType1"    MaxLength="3"   onfocus="select();"   
                onBlur="SumBus2();SumGoukei();" BackColor="Silver" >0</asp:TextBox></td>
		</tr>
		<!--乗用車及び貨物車-->
		<tr>
			<td rowspan="4" class="Row_JK">
                <p id="Row_JK_1" >乗&nbsp;&nbsp;貨</p>
                <p id="Row_JK_2" >用&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                <p id="Row_JK_3" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;物</p>
                <p id="Row_JK_4" >及&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                <p id="Row_JK_5" >び&nbsp;&nbsp;車</p>
            </td>
             <td >&nbsp;</td><td>乗用</td><td>貨物</td><td>乗用</td><td>貨物</td><td>乗用</td><td>貨物</td><td>乗用</td><td>貨物</td><td  style="background:gray;">乗用</td><td  style="background:gray;" >貨物</td>
		</tr>
		<tr >
			<td class="Category" ><p>2,001cc以上</p></td>
			<td><asp:TextBox ID="txtMito_JK_J1" runat="server"       MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_J1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtMito_JK_K1" runat="server"       MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_K1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_J1" runat="server"   MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_J1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_K1" runat="server"   MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_K1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_J1" runat="server"     MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_J1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_K1" runat="server"     MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_K1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_J1" runat="server"     MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_J1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_K1" runat="server"     MaxLength="3"  class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_K1();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_J1" runat="server"     
                    MaxLength="3"  class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_J1();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver">0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_K1" runat="server"     
                    MaxLength="3"  class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_K1();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver">0</asp:TextBox></td>
		</tr>
		<tr style="height:10px;">
			<td  class="Category" ><p style="line-height:14px;">2,000cc&nbsp;&nbsp;&nbsp;<br/>&nbsp;&nbsp;&nbsp;～1,000cc</p></td>
			<td><asp:TextBox ID="txtMito_JK_J2" runat="server"    MaxLength="3"     class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_J2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtMito_JK_K2" runat="server"    MaxLength="3"     class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_K2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_J2" runat="server"   MaxLength="3" class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_J2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_K2" runat="server"   MaxLength="3" class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_K2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_J2" runat="server"  MaxLength="3"    class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_J2();SumGoukeiSubTotal();SumGoukei();">0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_K2" runat="server"  MaxLength="3"    class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_K2();SumGoukeiSubTotal();SumGoukei();">0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_J2" runat="server"  MaxLength="3"    class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_J2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_K2" runat="server"  MaxLength="3"    class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_K2();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_J2" runat="server"  
                    MaxLength="3"    class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_J2();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver" >0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_K2" runat="server"  
                    MaxLength="3"    class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_K2();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver" >0</asp:TextBox></td>
		</tr>
		<tr  style="height:10px;">
			<td class="Category" ><p>1,000cc未満</p></td>
			<td><asp:TextBox ID="txtMito_JK_J3" runat="server"   MaxLength="3"       class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_J3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtMito_JK_K3" runat="server"   MaxLength="3"       class="txtTableType2"   onfocus="select();" onblur="SumMitoSubTotal();SumMito();JK_K3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_J3" runat="server"   MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_J3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTuchiura_JK_K3" runat="server"   MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumTuchiuraSubTotal();SumTuchiura();JK_K3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_J3" runat="server"  MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_J3();SumGoukeiSubTotal();SumGoukei();">0</asp:TextBox></td>
			<td><asp:TextBox ID="txtTukuba_JK_K3" runat="server"  MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumTukubaSubTotal();SumTukuba();JK_K3();SumGoukeiSubTotal();SumGoukei();">0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_J3" runat="server"  MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_J3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td><asp:TextBox ID="txtSonota_JK_K3" runat="server"  MaxLength="3"   class="txtTableType2"   onfocus="select();" onblur="SumSonotaSubTotal();SumSonota();JK_K3();SumGoukeiSubTotal();SumGoukei();" >0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_J3" runat="server"  
                    MaxLength="3"  class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_J3();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver" >0</asp:TextBox></td>
			<td  style="background:gray;" ><asp:TextBox ID="txtGoukei_JK_K3" runat="server"  
                    MaxLength="3"  class="txtTableType2"   onfocus="select();" 
                    onblur="SumGoukeiSubTotal();SumGoukei();JK_K3();SumGoukeiSubTotal();SumGoukei();" 
                    BackColor="Silver" >0</asp:TextBox></td>
		</tr>
		<!--小計-->
		<tr>
		<td   style="background:gray;" colspan="2">小　計</td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtMito_SubTotal1" 
               BackColor="Silver"  runat="server" class="txtTableType1"  MaxLength="3"  onfocus="select();" 
                 >0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtTuchiura_SubTotal1" 
                runat="server" class="txtTableType1"  MaxLength="3" onfocus="select();" 
                BackColor="Silver" >0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtTukuba_SubTotal1" 
                runat="server" class="txtTableType1"   MaxLength="3" onfocus="select();" 
                BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtSonota_SubTotal1" 
                runat="server" class="txtTableType1"   MaxLength="3" onfocus="select();" 
                BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtGoukei_SubTotal1" 
                runat="server" class="txtTableType1"   MaxLength="3" onfocus="select();" 
                BackColor="Silver">0</asp:TextBox></td>
		</tr>
		<!--合計-->
		<tr>
		<td   style="background:gray;" colspan="2">合　計</td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtMito_Total1"   
                runat="server" class="txtTableType1"     MaxLength="3" onblur="SumMito();"    
                onfocus="select();" BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtTuchiura_Total1" 
                runat="server" class="txtTableType1"  MaxLength="3" onblur="SumTuchiura();" 
                onfocus="select();" BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtTukuba_Total1" 
                runat="server" class="txtTableType1"   MaxLength="3" onblur="SumTukuba();"    
                onfocus="select();" BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;" colspan="2"><asp:TextBox ID="txtSonota_Total1" 
                runat="server" class="txtTableType1"   MaxLength="3" onblur="SumSonota();"    
                onfocus="select();" BackColor="Silver">0</asp:TextBox></td>
		<td  style="background:gray;"  colspan="2"><asp:TextBox ID="txtGoukei_Total1" 
                runat="server" class="txtTableType1"   MaxLength="3" onblur="SumGoukei();"   
                onfocus="select();" BackColor="Silver">0</asp:TextBox></td>
		</tr>
		</tbody>
		</table>
	</div>
<!--フッター-->
<div id="footer">
	<p class="footer_p">※直納及び県外からの登録も含む。</p>
	<p class="footer_p" >※翌月5日までに必ず報告のこと。</p>
</div>
<!--ボタン-->
<div id="footerButton">
	<asp:Button ID="btnSubmit" runat="server" Text="送信" onclick="btnSubmit_Click" onclientclick="return checkForms();" class="FooterBtn"/>
	<asp:Button ID="btnPrint" runat="server" Text="印刷" onclick="btnPrint_Click"  class="FooterBtn" />
    <asp:Button ID="btnKariInvoice" runat="server" Text="仮請求書印刷"   onclick="btnKariInvoice_Click"  class="FooterBtn"  />
</div>
</form>
</div>
</body>
</html>