using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace IceCreamCakeShop.Main._3._1._1_InfoManagement
{
    public partial class DismissOrChangeStaffInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffInfoManagement.aspx");
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("edit"))
            {
                Response.Redirect($"editStaffInfo.aspx?StaffID={e.CommandArgument}");
            }
        }
    }
}