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
                Response.Redirect($"~/Main/3.1.8 UserMain/Buying.aspx?ProductID={e.CommandArgument}");
            }
        }
        protected void UpdateVip(string id, decimal cmv)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo customer = dc.Userinfo.Where(p => p.id.Equals(id)).FirstOrDefault();
            customer.gmv += cmv;
            if(customer.gmv >= 100 && customer.gmv < 300)
            {
                customer.viptype = '1'.ToString();
            }else if(customer.gmv >= 300 && customer.gmv < 800)
            {
                customer.viptype = '2'.ToString();
            }
            else if(customer.gmv >= 800)
            {
                customer.viptype = '3'.ToString();
            }
            dc.SubmitChanges();
        }
        protected float GetDiscount(string id)
        {
            float discount = 1F;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo customer = dc.Userinfo.Where(p => p.id.Equals(id)).FirstOrDefault();
            switch (int.Parse(customer.viptype))
            {
                case 1:
                    discount = 0.9F;
                    break;
                case 2:
                    discount = 0.8F;
                    break;
                case 3:
                    discount = 0.7F;
                    break;
            }
            return discount;
        }
    }
}