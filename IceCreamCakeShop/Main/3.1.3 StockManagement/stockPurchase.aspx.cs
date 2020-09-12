using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._3_StockManagement
{
    public partial class stockpurchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                if (Request.QueryString["mid"] != null)
                {
                    var mid = Convert.ToString(Request.QueryString["mid"]);
                    DataClasses1DataContext dc = new DataClasses1DataContext();
                    var kc = dc.Stock.Where(p => p.mid.Equals(mid)).FirstOrDefault();
                    TextBox1.Text = mid.ToString();
                    this.TextBox2.Text = kc.name;
                    this.TextBox3.Text = kc.stock.ToString();

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e) 
        {
            var mid = Convert.ToString(Request.QueryString["mid"]);
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Stock kc = dc.Stock.Where(p => p.mid.Equals(mid)).FirstOrDefault();
            kc.stock += Convert .ToInt32 (TextBox4.Text);
            dc.SubmitChanges();
            Response.Redirect("StockManagement.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockManagement.aspx");
        }
    }
}