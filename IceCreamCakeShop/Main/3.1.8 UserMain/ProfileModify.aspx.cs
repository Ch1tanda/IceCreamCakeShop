using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class WebForm6 : System.Web.UI.Page
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
                    TextBox1.Text = user.username;
                    TextBox2.Text = user.phonenumber;
                    TextBox3.Text = user.address;
                    TextBox4.Text = user.birthday;
                    Label2.Text = user.viptype;
                    Label3.Text = user.gmv.ToString();

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo user = dc.Userinfo.Where(p => p.id.Equals(Label1.Text)).FirstOrDefault();
            user.username = TextBox1.Text;
            user.phonenumber = TextBox2.Text;
            user.address = TextBox3.Text;
            user.birthday = TextBox4.Text;
            dc.SubmitChanges();
            Response.Redirect("Profile.aspx");
        }
    }
}