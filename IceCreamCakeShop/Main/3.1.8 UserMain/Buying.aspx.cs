using Microsoft.SqlServer.Server;
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
                Label9.Text = "1000";
                Label9.Visible = false;
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
            decimal dis = GetDiscount(Session["id"].ToString());
            string dicountString = (dis * 10).ToString();
            discountTip.Text = "已享受"+ dicountString + "折优惠";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var pid = Request.QueryString["productID"];
            int num;
            if (!TextBox2.Text.Equals(""))
                num = Convert.ToInt32(TextBox2.Text);
            else
                num = 1;
            /*if (!Label9.Text.Equals(""))
                if (num > Convert.ToInt32(Label9.Text))
                    Response.Write("<script>alert('抱歉，该商品库存不足。')</script>");
            Response.Redirect(Request.Url.ToString());*/
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DateTime dateTime = DateTime.Now;
            Cakeinfo cake = dc.Cakeinfo.Where(p => p.id.Equals(pid)).FirstOrDefault();
            Userorder userorder = new Userorder();
            userorder.id = cake.id + getDateId(dateTime) + Session["id"].ToString();
            userorder.userid = Session["id"].ToString();
            userorder.time = dateTime;
            userorder.number = num;
            userorder.price = Convert.ToDecimal(num * GetDiscount(Session["id"].ToString()) * cake.price);
            userorder.cdid = pid;
            userorder.staffid = "0001";
            dc.Userorder.InsertOnSubmit(userorder);
            if (pid.Contains("D"))
            {
                Stock stock = dc.Stock.Where(p => p.mid.Equals(pid)).FirstOrDefault();
                stock.stock -= num;
            }
            dc.SubmitChanges();
            UpdateVip(userorder.userid, userorder.price);
            Response.Redirect("~/Main/3.1.8 UserMain/CakeDessertPurchase.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBox2.Text) > Convert.ToInt32(Label9.Text))
            {
                Response.Write("<script>alert('抱歉，该商品库存不足。')</script>");
                Response.Redirect(Request.Url.ToString());
            }
            foreach (var c in TextBox2.Text.Trim())
            {
                if (c > '0' && c < '9')
                    continue;
                else
                    Response.Redirect(Request.Url.ToString());
            }
            DataClasses1DataContext dc = new DataClasses1DataContext();
            decimal dis = GetDiscount(Session["id"].ToString());
            Label8.Text = (dc.Cakeinfo.Where(p => p.id.Equals(Request.QueryString["productID"])).FirstOrDefault().price * Convert.ToInt32(TextBox2.Text) * dis).ToString();
        }

        protected void UpdateVip(string id, decimal cmv)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo customer = dc.Userinfo.Where(p => p.id.Equals(id)).FirstOrDefault();
            customer.gmv += cmv;
            if (customer.gmv >= 100 && customer.gmv < 300)
            {
                customer.viptype = '1'.ToString();
            }
            else if (customer.gmv >= 300 && customer.gmv < 800)
            {
                customer.viptype = '2'.ToString();
            }
            else if (customer.gmv >= 800)
            {
                customer.viptype = '3'.ToString();
            }
            dc.SubmitChanges();
        }

        protected decimal GetDiscount(string id)
        {
            decimal discount = 1;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo customer = dc.Userinfo.Where(p => p.id.Equals(id)).FirstOrDefault();
            switch (int.Parse(customer.viptype))
            {
                case 1:
                    discount = 0.9M;
                    break;
                case 2:
                    discount = 0.8M;
                    break;
                case 3:
                    discount = 0.7M;
                    break;
            }
            return discount;
        }
        string getDateId(DateTime dateTime)
        {
            int y = dateTime.Year;
            int m = dateTime.Month;
            int d = dateTime.Day;
            int h = dateTime.Hour;
            int min = dateTime.Minute;
            int s = dateTime.Second;
            string time = formatDateId(y) + formatDateId(m) + formatDateId(d) + formatDateId(h) + formatDateId(min) + formatDateId(s);
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