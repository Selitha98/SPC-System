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
    

    public partial class staffMain : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            viewMedicine();
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
    }
}