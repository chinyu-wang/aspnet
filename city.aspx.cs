using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class city : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnDist_Click(object sender, EventArgs e)
        {

            Panel1.Visible = true;
            Panel2.Visible = false;


            // 城市名稱
            string[] city = new string[] { "台北", "桃園", "新竹", "台中", "嘉義", "台南", "高雄" };

            // 城市所在位置
            int[] position = new int[] { 25, 49, 95, 178, 264, 327, 373 };

            // n個城市
            int n = position.Length;

            // 宣告一個二維陣列儲存城市間的距離
            int[,] distance = new int[n, n];            

            // 開始計算兩兩城市間的距離
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distance[i, j] = Math.Abs ( position[i] - position[j] );
                }
            }

            // === 開始列印里程表 ================================

            // 開始表格
            lblRst.Text = "<table border=1>";

            // 列印標頭列(header)
            lblRst.Text += "<tr>";
            lblRst.Text += "<td>城市</td>";
            for (int i = 0; i < n; i++)
            {
                lblRst.Text += "<td>" + city[i] + "</td>";
            }
            lblRst.Text += "</tr>";

            // 列印里程
            for (int i = 0; i < n; i++)
            {
                lblRst.Text += "<tr>";

                // 城市名稱column
                lblRst.Text += "<td>" + city[i] + "</td>";

                // 里程column x7
                for (int j = 0; j < n; j++)
                {
                    lblRst.Text += "<td>";
                    lblRst.Text += distance[i, j].ToString();
                    lblRst.Text += "</td>";
                }
                lblRst.Text += "</tr>";
            }
            lblRst.Text += "</table>";


        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;

            // 城市名稱
            string[] city = new string[] { "台北", "桃園", "新竹", "台中", "嘉義", "台南", "高雄" };

            // 城市所在位置
            int[] position = new int[] { 25, 49, 95, 178, 264, 327, 373 };

            // n個城市
            int n = position.Length;

            // 宣告一個二維陣列儲存城市間的距離
            int[,] distance = new int[n, n];

            // 宣告一個二維陣列儲存兩兩城市之票價
            double[,] price = new double[n, n];

            // 開始計算兩兩城市間的距離及票價
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distance[i, j] = Math.Abs(position[i] - position[j]);
                    
                    if (distance[i, j] <= 50)
                        price[i, j] = distance[i, j] * 2.5;
                    else
                        if (distance[i, j] > 200)
                            price[i, j] = distance[i, j] * 2;
                        else
                            price[i, j] = distance[i, j] * 2.2;

                    price[i, j] = Math.Round(price[i, j], 0);
                }
            }

            // === 開始列印票價表 ================================

            // 開始表格
            lblRst.Text = "<table border=1>";

            // 列印標頭列(header)
            lblRst.Text += "<tr>";
            lblRst.Text += "<td>城市</td>";
            for (int i = 0; i < n; i++)
            {
                lblRst.Text += "<td>" + city[i] + "</td>";
            }
            lblRst.Text += "</tr>";

            // 列印票價
            for (int i = 0; i < n; i++)
            {
                lblRst.Text += "<tr>";

                // 城市名稱column
                lblRst.Text += "<td>" + city[i] + "</td>";

                // 里程column x7
                for (int j = 0; j < n; j++)
                {
                    lblRst.Text += "<td>";
                    lblRst.Text += price[i, j].ToString();
                    lblRst.Text += "</td>";
                }
                lblRst.Text += "</tr>";
            }
            lblRst.Text += "</table>";

        }

        protected void btnSale_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 城市名稱
            string[] city = new string[] { "台北", "桃園", "新竹", "台中", "嘉義", "台南", "高雄" };

            // 城市所在位置
            int[] position = new int[] { 25, 49, 95, 178, 264, 327, 373 };

            // n個城市
            int n = position.Length;

            // 宣告一個二維陣列儲存城市間的距離
            int[,] distance = new int[n, n];

            // 宣告一個二維陣列儲存兩兩城市之票價
            double[,] price = new double[n, n];

            //
            int start = ddlStart.SelectedIndex;
            int stop = ddlStop.SelectedIndex;

            // 開始計算兩兩城市間的距離及票價
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distance[i, j] = Math.Abs(position[i] - position[j]);

                    if (distance[i, j] <= 50)
                        price[i, j] = distance[i, j] * 2.5;
                    else
                        if (distance[i, j] > 200)
                            price[i, j] = distance[i, j] * 2;
                        else
                            price[i, j] = distance[i, j] * 2.2;

                    price[i, j] = Math.Round(price[i, j], 0);
                }
            }

            lblRst1.Text = "從" + ddlStart.SelectedItem.Text +
                            "到" + ddlStop.SelectedItem.Text +
                            "票價" + price[start, stop] + "元," +
                            "張數" + ddlNum.SelectedItem.Text + "張" +
                            "總價" + (price[start, stop] * Convert.ToInt16(ddlNum.SelectedItem.Text)) + "元";

        }





    }
}