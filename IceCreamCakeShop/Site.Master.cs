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
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var da = DateTime.Today;
            String year = da.Year.ToString();
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

            String combine = year + month + day;

            var user = dc.Userinfo;
            var relist = user.Where(p => p.birthday == combine).FirstOrDefault();
            if(relist.birthday.ToString() == combine)
            {
                Button1.Text = "今天有人有生日，请尽快联系是否订蛋糕";
                Session["birthday"] = combine;
            }
            else
            {
                Button1.Style.Add("display", "none");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}