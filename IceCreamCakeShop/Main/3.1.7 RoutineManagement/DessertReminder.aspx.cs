using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._7_RoutineManagement
{
    public partial class DessertReminder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (GridView1.Rows.Count == 0)
                    Label1.Text = "点心库存充足。";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("add"))
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                string recipe = dc.Cakeinfo.Where(p => p.id.Equals(e.CommandArgument)).FirstOrDefault().recipe;
                /*List<int> rcp = new List<int>();
                for(int i=4;i<=recipe.Length;i+=5)
                {
                    rcp.Add(Convert.ToInt32(recipe[i].ToString()));
                }*/
                Stock ds = dc.Stock.Where(p => p.mid.Equals(e.CommandArgument)).FirstOrDefault();
                List<Stock> materials = dc.Stock.Where(p => p.mid.Contains("M")).ToList();
                int i = 4;
                foreach(var item in materials)
                {
                    //Label1.Text += (Convert.ToInt32(recipe[i].ToString()) * 5).ToString() + "<br>";
                    item.stock -= Convert.ToInt32(recipe[i].ToString()) * 5;
                    i += 5;
                }
                ds.stock += 5;
                dc.SubmitChanges();
                Response.Redirect(Request.Url.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../3.1.3 StockManagement/StockManagement.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}