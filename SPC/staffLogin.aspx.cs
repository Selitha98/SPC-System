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
    public partial class staffLogin : System.Web.UI.Page
    {
        SqlCommand cmdstaff = new SqlCommand();
        SqlConnection constaff = new SqlConnection();
        SqlDataAdapter sdastaff = new SqlDataAdapter();
        DataSet dsstaff = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("staffMain.aspx");
            }


            constaff.ConnectionString = (@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
            constaff.Open();

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string userstaff = staffuseremail.Text.Trim();
            string passstaff = staffuserpass.Text.Trim();
            int i = 0;
            cmdstaff.CommandText = "select * from staffDB where suserEmail='" + staffuseremail.Text + "' and suserPass='" + staffuserpass.Text + "'";
            cmdstaff.Connection = constaff;
            sdastaff.SelectCommand = cmdstaff;
            sdastaff.Fill(dsstaff, "staffDB");
            if (dsstaff.Tables[i].Rows.Count > 0)
            {
                if (passstaff == dsstaff.Tables[i].Rows[i]["suserPass"].ToString())
                {
                    Session["staffMain"] = userstaff;
                    Response.Redirect("staffMain.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Password does not match.!');", true);
                }
            }
        }
    }
}