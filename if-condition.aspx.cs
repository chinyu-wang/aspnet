using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class if_condition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int height = 0;
            if (!int.TryParse(txtHeight.Text, out height))
            {
                lblRst.Text = "請輸入正確資料!";
                return;
            }


            if (height > 120)
            {
                lblRst.Text = "請購買全票.";
            }
            else
            {
                lblRst.Text = "您可購買半票.";
            }


        }

        protected void btnAge_Click(object sender, EventArgs e)
        {
            int age = 0;

            if (!int.TryParse(txtAge.Text, out age))
            {
                lblRst.Text = "請輸入正確資料!";
                return;
            }

            if (age >= 65)
            {
                lblRst.Text = "您可購買敬老票.";
            }
            else
            {
                if (age <= 18)
                {
                    lblRst.Text = "您可購買學生票.";
                }
                else
                {
                    lblRst.Text = "請購買普通票.";
                }
            }



        }
    }
}