using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Igarashi
using Jisseki_Report_Ibaraki.Tools;



namespace Jisseki_Report_Ibaraki.member.menu
{
    public partial class Dealer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ログインしていなければ表示しない
            if (Session["COCODE"] == null)
            {
                Response.Redirect(URL.LOGIN_DEALER);
            }

        }

        protected void btnInputJisseki_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.INPUT_JISSEKI);
           
        }

        protected void btnSearchJisseki_Click(object sender, EventArgs e)
        {
            Response.Redirect(URL.SEARCH_JISSEKI);
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(URL.LOGIN_DEALER);
        }

    }
}