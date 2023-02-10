using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SPC
{
    public partial class pharmacyLogin : System.Web.UI.Page
    {

        SqlCommand cmdpharma = new SqlCommand();
        SqlConnection conpharma = new SqlConnection();
        SqlDataAdapter sdapharma = new SqlDataAdapter();
        DataSet dspharma = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("pharmacyMain.aspx");
            }


            conpharma.ConnectionString = (@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
            conpharma.Open();
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string userpharma = pharmauseremail.Text.Trim();
            string passpharma = pharmauserpass.Text.Trim();
            int i = 0;
            cmdpharma.CommandText = "select * from pharmacyDB where pharmacyEmail='" + pharmauseremail.Text + "' and pharmacyPass='" + pharmauserpass.Text + "'";
            cmdpharma.Connection = conpharma;
            sdapharma.SelectCommand = cmdpharma;
            sdapharma.Fill(dspharma, "pharmacyDB");
            if (dspharma.Tables[i].Rows.Count > 0)
            {
                if (userpharma == dspharma.Tables[i].Rows[i]["pharmacyPass"].ToString())
                {
                    Session["pharmacyMain"] = userpharma;
                    Response.Redirect("pharmacyMain.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Password does not match.!');", true);
                }
            }
        }
    }
}