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
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            try
            {


                string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("app_data\\db.mdb");

                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = constr;
                objCon.Open();

                OleDbCommand objCmd = new OleDbCommand();
                objCmd.Connection = objCon;
                objCmd.CommandText = "insert into [台中市景點資料] ( [景點ID], [名稱], [地址], [鄉鎮市區] ) values  " +
                                        " ( " + txt景點ID.Text + ",'" + txt名稱.Text + "','" + txt地址.Text + "','" + txt鄉鎮市區.Text + "')";

                int cnt = objCmd.ExecuteNonQuery();

                lblRst.Text = "";

                if (cnt > 0)
                {
                    lblRst.Text += "已儲存" + cnt.ToString() + "筆資料.<br>";
                }
                else
                {
                    lblRst.Text = "未能儲存資料.";
                }

                objCon.Close();

                objCon.Dispose();
                objCmd.Dispose();


            }
            catch (Exception ex)
            {
                lblRst.Text = ex.Message;

            }

        }
    }
}