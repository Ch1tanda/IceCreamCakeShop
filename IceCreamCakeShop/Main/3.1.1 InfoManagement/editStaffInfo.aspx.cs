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
            DataClasses1DataContext dc = new DataClasses1DataContext();
            string pw1 = PWBox.Text;
            string pw2 = RPWBox.Text;
            string PhoneNumString = PNBox.Text.ToString();
            string ageNum = AgeBox.Text.ToString();
            string salaryString = SalaryBox.Text.ToString();
            for (int i = 0; i < ageNum.Count(); i++)
            {
                if (ageNum[i] < '0' || ageNum[i] > '9')
                {
                    ageLab.Text = "年龄输入错误";
                    ageLab.Visible = true;
                    return;
                }
            }
            if (int.Parse(ageNum) > 60 || int.Parse(ageNum) < 18)
            {
                ageLab.Text = "年龄输入错误";
                ageLab.Visible = true;
                return;
            }
            ageLab.Visible = false;
            for (int i = 0; i < PhoneNumString.Count(); i++)
            {
                if (PhoneNumString[i] < '0' || PhoneNumString[i] > '9')
                {
                    PHETip.Text = "电话格式错误";
                    PHETip.Visible = true;
                    return;
                }
            }
            Staffinfo ExistStaffinfo = dc.Staffinfo.Where(p => p.phonenumber.Equals(PNBox.Text.Trim())).FirstOrDefault();
            if (ExistStaffinfo != null)
            {
                PHETip.Visible = true;
                PHETip.Text = "该电话号码已经被注册";
                return;
            }
            PHETip.Visible = false;
            for (int i = 0; i < salaryString.Count(); i++)
            {
                if (salaryString[i] < '0' || salaryString[i] > '9')
                {
                    salaryLab.Text = "工资输入错误";
                    salaryLab.Visible = true;
                    return;
                }
            }
            if (int.Parse(salaryString) > 10000 || int.Parse(salaryString) < 1500)
            {
                salaryLab.Text = "工资输入错误";
                salaryLab.Visible = true;
                return;
            }
            salaryLab.Visible = false;
            if (pw1.Equals(pw2) && pw1.Length != 0)
            {
                var staffid = StaffId.Text;

                Staffinfo EditedStaffInfo = dc.Staffinfo.Where(p => p.id.Equals(staffid)).FirstOrDefault();
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