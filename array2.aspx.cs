using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class array2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int[,] sales = new int[3, 2];
            sales[0, 0] = 300;
            sales[0, 1] = 400;
            sales[1, 0] = 350;
            sales[1, 1] = 380;
            sales[2, 0] = 200;
            sales[2, 1] = 300;

            lblMsg.Text = "第1位平均業績=" + (sales[0, 0] + sales[0, 1]) / 2 + "<br>" +
                          "第2位平均業績=" + (sales[1, 0] + sales[1, 1]) / 2 + "<br>" +
                           "第3位平均業績=" + (sales[2, 0] + sales[2, 1]) / 2 + "<br>" +
                           "公司前年平均業績=" + (sales[0, 0] + sales[1, 0] + sales[2, 0]) / 3 + "<br>" +
                           "公司去年平均業績=" + (sales[0, 1] + sales[1, 1] + sales[2, 1]) / 3 + "<br>";

        }
    }
}