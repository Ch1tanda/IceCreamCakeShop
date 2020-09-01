using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class Buying : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();
            var pid = Request.QueryString["productID"];
            if (pid.Contains("C"))
            {
                Label4.Text = "预订蛋糕";
                Button1.Text = "预定";

            }
            else
            {
                Label4.Text = "购买点心";
                Button1.Text = "购买";
                Stock curr = dc.Stock.Where(p => p.mid.Equals(pid)).FirstOrDefault();
                Label6.Text = "剩余库存：";
                Label9.Text = curr.stock.ToString();
            }
            Cakeinfo cake = dc.Cakeinfo.Where(p => p.id.Equals(pid)).FirstOrDefault();
            Label8.Text = cake.price.ToString();
            Label5.Text = cake.name.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var pid = Request.QueryString["productID"];
            int num;
            if (!TextBox2.Text.Equals(""))
                num = Convert.ToInt32(TextBox2.Text);
            else
                num = 1;
            if (!Label9.Text.Equals(""))
                if (num > Convert.ToInt32(Label9.Text))
                    Response.Redirect(Request.Url.ToString());
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DateTime dateTime = DateTime.Now;
            Cakeinfo cake = dc.Cakeinfo.Where(p => p.id.Equals(pid)).FirstOrDefault();
            Userorder userorder = new Userorder();
            userorder.id = cake.id + getDateId(dateTime) + Session["id"].ToString();
            userorder.userid = Session["id"].ToString();
            userorder.time = dateTime;
            userorder.number = num;
            userorder.price = Convert.ToDecimal(Label8.Text);
            userorder.cdid = pid;
            userorder.staffid = "0001";
            dc.Userorder.InsertOnSubmit(userorder);
            dc.SubmitChanges();
            Response.Redirect("~/Main/3.1.8 UserMain/CakeDessertPurchase.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

            foreach (var c in TextBox2.Text.Trim())
            {
                if (c > '0' && c < '9')
                    continue;
                else
                    Response.Redirect(Request.Url.ToString());
            }
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Label8.Text = (dc.Cakeinfo.Where(p => p.id.Equals(Request.QueryString["productID"])).FirstOrDefault().price * Convert.ToInt32(TextBox2.Text)).ToString();
        }
        string getDateId(DateTime dateTime)
        {
            int y = dateTime.Year;
            int m = dateTime.Month;
            int d = dateTime.Day;
            string time = formatDateId(y) + formatDateId(m) + formatDateId(d);
            return time;
        }
        string formatDateId(int t)
        {
            string id = "";
            if (t < 10)
                id = '0' + t.ToString();
            else
                id = t.ToString();
            return id;
        }

    }
}