using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Net;
using System.IO;
using System.Text;


namespace WebApplication1
{
    public partial class new3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.taifex.com.tw/data_gov/taifex_open_data.asp?data_name=DailyForeignExchangeRates", "test.csv");

            ReadCSV("test.csv");
        }

        public void ReadCSV(string filePath)
        {
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            string strLine = "";
            string[] strArray = null;

            while ((strLine = sr.ReadLine()) != null)
            {
                strArray = strLine.Split(',');
            }

            txtRate.Text = strArray[1];
            lblDate.Text = strArray[0];

            sr.Close();
            fs.Close();

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            double dblUSD = 0;
            if(!double.TryParse(txtUSD.Text, out dblUSD))
            {
                lblMsg.Text = "請輸入正確USD資料.";
                return;
            }

            double dblRate = Convert.ToDouble(txtRate.Text);

            double dblNTD = dblUSD * dblRate;

            lblMsg.Text = dblUSD.ToString() + "美元可兌換" + dblNTD.ToString() + "台幣 (匯率 1:" + dblRate.ToString() + ")";
        

        }
    }
}