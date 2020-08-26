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
            string cid = "";
            List<Cakeinfo> cake = dc.Cakeinfo.Where(p => p.id.Contains(RadioButtonList1.SelectedValue)).ToList();
            foreach (var item in cake)
            {
                cakeinfos.Add(item);
            }
            int newone = cake.Count() + 1;
            cid = RadioButtonList1.SelectedValue + "00" + newone.ToString();
            Label5.Text = cid;
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
            dc.SubmitChanges();
            Response.Redirect("CakeMakeManagement.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}