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

    public partial class Login : System.Web.UI.Page
    {

        SqlCommand cmdadmn = new SqlCommand();
        SqlConnection conadmn = new SqlConnection();
        SqlDataAdapter sdaadmin = new SqlDataAdapter();
        DataSet dsadmn = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["user"] != null)
            {
                Response.Redirect("adminMain.aspx");
            }


            conadmn.ConnectionString = (@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
            conadmn.Open();
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string user = useradmin.Text.Trim();
            string pass = userpass.Text.Trim();
            int i = 0;
            cmdadmn.CommandText = "select * from adminDB where adminEmail='"+ useradmin.Text+"' and adminPass='"+userpass.Text+"'";
            cmdadmn.Connection = conadmn;
            sdaadmin.SelectCommand = cmdadmn;
            sdaadmin.Fill(dsadmn, "adminDB");
            if(dsadmn.Tables[i].Rows.Count > 0)
            {
                if (pass == dsadmn.Tables[i].Rows[i]["adminPass"].ToString())
                {
                    
                    Session["adminMain"] = user;
                    Response.Redirect("adminMain.aspx");
                    Response.Write("<script>alert('Admin Login Successfully.!');</script>");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Password does not match.!');", true);
                }
            }
        }

    }

    }
