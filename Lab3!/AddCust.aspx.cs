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
    public partial class AddCust : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();

        }

        //Button Click Events

        protected void btnSearch_Click(object sender, EventArgs e)
        { }

        //populate customer fields
        protected void btnPopulateCust_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Joe";
            txtLastName.Text = "Johnson";
            txtPhoneNo.Text = "7165621253";
            txtEmail.Text = "johnsonj@gmail.com";
            txtAddress.Text = "123 Harlem Rd";
            txtCity.Text = "Buffalo";
            txtState.Text = "NY";
            txtZip.Text = "14222";
            txtCustomerID.Text = "371837294";
            ddlContact.SelectedValue = "Other";
            txtOther.Text = "Employee is a Friend";
            txtHearAbout.Text = "A friend";
            txtMovingAddress.Text = "432 South Main St";
            txtMovingCity.Text = "Harrisonburg";
            txtMovingState.Text = "VA";
            txtMovingZip.Text = "22801";
            txtDeadline.Text = "12/10/2020";
            txtTime.Text = "4:00 pm";
            txtDeadline2.Text = "12/15/2020";
            txtTime2.Text = "4:00 pm";





        }


        //save customer to DB
        protected void btnCommitAddCust_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
                con.Open();
                

                    String query = "INSERT INTO Customer (CustFirstName,CustLastName,PhoneType, PhoneNumber,Email,CustAddress," +
                        "CustCity,CustState,CustZip,CustomerID,InitialContact,HearAbout,InterestedService,MoveAddress,MoveCity,MoveState,MoveZip,DateTimeInitial,Deadline,Time1,Deadline2,Time2) " +
                        "VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + rdoPhoneType.SelectedValue + "','" + txtPhoneNo.Text
                       + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtZip.Text
                       +  "','" + txtCustomerID.Text + "','" + ddlContact.SelectedItem.Text + "','" + txtHearAbout.Text + "','" + rdobtnServ.SelectedValue + "','" + txtMovingAddress.Text + "'," +
                       "'" + txtMovingCity.Text + "','" + txtMovingState.Text + "','" + txtMovingZip.Text + "','" + txtDateTime.Text + "','" + txtDeadline.Text + "','" + txtTime.Text + "','" + txtDeadline2.Text + "','" + txtTime2.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();                    
            
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


        protected void btnGenerateCustomerID_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ServID = rnd.Next(100000000, 1000000000);

            txtCustomerID.Text = ServID.ToString();
        }

        protected void btnAddServForCust_Click(object sender, EventArgs e)
        {
            Session["FName"] = txtFirstName.Text;
            Session["LName"] = txtLastName.Text;
            Session["ID"] = txtCustomerID.Text;
            Response.Redirect("AddServ.aspx");
        }

        protected void ddlContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContact.SelectedValue == "Other")
            {
                txtOther.Enabled = true;

            }
            else
            {
                txtOther.Enabled = false;
            }
        }



        protected void rdobtnServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdobtnServ.SelectedValue == "Auction")
            {
                txtMovingAddress.Enabled = false;
                txtMovingCity.Enabled = false;
                txtMovingState.Enabled = false;
                txtMovingZip.Enabled = false;
            }
            else if (rdobtnServ.SelectedValue == "Moving")
            {
                txtMovingAddress.Enabled = true;
                txtMovingCity.Enabled = true;
                txtMovingState.Enabled = true;
                txtMovingZip.Enabled = true;
            }
        }

    }
}