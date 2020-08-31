using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._1_InfoManagement
{
    public partial class editStaffInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StaffId.Text = Request.QueryString["StaffID"];
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Staffinfo staff = dc.Staffinfo.Where(p => p.id.Equals(StaffId.Text)).FirstOrDefault();
                NameBox.Text = staff.name;
                AgeBox.Text = staff.age;
                PNBox.Text = staff.phonenumber;
                SalaryBox.Text = staff.salary;
                SexRDL.SelectedValue = staff.sex;
                positionRDL.SelectedValue = staff.position;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pw1 = PWBox.Text;
            string pw2 = RPWBox.Text;
            if (pw1.Equals(pw2) && pw1.Length != 0)
            {
                var staffid = StaffId.Text;
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Staffinfo EditedStaffInfo = dc.Staffinfo.Where(p=>p.id.Equals(staffid)).FirstOrDefault();
                EditedStaffInfo.password = PWBox.Text.Trim();
                EditedStaffInfo.name = NameBox.Text.Trim();
                EditedStaffInfo.sex = SexRDL.SelectedValue.Trim();
                EditedStaffInfo.age = AgeBox.Text.Trim();
                EditedStaffInfo.phonenumber = PNBox.Text.Trim();
                EditedStaffInfo.position = positionRDL.SelectedValue.Trim();
                EditedStaffInfo.salary = SalaryBox.Text.Trim();
                dc.SubmitChanges();
                Response.Redirect("DismissOrChangeStaffInfo.aspx");
            }
            else
            {
                TipPW.Visible = true;
            }




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DismissOrChangeStaffInfo.aspx");
        }
    }
}