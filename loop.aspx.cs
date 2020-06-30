using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class loop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            int num = 0;
            if (!int.TryParse(txtNun.Text, out num))
            {
                lblRst.Text = "請輸入正確數值.";
                return;
            }

            if (num < 0)
            {
                lblRst.Text = "請輸入正整數.";
                return;
            }

            int tot = 0;
            for (int i = 0; i <= num; i++)
            {
                tot += i;  
            }

            lblRst.Text = "從0加到" + num.ToString() + "總和=" + tot.ToString();


        }

        protected void btn99_Click(object sender, EventArgs e)
        {
            lbl99.Text = "";

            //表格開頭
            lbl99.Text = "<table border=1>";

            for (int i = 1; i <= 9; i++)
            {
                //橫列開頭
                lbl99.Text += "<tr>";

                //處理直欄
                for (int j = 1; j <= 9; j++)
                {
                    lbl99.Text += "<td width=30 height=30 align=right>";
                    lbl99.Text += "<font size=4>";
                    lbl99.Text += (i * j).ToString();
                    lbl99.Text += "</font>";
                    lbl99.Text += "</td>";
                }

                //橫列結尾
                lbl99.Text += "</tr>";
            }

            //表格結尾
            lbl99.Text += "</table>";


        }
    }
}