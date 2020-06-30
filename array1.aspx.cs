using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class array1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //第一種宣告陣列並給值的方法
            //int[] sales = new int[3] { 500, 600, 800 };

            //第二種宣告陣列並給值的方法
            int[] sales = new int[3];
            sales[0] = 500;
            sales[1] = 600;
            sales[2] = 800;

            int total = 0;
            double avg =0;


            //total = sales[0] + sales[1] + sales[2];
            for (int i = 0; i < sales.Length; i++)
            {
                total += sales[i];
            }

            
            
            avg = total / 3;

            lblMsg.Text = "總業績=" + total.ToString() + ",平均業績=" + avg.ToString();

        }
    }
}