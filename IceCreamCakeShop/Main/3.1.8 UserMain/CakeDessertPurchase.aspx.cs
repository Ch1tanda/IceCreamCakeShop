using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = GridView1.Columns[0].HeaderText;
            if (Session.Count == 0)
            {
                Response.Redirect("~/Main/3.1.0 Login/Login.aspx");
            }
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
            if (e.CommandName.Equals("buy"))
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Stock dessert = dc.Stock.Where(p => p.mid.Equals(e.CommandArgument)).FirstOrDefault();
                if (dessert != null)
                {
                    if (dessert.stock <= 0)
                        Response.Write("<script>alert('抱歉，该商品暂时售罄。')</script>");
                    else
                        Response.Redirect($"~/Main/3.1.8 UserMain/Buying.aspx?ProductID={e.CommandArgument}");
                }
                else
                    Response.Redirect($"~/Main/3.1.8 UserMain/Buying.aspx?ProductID={e.CommandArgument}");
            }
        }


    }
}