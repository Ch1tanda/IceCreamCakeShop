using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._1_InfoManagement
{
    public partial class AddSupplierInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Supplierinfo> Supplierinfos = new List<Supplierinfo>();
            string Supplierid = "";
            Supplierinfos = dc.Supplierinfo.ToList();
            int newone = Supplierinfos.Count() + 1;
            Supplierid = "000" + newone.ToString();
            SupplierId.Text = Supplierid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var Supplierid = SupplierId.Text;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Supplierinfo NewSupplierinfo = new Supplierinfo();
            NewSupplierinfo.id = Supplierid;
            NewSupplierinfo.name = NameBox.Text.Trim();
            NewSupplierinfo.tel = PNBox.Text.Trim();
            dc.Supplierinfo.InsertOnSubmit(NewSupplierinfo);
            dc.SubmitChanges();
            Response.Redirect("SupplierInfoManagement.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffInfoManagement.aspx");
        }
    }
}