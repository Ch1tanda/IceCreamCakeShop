using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                Response.Redirect("~/Main/3.1.0 Login/Login.aspx");
            }

            DataClasses1DataContext dc = new DataClasses1DataContext();
            var da = DateTime.Today;
            String month;
            if (da.Month < 10)
            {
                month = "0" + da.Month.ToString();
            }
            else month = da.Month.ToString();

            String day = da.Day.ToString();
            if (da.Day < 10)
            {
                day = "0" + da.Day.ToString();
            }
            else day = da.Day.ToString();

            String combine = month + day;

            var user = dc.Userinfo;
            var relist = user.Where(p => p.birthday.ToString().Substring(4) == combine).FirstOrDefault();
            if(relist!=null&&relist.birthday.ToString().Substring(4) == combine)
            {
                Button1.Text = "今天有人有生日，请尽快联系是否订蛋糕";
            }
            else
            {
                Button1.Style.Add("display", "none");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main/3.1.7 RoutineManagement/Birthday.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main/3.1.0 Login/Login.aspx");
        }
    }
}