using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._7_RoutineManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class USER
        {
            public String id;
            public String username;
            public String phonenumber;
            public USER(String id,String username,String phonenumber)
            {
                this.id = id;
                this.username = username;
                this.phonenumber = phonenumber;
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

                DataClasses1DataContext dc = new DataClasses1DataContext();

                List<Userinfo> list = dc.Userinfo.Where(p => p.birthday.ToString().Substring(4) == combine).ToList();
                List<Userinfo> userList = new List<Userinfo>();
                foreach (var item in list)
                {
                    var u = new Userinfo();
                    u.id = item.id;
                    u.username = item.username;
                    u.phonenumber = item.phonenumber;
                    userList.Add(u);
                }
                GridView1.DataSourceID = null;
                GridView1.DataSource = userList;
                GridView1.DataBind();
                
            }
            
        }

    }
}