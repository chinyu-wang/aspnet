using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class new1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            double rate = 30.97;
            int usd = 1;

            double ntd = rate * usd;

            

            lblMsg.Text = "可轉換成台幣" + Math.Round(ntd,0) + "元";

        }
    }
}