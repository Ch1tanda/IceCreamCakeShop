using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._4_CakeMakeManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Cakeinfo> cakeinfos = new List<Cakeinfo>();
            //string cid = "";
            List<Cakeinfo> cake = dc.Cakeinfo.Where(p => p.id.Contains(RadioButtonList1.SelectedValue)).ToList();
            foreach (var item in cake)
            {
                cakeinfos.Add(item);
            }
            //int newone = cake.Count() + 1;
            char c = cake.Last().id.Last();
            int nc = int.Parse(c.ToString()) + 1;
            string newone = cake.Last().id.Substring(0, cake.Last().id.Length - 1);
            newone += nc;
            Label5.Text = newone;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var id = Label5.Text;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Cakeinfo newCake = new Cakeinfo();
            newCake.id = id;
            newCake.name = TextBox1.Text.Trim();
            newCake.recipe = TextBox2.Text.Trim();
            newCake.price = Convert.ToDecimal(TextBox3.Text);
            dc.Cakeinfo.InsertOnSubmit(newCake);
            if (id.Contains("D"))
            {
                Stock newStock = new Stock();
                newStock.mid = id;
                newStock.name = newCake.name;
                newStock.stock = 0;
                dc.Stock.InsertOnSubmit(newStock);
            }
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