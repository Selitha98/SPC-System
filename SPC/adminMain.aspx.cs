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
    public partial class adminMain : System.Web.UI.Page
    {


        


        SqlConnection con = new SqlConnection(@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
        
        //View Staff
        private void viewStaff()
        {
            con.Open();
            string Query = "select * from staffDB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            staffGDV.DataSource = ds.Tables[0];
            staffGDV.DataBind();
            con.Close();
        }

        //Delete Staff
        private void deleteStaff()
        {
            if (straffuserName.Value == "" || straffuserID.Value == "" || straffuserPhone.Value == "" || straffuserEmail.Value == "" || straffuserPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Select The User To Be Deleted.!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from staffDB where suserID=@sID", con);
                  
                    cmd.Parameters.AddWithValue("@sID", staffGDV.SelectedRow.Cells[1].Text);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Staff User Deleted Successfully');", true);
                    con.Close();
                    viewStaff();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Update Staff

        private void EditStaff()
        {
            if (straffuserName.Value == "" || straffuserID.Value == "" || straffuserPhone.Value == "" || straffuserEmail.Value == "" || straffuserPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update staffDB set suserName=@sN,suserNIC=@sNIC,suserPhone=@sP,suserEmail=@sE,suserPass=@sPA where suserID=@sID", con);
                    cmd.Parameters.AddWithValue("@sN", straffuserName.Value);
                    cmd.Parameters.AddWithValue("@sNIC", straffuserID.Value);
                    cmd.Parameters.AddWithValue("@sP", straffuserPhone.Value);
                    cmd.Parameters.AddWithValue("@sE", straffuserEmail.Value);
                    cmd.Parameters.AddWithValue("@sPA", straffuserPassword.Value);
                    cmd.Parameters.AddWithValue("@sID", staffGDV.SelectedRow.Cells[1].Text);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Staff User Updated Successfully');", true);
                    con.Close();
                    viewStaff();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Insert Staff
        private void InsertStaff ()
        {
            if(straffuserName.Value == ""|| straffuserID.Value == ""|| straffuserPhone.Value == "" || straffuserEmail.Value == "" || straffuserPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations..!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into staffDB(suserName,suserNIC,suserPhone,suserEmail,suserPass) values(@sN,@sNIC,@sP,@sE,@sPA)", con);
                    cmd.Parameters.AddWithValue("@sN", straffuserName.Value);
                    cmd.Parameters.AddWithValue("@sNIC", straffuserID.Value);
                    cmd.Parameters.AddWithValue("@sP", straffuserPhone.Value);
                    cmd.Parameters.AddWithValue("@sE", straffuserEmail.Value);
                    cmd.Parameters.AddWithValue("@sPA", straffuserPassword.Value);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Staff User Added Successfully');", true);
                    con.Close();
                    viewStaff();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            viewStaff();
            viewPharmacy();
            viewMedicine();
        }

        protected void Addstaff_Click(object sender, EventArgs e)
        {
            InsertStaff();
        }

        //Select From Table Staff
        int Key = 0;
        protected void staffGDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            straffuserName.Value = staffGDV.SelectedRow.Cells[2].Text;
            straffuserID.Value = staffGDV.SelectedRow.Cells[3].Text;
            straffuserPhone.Value = staffGDV.SelectedRow.Cells[4].Text;
            straffuserEmail.Value = staffGDV.SelectedRow.Cells[5].Text;
            straffuserPassword.Value = staffGDV.SelectedRow.Cells[6].Text;

            if(straffuserName.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(straffuserName.Value = staffGDV.SelectedRow.Cells[1].Text);
            }
        }

        
        protected void Editstaff_Click(object sender, EventArgs e)
        {
            EditStaff();
        }

        protected void Deletestaff_Click(object sender, EventArgs e)
        {
            deleteStaff();
        }


        //View Pharmacy
        private void viewPharmacy()
        {
            con.Open();
            string QueryPh = "select * from pharmacyDB";
            SqlDataAdapter sdaph = new SqlDataAdapter(QueryPh, con);
            SqlCommandBuilder BuilderPh = new SqlCommandBuilder(sdaph);
            var dsph = new DataSet();
            sdaph.Fill(dsph);
            pharmacyGDV.DataSource = dsph.Tables[0];
            pharmacyGDV.DataBind();
            con.Close();
        }

        //Delete Pharmacy
        private void deletePharmacy()
        {
            if (pharmacyName.Value == "" || pharmacyCity.Value == "" || pharmacyPhone.Value == "" || pharmacyEmail.Value == "" || pharmacyPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Select The Pharmacy To Be Deleted.!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdph = new SqlCommand("delete from pharmacyDB where pharmacyID=@pID", con);

                    cmdph.Parameters.AddWithValue("@pID", pharmacyGDV.SelectedRow.Cells[1].Text);
                    cmdph.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Pharmacy Deleted Successfully');", true);
                    con.Close();
                    viewPharmacy();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        //Update Pharmacy

        private void EditPharmacy()
        {
            if (pharmacyName.Value == "" || pharmacyCity.Value == "" || pharmacyPhone.Value == "" || pharmacyEmail.Value == "" || pharmacyPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdph = new SqlCommand("update pharmacyDB set pharmacyName=@pN,pharmacyCity=@pC,pharmacyPhone=@pP,pharmacyEmail=@pE,pharmacyPass=@pPA where pharmacyID=@pID", con);
                    cmdph.Parameters.AddWithValue("@pN", pharmacyName.Value);
                    cmdph.Parameters.AddWithValue("@pC", pharmacyCity.Value);
                    cmdph.Parameters.AddWithValue("@pP", pharmacyPhone.Value);
                    cmdph.Parameters.AddWithValue("@pE", pharmacyEmail.Value);
                    cmdph.Parameters.AddWithValue("@pPA", pharmacyPassword.Value);
                    cmdph.Parameters.AddWithValue("@pID", pharmacyGDV.SelectedRow.Cells[1].Text);
                    cmdph.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Pharmacy Updated Successfully');", true);
                    con.Close();
                    viewPharmacy();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //Insert Pharmacy
        private void InsertPharma()
        {
            if (pharmacyName.Value == "" || pharmacyCity.Value == "" || pharmacyPhone.Value == "" || pharmacyEmail.Value == "" || pharmacyPassword.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations..!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdph = new SqlCommand("insert into pharmacyDB(pharmacyName,pharmacyCity,pharmacyPhone,pharmacyEmail,pharmacyPass) values(@pN,@pC,@pP,@pE,@pPA)", con);
                    cmdph.Parameters.AddWithValue("@pN", pharmacyName.Value);
                    cmdph.Parameters.AddWithValue("@pC", pharmacyCity.Value);
                    cmdph.Parameters.AddWithValue("@pP", pharmacyPhone.Value);
                    cmdph.Parameters.AddWithValue("@pE", pharmacyEmail.Value);
                    cmdph.Parameters.AddWithValue("@pPA", pharmacyPassword.Value);
                    cmdph.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Pharmacy Added Successfully');", true);
                    con.Close();
                    viewPharmacy();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        //Select From Table Pharmacy
        int Keyph = 0;
        protected void pharmacyGDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            pharmacyName.Value = pharmacyGDV.SelectedRow.Cells[2].Text;
            pharmacyCity.Value = pharmacyGDV.SelectedRow.Cells[3].Text;
            pharmacyPhone.Value = pharmacyGDV.SelectedRow.Cells[4].Text;
            pharmacyEmail.Value = pharmacyGDV.SelectedRow.Cells[5].Text;
            pharmacyPassword.Value = pharmacyGDV.SelectedRow.Cells[6].Text;

            if (pharmacyName.Value == "")
            {
                Keyph = 0;
            }
            else
            {
                Keyph = Convert.ToInt32(pharmacyName.Value = pharmacyGDV.SelectedRow.Cells[1].Text);
            }
        }

        protected void Addpharma_Click(object sender, EventArgs e)
        {
            InsertPharma();
        }

        protected void Editpharma_Click(object sender, EventArgs e)
        {
            EditPharmacy();
        }

        protected void Deletepharma_Click(object sender, EventArgs e)
        {
            deletePharmacy();
        }

        

        //Delete Stock
        private void deleteStock()
        {
            if (medicineName.Value == "" || medicineCategory.Value == "" || quantity.Value == "" || wholesaleprice.Value == "" || retailprice.Value == "" || manufacturer.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Select The Stock To Be Deleted.!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdmed = new SqlCommand("delete from stockDB where medicineID=@mID", con);

                    cmdmed.Parameters.AddWithValue("@mID", medicineGDV.SelectedRow.Cells[1].Text);
                    cmdmed.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Stock Deleted Successfully');", true);
                    con.Close();
                    viewMedicine();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //View Stock
        private void viewMedicine()
        {
            con.Open();
            string QueryMed = "select * from stockDB";
            SqlDataAdapter sdamed = new SqlDataAdapter(QueryMed, con);
            SqlCommandBuilder BuilderMed = new SqlCommandBuilder(sdamed);
            var dsmed = new DataSet();
            sdamed.Fill(dsmed);
            medicineGDV.DataSource = dsmed.Tables[0];
            medicineGDV.DataBind();
            con.Close();
        }

        //Update Stock

        private void EditMedicine()
        {
            if (medicineName.Value == "" || medicineCategory.Value == "" || quantity.Value == "" || wholesaleprice.Value == "" || retailprice.Value == "" || manufacturer.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdmed = new SqlCommand("update StockDB set medicineName=@mN,medicineCategory=@mC,medicineQuantity=@mQ,medicineWprice=@mW,medicineRprice=@mR,medicineManu=@mM where medicineID=@mID", con);
                    cmdmed.Parameters.AddWithValue("@mN", medicineName.Value);
                    cmdmed.Parameters.AddWithValue("@mC", medicineCategory.Value);
                    cmdmed.Parameters.AddWithValue("@mQ", quantity.Value);
                    cmdmed.Parameters.AddWithValue("@mW", wholesaleprice.Value);
                    cmdmed.Parameters.AddWithValue("@mR", retailprice.Value);
                    cmdmed.Parameters.AddWithValue("@mM", manufacturer.Value);
                    cmdmed.Parameters.AddWithValue("@mID", medicineGDV.SelectedRow.Cells[1].Text);
                    cmdmed.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Stock Updated Successfully');", true);
                    con.Close();
                    viewMedicine();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        //Insert Medicine
        private void InsertMedicine()
        {
            if (medicineName.Value == "" || medicineCategory.Value == "" || quantity.Value == "" || wholesaleprice.Value == "" || retailprice.Value == "" || manufacturer.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations..!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdmed = new SqlCommand("insert into stockDB(medicineName,medicineCategory,medicineQuantity,medicineWprice,medicineRprice,medicineManu) values(@mN,@mC,@mQ,@mW,@mR,@mM)", con);
                    cmdmed.Parameters.AddWithValue("@mN", medicineName.Value);
                    cmdmed.Parameters.AddWithValue("@mC", medicineCategory.Value);
                    cmdmed.Parameters.AddWithValue("@mQ", quantity.Value);
                    cmdmed.Parameters.AddWithValue("@mW", wholesaleprice.Value);
                    cmdmed.Parameters.AddWithValue("@mR", retailprice.Value);
                    cmdmed.Parameters.AddWithValue("@mM", manufacturer.Value);
                    cmdmed.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Medicine Added Successfully');", true);
                    con.Close();
                    viewMedicine();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Select From Table Medicine
        int Keymed = 0;
        protected void medicineGDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicineName.Value = medicineGDV.SelectedRow.Cells[2].Text;
            medicineCategory.Value = medicineGDV.SelectedRow.Cells[3].Text;
            quantity.Value = medicineGDV.SelectedRow.Cells[4].Text;
            wholesaleprice.Value = medicineGDV.SelectedRow.Cells[5].Text;
            retailprice.Value = medicineGDV.SelectedRow.Cells[6].Text;
            manufacturer.Value = medicineGDV.SelectedRow.Cells[7].Text;

            if (medicineName.Value == "")
            {
                Keymed = 0;
            }
            else
            {
                Keymed = Convert.ToInt32(medicineName.Value = medicineGDV.SelectedRow.Cells[1].Text);
            }
        }

        protected void Addmed_Click(object sender, EventArgs e)
        {
            InsertMedicine();
        }

        protected void Editmed_Click(object sender, EventArgs e)
        {
            EditMedicine();
        }

        protected void Deletemed_Click(object sender, EventArgs e)
        {
            deleteStock();
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}