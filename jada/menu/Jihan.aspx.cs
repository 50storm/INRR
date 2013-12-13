using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jisseki_Report_Ibaraki.Tools;

namespace Jisseki_Report_Ibaraki.jada.menu
{
    public partial class Jihan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }

        }

        protected void btn_NonReportedSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.SERCH_NON_REPORTED);
        }

        protected void btn_ReportedSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.SERCH_REPORTED);
        }

        protected void btn_ID_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.ID_MASTER);

        }

        protected void bnt_DownloadReortedData_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.DOWNLOAD_REPORTRED_DATA);
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(URL.LOGIN_DEALER);
        }

        protected void btnUnitPrice_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.UNIT_PRICE_MADTER);
        }
    }
}