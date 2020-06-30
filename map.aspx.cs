using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.IO;

namespace WebApplication1
{
    public partial class map : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAddress.Text = "台中市西屯區工業區一路82-22號";
        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            

            double lng = 120.577063;
            double lat = 24.226859;
            string msg = "讚";

            ClientScript.RegisterStartupScript(this.GetType(), "key1", "<script>ShowMyMap(" + lat + "," + lng + ",'" + msg + "')</script>", false);
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            var url = String.Format("http://maps.google.com/maps/api/geocode/json?sensor=false&address={0}", txtAddress.Text);

            string result = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (var response = request.GetResponse())
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                //Json格式: 請參考http://code.google.com/intl/zh-TW/apis/maps/documentation/geocoding/
                result = sr.ReadToEnd();
            }
            lblRst.Text = result;
        }
    }
}