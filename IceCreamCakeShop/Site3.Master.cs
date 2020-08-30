using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop
{
    public partial class Site3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PasswordModify.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderSearch.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CakeDessertPurchase.aspx");
        }
    }
}