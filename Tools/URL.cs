using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jisseki_Report_Ibaraki.Tools
{
    public class URL
    {
      //ログイン画面
        public const string LOGIN_DEALER = "~/INRRlogin.aspx";
    　//共通
      public const string INPUT_JISSEKI = "~/common/input_jisseki.aspx" ;
      public const string ALTER_JISSEKI = "~/common/alter_jisseki.aspx";
      public const string DELETE_JISSEKI = "~/common/delete_jisseki.aspx";
      //会員
      public const string MENU_DEALER = "~/member/menu/Dealer.aspx";
      public const string SEARCH_JISSEKI = "~/member/search/jisseki.aspx";
      //自販連
      public const string MENU_JADA = "~/jada/menu/Jihan.aspx";
      public const string SERCH_NON_REPORTED = "~/jada/search/nonReported_member.aspx";
      public const string SERCH_REPORTED = "~/jada/search/reported_member.aspx";     
      
      public const string ID_MASTER = "~/jada/master/IdMaster.aspx";
      public const string UNIT_PRICE_MADTER = "~/jada/master/UnitPriceMaster.aspx";

      public const string DOWNLOAD_REPORTRED_DATA = "~/jada/download/Jisseki_Report.aspx";

      //レポート
      //実績報告書(相対パスJavaScript用)
      public const string REPORT_JISSEKI_REPORT_JS = "../Report/Jisseki_Report/Jisseki_Report_View.aspx";
      //仮請求書(相対パスJavaScript用)
      public const string REPORT_KARI_INVOICE_REPORT_JS = "../Report/Invoice/Invoice_View.aspx";
    }
}