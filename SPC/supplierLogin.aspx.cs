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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmdsup = new SqlCommand();
        SqlDataAdapter sdasup = new SqlDataAdapter();
        SqlConnection consup = new SqlConnection();
        DataSet dssup = new DataSet();


        SqlConnection con = new SqlConnection(@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("adminMain.aspx");
            }


            consup.ConnectionString = (@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
            consup.Open();

        }


        //Insert Staff
        //private void InsertSupplier()
        //{
        //    if (supname.Value == "" || supemail.Value == "" || supphone.Value == "" || supcompany.Value == "" || suppass.Value == "")
        //    {
        //        ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations..!');", true);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            con.Open();
        //            SqlCommand cmdsup = new SqlCommand("insert into supDB(supplierName,supplierEmail,supplierPhone,supplierCompany,supplierPass) values(@ssN,@ssE,@ssP,@ssC,@ssPA)", con);
        //            cmdsup.Parameters.AddWithValue("@ssN", supname.Value);
        //            cmdsup.Parameters.AddWithValue("@ssE", supemail.Value);
        //            cmdsup.Parameters.AddWithValue("@ssP", supphone.Value);
        //            cmdsup.Parameters.AddWithValue("@ssC", supcompany.Value);
        //            cmdsup.Parameters.AddWithValue("@ssPA", suppass.Value);
        //            cmdsup.ExecuteNonQuery();
        //            ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Supplier Register Successfully');", true);
        //            con.Close();
                   
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //}

        //protected void rgstrbtn_Click(object sender, EventArgs e)
        //{
        //    InsertSupplier();
        //}

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string supuser = supuseremail.Text.Trim();
            string suppass = supuserpass.Text.Trim();
            int i = 0;
            cmdsup.CommandText = "select * from supDB where suppplierEmail='" + supuseremail.Text + "' and supplierPass='" + supuserpass.Text + "'";
            cmdsup.Connection = consup;
            sdasup.SelectCommand = cmdsup;
            sdasup.Fill(dssup, "supDB");
            if (dssup.Tables[i].Rows.Count > 0)
            {
                if (suppass == dssup.Tables[i].Rows[i]["supplierPass"].ToString())
                {
                    Session["supplierMain"] = supuser;
                    Response.Redirect("supplierMain.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Password does not match.!');", true);
                }
            }
        }
    }
}