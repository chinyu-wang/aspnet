using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            string[] pno = new string[6] { "12620024", "39793895", "67913945", "09954061", "54574947", "007" };
            string[] pname = new string[6] { "特別獎", "特獎", "頭獎", "頭獎", "頭獎", "增開六獎" };

            string inv = txtInvoice.Text;


            if (inv.Length != 8)
            {
                lblRst.Text = "發票號碼有誤,請重新輸入!";
                return;
            }



            if (inv == pno[0])
            {
                lblRst.Text = "恭喜中了" + pname[0] + ", 1000萬元!";
                return;
            }

            if (inv == pno[1])
            {
                lblRst.Text = "恭喜中了" + pname[1] + ", 200萬元!";
                return;
            }

            if (inv == pno[2])
            {
                lblRst.Text = "恭喜中了" + pname[2] + ", 20萬!";
                return;
            }

            // pno[2] 為頭獎第1組
            // pno[3] 為頭獎第2組
            // pno[4] 為頭獎第3組

            if (inv.Substring(1, 7) == pno[2].Substring(1, 7) || 
                inv.Substring(1, 7) == pno[3].Substring(1, 7) || 
                inv.Substring(1, 7) == pno[4].Substring(1, 7))
            {
                lblRst.Text = "恭喜中了二獎, 4萬元!";
                return;
            }

            if (inv.Substring(2, 6) == pno[2].Substring(2, 6) || 
                inv.Substring(2, 6) == pno[3].Substring(2, 6) || 
                inv.Substring(2, 6) == pno[4].Substring(2, 6))
            {
                lblRst.Text = "恭喜中了三獎, 1萬元!";
                return;
            }

            if (inv.Substring(3, 5) == pno[2].Substring(3, 5) || 
                inv.Substring(3, 5) == pno[3].Substring(3, 5) || 
                inv.Substring(3, 5) == pno[4].Substring(3, 5))
            {
                lblRst.Text = "恭喜中了四獎, 4千元!";
                return;
            }

            if (inv.Substring(4, 4) == pno[2].Substring(4, 4) || 
                inv.Substring(4, 4) == pno[3].Substring(4, 4) || 
                inv.Substring(4, 4) == pno[4].Substring(4, 4))
            {
                lblRst.Text = "恭喜中了五獎, 1千元!";
                return;
            }

            if (inv.Substring(5, 3) == pno[2].Substring(5, 3) || 
                inv.Substring(5, 3) == pno[3].Substring(5, 3) || 
                inv.Substring(5, 3) == pno[4].Substring(5, 3))
            {
                lblRst.Text = "恭喜中了六獎, 200元!";
                return;
            }

            if (inv.Substring(5,3) == pno[5])
            {
                lblRst.Text = "恭喜中了" + pname[5] + ", 200元!";
                return;
            }

            lblRst.Text = inv + "沒中獎喔!";

        }
    }
}