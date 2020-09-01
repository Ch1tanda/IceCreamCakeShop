using System;
using System.Collections.Generic;
using System.Linq;
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
            if (TextBox1.Text != user.password)
            {
                Response.Write("<script>alert('原密码错误');</script>");
            }else if (TextBox2.Text == TextBox3.Text)
            {
                user.password = TextBox3.Text;
                dc.SubmitChanges();
                Response.Write("<script>alert('修改成功！');</script>");
                Response.Redirect("Profile.aspx");
              
            }
        }
    }
}