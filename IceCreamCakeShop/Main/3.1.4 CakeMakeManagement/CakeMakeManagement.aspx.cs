using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCreamCakeShop.Main._3._1._4_CakeMakeManagement
{
    public partial class CakeMakeManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCake.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// 用于检索蛋糕信息
        /// </summary>
        protected void Search()
        {
            var cakeName = TextBox1.Text;
            var cate = RadioButtonList1.SelectedValue;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<Cakeinfo> cakeinfos = dc.Cakeinfo.Where(p => p.name.Contains(cakeName)).ToList();
            if (!cate.Equals("0"))
                cakeinfos = cakeinfos.Where(p => p.id.Contains(cate)).ToList();
            GridView1.DataSourceID = null;
            GridView1.DataSource = cakeinfos;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("edit"))
            {
                Response.Redirect($"editCake.aspx?productID={e.CommandArgument}");
            }
        }

    }
}