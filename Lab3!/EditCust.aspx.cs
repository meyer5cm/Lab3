using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace Lab2
{
    public partial class EditCust : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button Click Events
    

        //populate customer fields
        protected void btnPopulateCust_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Erica";
            txtLastName.Text = "Swan";
            txtPhoneNo.Text = "1763211284";
            txtEmail.Text = "swannie@gmail.com";
            txtAddress.Text = "438 Harlem Rd";
            txtCity.Text = "Cheektowaga";
            txtState.Text = "NY";
            txtZip.Text = "14222";
            txtCustomerID.Text = "117232524";

        }

       
        //clear all data fields
        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(Page);
        }


        //clear all text method to be called
        protected void ClearAllText(Control p1)
        {
            foreach (Control ClearText in p1.Controls)
            {
                if (ClearText is TextBox)
                {
                    TextBox t = ClearText as TextBox;

                    if (t != null)
                    {
                        t.Text = String.Empty;
                    }
                }
                else
                {
                    if (ClearText.Controls.Count > 0)
                    {
                        ClearAllText(ClearText);
                    }
                }
            }
        }

        //update customer in Db
        protected void btnUpdateCust_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET CustFirstName = '" + txtFirstName.Text + "', CustLastName ='" + txtLastName.Text +
                "', PhoneNumber = '" + txtPhoneNo.Text + "', Email= '" + txtEmail.Text + "', CustAddress= '" + txtAddress.Text + "', CustCity = '" + txtCity.Text +
                "' , CustState ='" + txtState.Text + "',CustZip = '" + txtZip.Text + "', CustomerID ='" + txtCustomerID.Text + "' WHERE CustomerID = @CustomerID",con);

            cmd.Parameters.AddWithValue("CustomerID", txtCustomerID.Text); 

            cmd.ExecuteNonQuery();
            con.Close();
        }
        //drop down list of current customers
        protected void CustDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustFirstName,CustLastName,PhoneNumber,Email,CustAddress,CustCity,CustState,CustZip,CustomerID FROM Customer WHERE CustomerID = @ln", con);

            cmd.Parameters.AddWithValue("@ln", DropDownList1.SelectedValue);

            SqlDataReader myReader3 = cmd.ExecuteReader();
            if (myReader3.HasRows)
            {
                while (myReader3.Read())
                {
                    txtFirstName.Text = Convert.ToString(myReader3[0]);
                    txtLastName.Text = Convert.ToString(myReader3[1]);
                    txtPhoneNo.Text = Convert.ToString(myReader3[2]);
                    txtEmail.Text = Convert.ToString(myReader3[3]);
                    txtAddress.Text = Convert.ToString(myReader3[4]);
                    txtCity.Text = Convert.ToString(myReader3[5]);
                    txtState.Text = Convert.ToString(myReader3[6]);
                    txtZip.Text = Convert.ToString(myReader3[7]);
                    txtCustomerID.Text = Convert.ToString(myReader3[8]);
                }
                myReader3.Close();
            }
            con.Close();
        }
                //view all customers in a grid view
                protected void btnViewAll_Click(object sender, EventArgs e)
        {
            grdvwCustDisplay.DataSource = null;
            grdvwCustDisplay.DataBind();

            String sqlQuery = "SELECT CustFirstName, CustLastName, Customer.CustomerID, Service.ServiceID, Service.ServiceDate FROM Customer INNER JOIN Service On Customer.CustomerID = Service.CustomerID ORDER BY CustLastName";


            SqlConnection sqlConnect = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery, sqlConnect);
            DataTable dtCustomerGridView = new DataTable();
            sqlAdapter.Fill(dtCustomerGridView);
            grdvwCustDisplay.DataSource = dtCustomerGridView;
            grdvwCustDisplay.DataBind();
        }



    }
}
