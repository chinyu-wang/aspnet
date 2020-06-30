using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            try
            {

                int teaAmt1 = Convert.ToInt16(txtTea1.Text);
                int teaAmt2 = Convert.ToInt16(txtTea2.Text);
                int teaAmt3 = Convert.ToInt16(txtTea3.Text);

                int teaUP1 = 25;
                int teaUP2 = 25;
                int teaUP3 = 30;

                int tot = teaAmt1 * teaUP1 + teaAmt2 * teaUP2 + teaAmt3 * teaUP3;

                lblMsg.Text = "總金額" + tot.ToString() + "元";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }

        }




    
    }
}
