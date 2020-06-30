using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class db : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex >= 0)
            {
                lblRst.Text = "您選擇的是: " + DropDownList1.SelectedItem.Text;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex >= 0)
            {
                lblRst.Text = "您選擇的是: " + DropDownList1.SelectedItem.Text;
            }
        }
    }
}