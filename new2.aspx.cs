using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class new2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            double dblUSD = Convert.ToDouble(txtUSD.Text);
            double dblRate = Convert.ToDouble(txtRate.Text);

            double dblNTD = dblUSD * dblRate;

            lblMsg.Text = dblUSD.ToString() + "美元可兌換" + dblNTD.ToString() + "台幣 (匯率 1:" + dblRate.ToString() + ")";
        

        }


    }
}