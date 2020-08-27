using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._1_InfoManagement
{
    public partial class AddStaffInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Staffinfo> staffinfos = new List<Staffinfo>();
            string Staffid = "";
            staffinfos = dc.Staffinfo.ToList();
            int newone = staffinfos.Count() + 1;
            Staffid = "000" + newone.ToString();
            StaffId.Text = Staffid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pw1 = PWBox.Text;
            string pw2 = RPWBox.Text;
            if (pw1.Equals(pw2) && pw1.Length != 0)
            {
                var staffid = StaffId.Text;
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Staffinfo NewStaffinfo = new Staffinfo();
                NewStaffinfo.id = staffid;
                NewStaffinfo.password = PWBox.Text.Trim();
                NewStaffinfo.name = NameBox.Text.Trim();
                NewStaffinfo.sex = SexRDL.SelectedValue.Trim();
                NewStaffinfo.age = AgeBox.Text.Trim();
                NewStaffinfo.phonenumber = PNBox.Text.Trim();
                NewStaffinfo.position = positionRDL.SelectedValue.Trim();
                NewStaffinfo.salary = SalaryBox.Text.Trim();
                dc.Staffinfo.InsertOnSubmit(NewStaffinfo);
                dc.SubmitChanges();
                Response.Redirect("StaffInfoManagement.aspx");
            }
            else
            {
                TipPW.Visible = true;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffInfoManagement.aspx");
        }
    }
}