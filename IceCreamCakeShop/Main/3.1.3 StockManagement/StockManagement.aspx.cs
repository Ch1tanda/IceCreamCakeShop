using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._3_StockManagement
{
    public partial class StockManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tip.Visible = false;
            contain.Visible = false;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Stock> st = dc.Stock.Where(p=>p.stock < 100).ToList();
            string text = "";
            foreach(var item in st)
            {
                    text += item.name + ',';
            }
            if(text.Count() > 0)
            {
                text.Remove(text.Count() - 1);
                text += "库存不足，请及时补充";
                contain.Text = text;
                Tip.Visible = true;
                contain.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName .Equals ("editbtn"))
            {
                Response.Redirect($"stockPurchase.aspx?mid={e.CommandArgument }");
            }
            if(e.CommandName .Equals ("tuihuo"))
            {
                Response.Redirect($"stockReturn.aspx?mid={e.CommandArgument }");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}