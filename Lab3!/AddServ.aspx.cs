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
    public partial class AddServ : System.Web.UI.Page

    {
        //button click methods, most buttons do not get used for this lab
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFirstName.Text = (string)Session["FName"];
                txtLastName.Text = (string)Session["LName"];
                txtCustID1.Text = (string)Session["ID"];
            }
        }



        protected void btnClearServ_Click(object sender, EventArgs e)
        {
            ClearAllText(Page);
        }

        //clear all textboxes method
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


        //method to populate the service fields
        protected void btnPopulateServ_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ServID = rnd.Next(100000, 1000000);

            Random rnd2 = new Random();
            int ServTicketID = rnd2.Next(10000, 100000);

            txtServType1.Text = "Moving";
            txtFirstName.Text = "Joe";
            txtLastName.Text = "Johnson";
            txtCustID1.Text = "371837294";
            txtMoveTime1.Text = "2";
            txtFoodCost1.Text = "20";
            txtDate1.Text = "11/05/2020";
            txtFuelCost1.Text = "120";
            txtEstCost1.Text = "1000";
            txtLodgeCost1.Text = "0";
            txtCompDate1.Text = "11/06/2020";
            txtEquip1.Text = "truck, forklift";
            txtVehicleUsed1.Text = "truck 4";
            txtDestinationAddress1.Text = "213 State Dr";
            txtDestinationCity1.Text = "Harrisonburg";
            txtDestinationState1.Text = "VA";
            txtDestinationZip1.Text = "22801";
            txtServiceID1.Text = "920213";
            txtHeader.Text = "Move Date Change";
            txtNote.Text = "The Move Date may change to 11/06/2020, customer will contact";
            txtServiceID1.Text = ServID.ToString();
            txtTicketID.Text = ServTicketID.ToString();
            txtStatus.Text = "Open";
            txtEmployeeID.Text = "481947219";

        }

        //add service to db
        protected void btnCommitServ_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();


            String query = "INSERT INTO Service VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtCustID1.Text
               + "','" + txtServType1.Text + "','" + txtDate1.Text + "','" + txtEstCost1.Text + "','" + txtCompDate1.Text + "','" + txtVehicleUsed1.Text
               + "','" + txtServiceID1.Text + "','" + txtMoveTime1.Text + "','" + txtFoodCost1.Text + "','" + txtFuelCost1.Text
               + "','" + txtLodgeCost1.Text + "','" + txtEquip1.Text + "','" + txtDestinationAddress1.Text + "','" + txtDestinationCity1.Text + "','" + txtDestinationState1.Text
               + "','" + txtDestinationZip1.Text + "','" + txtHeader.Text + "','" + txtNote.Text + "')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnGenerateServID_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ServID = rnd.Next(100000, 1000000);

            txtServiceID1.Text = ServID.ToString();

            Random rnd2 = new Random();
            int ServTicketID = rnd2.Next(10000, 100000);

            txtTicketID.Text = ServTicketID.ToString();

        }

        protected void btnCreateServTicket_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
                con.Open();


                String query = "INSERT INTO ServiceTicket VALUES ('" + txtTicketID.Text + "','" + txtStatus.Text + "','" + txtCustID1.Text
                   + "','" + txtServiceID1.Text + "','" + txtEmployeeID.Text + "')";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

