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
    public partial class delete : System.Web.UI.Page
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
            objCmd.CommandText = "delete from [台中市景點資料] " +
                                    " where [景點ID] = " + txt景點ID.Text;

            int cnt = objCmd.ExecuteNonQuery();

            lblRst.Text = "共刪除了" + cnt.ToString() + "筆資料.";

            txt景點ID.Text = "";
            txt名稱.Text = "";
            txt鄉鎮市區.Text = "";
            txt地址.Text = "";
            txt景點ID.Focus();

            objCon.Close();

            objCon.Dispose();
            objCmd.Dispose();



        }

        protected void btnQry_Click(object sender, EventArgs e)
        {

            try
            {

            string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("app_data\\db.mdb");

            OleDbConnection objCon = new OleDbConnection();
            objCon.ConnectionString = constr;
            objCon.Open();

            OleDbCommand objCmd = new OleDbCommand();
            objCmd.Connection = objCon;
            objCmd.CommandText = "select [景點ID], [名稱], [地址], [鄉鎮市區] from [台中市景點資料] " +
                                    " where [景點ID] = " + txt景點ID.Text;

            OleDbDataReader objDr = objCmd.ExecuteReader();

            lblRst.Text = "";

            if (objDr.HasRows)
            {
                if(objDr.Read())
                {
                    txt名稱.Text = objDr["名稱"].ToString();
                    txt鄉鎮市區.Text = objDr["鄉鎮市區"].ToString();
                    txt地址.Text = objDr["地址"].ToString();
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
            catch (Exception ex)
            {
                lblRst.Text = ex.Message;

            }


        }
    }
}