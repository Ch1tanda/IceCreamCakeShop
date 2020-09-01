using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        protected void Search()
        {
            var cate = RadioButtonList1.SelectedValue;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Cakeinfo> cakeinfos = dc.Cakeinfo.Where(p => p.id.Contains(cate)).ToList();
            GridView1.DataSourceID = null;
            GridView1.DataSource = cakeinfos;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(Session.Count == 0)
            {
                Response.Write("<script>alert('请先登录')</script>");
                Response.Redirect("~/Main/3.1.0 Login/Login.aspx");
            }
        }
    }


}