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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=SELITHA;Initial Catalog=spc;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            viewMedicine();
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

        //Select From Table Medicine
        int Keymed = 0;
        protected void medicineGDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicineName.Value = medicineGDV.SelectedRow.Cells[2].Text;
            medicineCategory.Value = medicineGDV.SelectedRow.Cells[3].Text;
            quantity.Text = medicineGDV.SelectedRow.Cells[4].Text;
            wholesaleprice.Text = medicineGDV.SelectedRow.Cells[5].Text;
           

            if (medicineName.Value == "")
            {
                Keymed = 0;
            }
            else
            {
                Keymed = Convert.ToInt32(medicineName.Value = medicineGDV.SelectedRow.Cells[1].Text);
            }
        }

         

        private void Calculate()
        {
            totalprice.Text = (float.Parse(quantity.Text) * float.Parse(wholesaleprice.Text)).ToString();
        }

        protected void Cal_Click(object sender, EventArgs e)
        {
            Calculate();
        }


        //Insert Medicine
        private void InsertOrder()
        {
            if (medicineName.Value == "" || medicineCategory.Value == "" || quantity.Text == "" || wholesaleprice.Text == "" || totalprice.Text == "" )
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Missing Informations..!');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdord = new SqlCommand("insert into orderDB(ordermedName,ordermedCat,ordermedQuan,ordermedWhole,orderTotal) values(@oN,@oC,@oQ,@oW,@oT)", con);
                    cmdord.Parameters.AddWithValue("@oN", medicineName.Value);
                    cmdord.Parameters.AddWithValue("@oC", medicineCategory.Value);
                    cmdord.Parameters.AddWithValue("@oQ", quantity.Text);
                    cmdord.Parameters.AddWithValue("@oW", wholesaleprice.Text);
                    cmdord.Parameters.AddWithValue("@oT", totalprice.Text);

                    cmdord.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Oreder Added Successfully');", true);
                    con.Close();
                    viewMedicine();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void Place_Click(object sender, EventArgs e)
        {
            InsertOrder();
        }
    }
}