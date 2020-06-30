using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class id_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            string S1 = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string S2 = "10,11,12,13,14,15,16,17,34,18,19,20,21,22,35,23,24,25,26,27,28,29,32,30,31,33";

            string[] D1 = S1.Split(',');
            string[] D2 = S2.Split(',');

            string id = txtID.Text;

            string d0 = id[0].ToString();
            
            int d1 = Convert.ToInt16(id[1]);
            int d2 = Convert.ToInt16(id[2]);
            int d3 = Convert.ToInt16(id.Substring(3, 1));
            int d4 = Convert.ToInt16(id.Substring(4, 1));
            int d5 = Convert.ToInt16(id.Substring(5, 1));
            int d6 = Convert.ToInt16(id.Substring(6, 1));
            int d7 = Convert.ToInt16(id.Substring(7, 1));
            int d8 = Convert.ToInt16(id.Substring(8, 1));
            int d9 = Convert.ToInt16(id.Substring(9, 1));

            int idx = Array.IndexOf(D1, d0); //取得d0在D1陣列內的索引編號
            string d = D2[idx];

            int a0 = Convert.ToInt16(d[0]);
            int a1 = Convert.ToInt16(d[1]);

            int rst = a0 * 1 + a1 * 9 + d1 * 8 + d2 * 7 + d3 * 6 + d4 * 5 + d5 * 4 + d6 * 3 + d7 * 2 + d8 * 1;

            rst = rst % 10;

            rst = 10 - rst;

            if (rst == d9)
                lblRst.Text = id + "是正確的身分證字號.";
            else
                lblRst.Text = id + "是錯誤的身分證字號.";



        }
    }
}