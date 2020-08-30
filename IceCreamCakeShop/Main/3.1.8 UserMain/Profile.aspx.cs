using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["position"].ToString() == "user")
                {
                    String name = Session["name"].ToString();
                    DataClasses1DataContext dc = new DataClasses1DataContext();
                    Userinfo user = dc.Userinfo.Where(p => p.username.Equals(name)).FirstOrDefault();
                    Label1.Text = user.id;
                    Label2.Text = user.username;
                    Label3.Text = user.phonenumber;
                    Label4.Text = user.address;
                    Label5.Text = user.birthday;
                    Label6.Text = user.viptype;
                    Label7.Text = user.gmv.ToString();

                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CakeDessertPurchase.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}