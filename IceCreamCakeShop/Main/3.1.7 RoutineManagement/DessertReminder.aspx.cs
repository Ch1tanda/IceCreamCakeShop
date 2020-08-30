using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._7_RoutineManagement
{
    public partial class DessertReminder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Stock> stocks = dc.Stock.Where(p => p.mid.Contains(('D').ToString()) && p.stock < 5).ToList();
            string ss = "";
            int cnt = 1;
            foreach(var item in stocks)
            {
                ss += cnt.ToString() + ". " + item.mid + " " + item.name + " 库存不足" + "<br><br>";
                cnt++;
            }
            Label1.Text = ss;
        }


    }
}