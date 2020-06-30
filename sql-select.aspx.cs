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
    public partial class sql_select : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                txtSQL.Text = "select 名稱 from 台中市景點資料 where 鄉鎮市區='西屯區'";
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                lblRst.Text = "";

                OleDbConnection objCon = new OleDbConnection();

                objCon.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Server.MapPath("app_data\\db.mdb");
                objCon.Open();

                OleDbCommand objCmd = new OleDbCommand();

                objCmd.CommandText = txtSQL.Text;
                objCmd.Connection = objCon;

                OleDbDataReader objDr = objCmd.ExecuteReader();
                GridView1.AllowPaging = false;
                GridView1.DataSource = objDr;
                GridView1.DataBind();

                objCon.Close();
                objCon.Dispose();

            }
            catch (Exception ex)
            {
                lblRst.Text = ex.Message;
            }




        }

       
    }
}