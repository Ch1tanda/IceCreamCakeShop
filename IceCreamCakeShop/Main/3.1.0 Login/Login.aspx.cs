using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._0_Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo user = dc.Userinfo.Where(p => p.phonenumber.Equals(TextBox1.Text)).FirstOrDefault();
            if (user is null)
            {
                Staffinfo staff = dc.Staffinfo.Where(p => p.phonenumber.Equals(TextBox1.Text)).FirstOrDefault();
                if (staff is null)
                    Response.Write("<script>alert('账号或密码错误')</script>");
                else
                {
                    if (staff.password.Equals(TextBox2.Text))
                    {
                        //Response.Write("<script>alert('登录成功！')</script>");
                        Session["position"] = "staff";
                        Session["name"] = staff.name;
                        Session["id"] = staff.id;
                        Response.Redirect("~/Main/3.1.4 CakeMakeManagement/CakeMakeManagement.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('密码错误')</script>");
                    }
                }
            }
            else
            {
                if (user.password.Equals(TextBox2.Text))
                {   
                    Response.Write("<script>alert('登录成功！')</script>");
                    Session["position"] = "user";
                    Session["name"] = user.username;
                    Session["id"] = user.id;
                    Response.Redirect("../3.1.8 UserMain/CakeDessertPurchase.aspx");
                }
                else
                {
                    Response.Write("<script>alert('密码错误')</script>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}