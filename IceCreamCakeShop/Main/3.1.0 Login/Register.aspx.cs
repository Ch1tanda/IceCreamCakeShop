using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._0_Login
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (year.Text == "" || month.Text == "" || days.Text == ""
              || password.Text == "" || repassword.Text == ""
              || phonenumber.Text == "" || address.Text == "")
            {
                IsNULLTip.Text = "注册信息填写不完整";
                IsNULLTip.Visible = true;
                return;
            }
            IsNULLTip.Visible = false;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Userinfo NewUserInfo = new Userinfo();
            string TempYear = year.Text.ToString();
            string TempMonth = month.Text.ToString();
            string TempDays = days.Text.ToString();
            string PhoneNumString = phonenumber.Text.ToString();
            for (int i = 0; i < PhoneNumString.Count(); i++)
            {
                if (PhoneNumString[i] < '0' || PhoneNumString[i] > '9')
                {
                    PHETip.Text = "电话格式错误";
                    PHETip.Visible = true;
                    return;
                }
            }
            Userinfo ExistUserInfo = dc.Userinfo.Where(p => p.phonenumber.Equals(phonenumber.Text.Trim())).FirstOrDefault();
            if (ExistUserInfo != null)
            {
                PHETip.Visible = true;
                PHETip.Text = "该电话号码已经被注册";
                return;
            }
            PHETip.Visible = false;
            char zero = '0';
            string maxDyas = zero.ToString();
            if (!CheckDays(TempYear, TempMonth, TempDays))
            {
                ErrorTip.Visible = true;
                return;
            }
            if (int.Parse(TempYear) > 1900 && int.Parse(TempYear) < 2500
               && int.Parse(TempMonth) > 0 && int.Parse(TempMonth) < 13)
            {
                maxDyas = GetDays(TempYear, TempMonth);

            }
            if (int.Parse(TempDays) > int.Parse(maxDyas) || int.Parse(TempDays) < 1)
            {
                ErrorTip.Visible = true;
            }
            else
            {
                PHETip.Visible = false;
                if (TempMonth.Count() == 1)
                {
                    TempMonth = zero + TempMonth;
                }
                if (TempDays.Count() == 1)
                {
                    TempDays = zero + TempDays;
                }
                string birthday = TempYear + TempMonth + TempDays;
                List<Userinfo> TempList = dc.Userinfo.Where(p => p.birthday.Equals(birthday)).ToList();
                int length = TempList.Count();
                string m = (length / 10).ToString();
                string n = (length % 10).ToString();
                string TempID = birthday + m + n;
                NewUserInfo.id = TempID.Trim();
                NewUserInfo.password = password.Text.Trim();
                NewUserInfo.username = name.Text.Trim();
                NewUserInfo.phonenumber = phonenumber.Text.Trim();
                NewUserInfo.address = address.Text.Trim();
                NewUserInfo.birthday = birthday.Trim();
                NewUserInfo.viptype = zero.ToString().Trim();
                NewUserInfo.gmv = 0;
                dc.Userinfo.InsertOnSubmit(NewUserInfo);
                dc.SubmitChanges();
                Response.Redirect("Login.aspx");
            }

        }

        protected bool CheckDays(string TempYear, string TempMonth, string TempDays)
        {
            for (int i = 0; i < TempYear.Count(); i++)
            {
                if (TempYear[i] < '0' || TempYear[i] > '9')
                {
                    return false;
                }
            }
            for (int i = 0; i < TempMonth.Count(); i++)
            {
                if (TempMonth[i] < '0' || TempMonth[i] > '9')
                {
                    return false;
                }
            }
            for (int i = 0; i < TempDays.Count(); i++)
            {
                if (TempDays[i] < '0' || TempDays[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        protected string GetDays(string year, string month)
        {
            int days = 31;
            switch (int.Parse(month))
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    {
                        if (int.Parse(year) % 4 == 0 && int.Parse(year) % 100 != 0
                            || int.Parse(year) % 400 == 0)
                        {
                            days = 29;
                        }
                        else
                        {
                            days = 28;
                        }
                        break;
                    }
            }
            return days.ToString();
        }
    }
}