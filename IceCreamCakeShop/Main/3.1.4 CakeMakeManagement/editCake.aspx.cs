using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._4_CakeMakeManagement
{
    public partial class editCake : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Label5.Text = Request.QueryString["productID"];
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Cakeinfo cake = dc.Cakeinfo.Where(p => p.id.Equals(Label5.Text)).FirstOrDefault();
                TextBox1.Text = cake.name;
                TextBox2.Text = cake.recipe;
                TextBox3.Text = cake.price.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Cakeinfo cakeinfo = dc.Cakeinfo.Where(p => p.id.Equals(Label5.Text)).FirstOrDefault();
            cakeinfo.name = TextBox1.Text.Trim();
            cakeinfo.recipe = TextBox2.Text.Trim();
            cakeinfo.price = Convert.ToDecimal(TextBox3.Text.Trim());
            dc.SubmitChanges();
            Response.Redirect("CakeMakeManagement.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            String recipe = TextBox2.Text.Trim();
            int cnt = 0;
            for (int i = 0; i < recipe.Length; i++)
            {
                if (recipe[i] == 'M')
                    if (recipe[i + 3] == ':')
                        cnt++;
            }
            if (cnt != 10)
                Label7.Text = "请按照格式输入配方";
            else
                Label7.Text = "";
        }
    }
}