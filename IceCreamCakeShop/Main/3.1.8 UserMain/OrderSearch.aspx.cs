using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CurrentID = Session["id"].ToString();
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Userorder> userorders = dc.Userorder.Where(p => p.userid.Equals(CurrentID)).ToList();
            GridView1.DataSourceID = null;
            GridView1.DataSource = userorders;
            GridView1.DataBind();
        }
    }
}