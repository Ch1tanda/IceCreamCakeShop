using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._8_UserMain
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo user = dc.Userinfo.Where(p => p.username.Equals(Session["name"].ToString())).FirstOrDefault();
            Label1.Text = user.id;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {   
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo user = dc.Userinfo.Where(p => p.id.Equals(Label1.Text)).FirstOrDefault();
            Regex reg = new Regex(@"^\d{6,16}$");
            if (TextBox1.Text != user.password)
            {
                Label5.Text = "与原密码不匹配";
            }
            else if(!reg.IsMatch(TextBox2.Text)) { Label2.Text = "密码格式不正确，请输入6-16位数字"; Label5.Text = ""; }
            
            else if (TextBox3.Text != TextBox2.Text)
            {
                Label2.Text = ""; Label5.Text = "";
                Label4.Text = "与新密码不匹配";
            }
            else if (reg.IsMatch(TextBox2.Text) && TextBox2.Text == TextBox1.Text)
            {
                Label2.Text = ""; Label5.Text = "";
                Label4.Text = "修改后密码与修改前一样";
            }
            else if (reg.IsMatch(TextBox2.Text)&&TextBox2.Text == TextBox3.Text)
            {
                Label2.Text = ""; Label5.Text = "";
                Label4.Text = "";
                user.password = TextBox3.Text;
                dc.SubmitChanges();
                Response.Write("<script>alert('修改成功！');</script>");
                Response.Redirect("Profile.aspx");
              
            }
        }
    }
}