using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;


namespace WebApplication1
{
    public partial class select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("app_data\\db.mdb");

            OleDbConnection objCon = new OleDbConnection();
            objCon.ConnectionString = constr;
            objCon.Open();

            OleDbCommand objCmd = new OleDbCommand();
            objCmd.Connection = objCon;
            objCmd.CommandText = "select [景點ID], [名稱], [地址], [鄉鎮市區] from [台中市景點資料] " + 
                                    " where [名稱] like '%" + txtKeyword.Text + "%' order by [景點ID]";

            OleDbDataReader objDr = objCmd.ExecuteReader();

            lblRst.Text = "";

            if (objDr.HasRows)
            {
                while (objDr.Read())
                {
                    lblRst.Text += objDr["名稱"].ToString() + "<br>";
                }
            }
            else
            {
                lblRst.Text = "找不到資料.";
            }

            objDr.Close();
            objCon.Close();

            objCon.Dispose();
            objCmd.Dispose();
            objDr.Dispose();





        }
    }
}