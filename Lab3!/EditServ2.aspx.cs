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
    public partial class EditServ2 : System.Web.UI.Page
    {
        //button click methods, most buttons do not get used for this lab
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
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
        //update service in db
        protected void btnUpdateServ_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);


            con.Open();

            String query2 = "UPDATE Service SET CustomerFirstName = '" + txtFirstName.Text + "', CustomerLastName ='" + txtLastName.Text +
                "', CustomerID = '" + txtCustID1.Text + "', ServiceType= '" + txtServType1.Text + "', ServiceDate = '" + txtDate1.Text + "', EstimatedCost = '" + txtEstCost1.Text +
                "' , CompletionDate ='" + txtCompDate1.Text + "', VehicleUsed = '" + txtVehicleUsed1.Text + "', ServiceID = '" + txtServiceID1.Text + "', MoveTime ='" + txtMoveTime1.Text +
                "', FoodCost = '" + txtFoodCost1.Text + "', FuelCost = '" + txtFuelCost1.Text + "', LodgingCost = '" + txtLodgeCost1.Text + "', EquipmentNeeded = '" + txtEquip1.Text +
                "', DestinationAddress = '" + txtDestinationAddress1.Text + "', DestinationCity = '" + txtDestinationCity1.Text + "', DestinationState = '" + txtDestinationState1.Text + "', DestinationZip = '" + txtDestinationZip1.Text +
                "', NoteHeader = '" + txtHeader.Text + "', Note = '" + txtNote.Text +
                 "' WHERE ServiceID = @ServiceID";
            SqlCommand cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("ServiceID", txtServiceID1.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        }


        protected void ddlService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CustomerFirstName, CustomerLastName, CustomerID, ServiceType, ServiceDate," +
                "EstimatedCost, CompletionDate, VehicleUsed, ServiceID, MoveTime, FoodCost, FuelCost, LodgingCost," +
                "EquipmentNeeded, DestinationAddress, DestinationCity, DestinationState, DestinationZip, NoteHeader, Note FROM Service WHERE CustomerID  = @CustomerID", con);


            cmd.Parameters.AddWithValue("CustomerID", ddlService.SelectedValue);

            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    txtFirstName.Text = Convert.ToString(myReader[0]);
                    txtLastName.Text = Convert.ToString(myReader[1]);
                    txtCustID1.Text = Convert.ToString(myReader[2]);
                    txtServType1.Text = Convert.ToString(myReader[3]);
                    txtDate1.Text = Convert.ToString(myReader[4]);
                    txtEstCost1.Text = Convert.ToString(myReader[5]);
                    txtCompDate1.Text = Convert.ToString(myReader[6]);
                    txtVehicleUsed1.Text = Convert.ToString(myReader[7]);
                    txtServiceID1.Text = Convert.ToString(myReader[8]);
                    txtMoveTime1.Text = Convert.ToString(myReader[9]);
                    txtFoodCost1.Text = Convert.ToString(myReader[10]);
                    txtFuelCost1.Text = Convert.ToString(myReader[11]);
                    txtLodgeCost1.Text = Convert.ToString(myReader[12]);
                    txtEquip1.Text = Convert.ToString(myReader[13]);
                    txtDestinationAddress1.Text = Convert.ToString(myReader[14]);
                    txtDestinationCity1.Text = Convert.ToString(myReader[15]);
                    txtDestinationState1.Text = Convert.ToString(myReader[16]);
                    txtDestinationZip1.Text = Convert.ToString(myReader[17]);
                    txtHeader.Text = Convert.ToString(myReader[18]);
                    txtNote.Text = Convert.ToString(myReader[19]);


                }
                myReader.Close();
            }
            con.Close();

        }

        protected void btnViewTicket_Click(object sender, EventArgs e)
        {
            txtYourEmployeeID.Text = "710418422";


            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();


            grdvwTicketDisplay.DataSource = null;
            grdvwTicketDisplay.DataBind();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ServiceTicket WHERE ServiceID = @ServiceID",con);

            cmd.Parameters.AddWithValue("ServiceID", txtServiceID1.Text);


            SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
            DataTable dtCustomerGridView = new DataTable();
            sqlAdapter.Fill(dtCustomerGridView);
            grdvwTicketDisplay.DataSource = dtCustomerGridView;
            grdvwTicketDisplay.DataBind();
        }

        protected void btnTicketHistorySubmit_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int HistoryTicketID = rand.Next(1000000, 10000000);


            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();


            String query = "INSERT INTO TicketHistory VALUES ('" + HistoryTicketID + "','" + txtDateTime.Text + "','" + txtServTicketID.Text
               + "','" + txtYourEmployeeID.Text + "')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnFullHistory_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();


            grdvwTicketDisplay.DataSource = null;
            grdvwTicketDisplay.DataBind();

            SqlCommand cmd = new SqlCommand("SELECT TicketChangeDate, TicketHistory.ServiceTicketID, EmpIDTicket, ServiceTicket.InitiatingEmployeeID FROM TicketHistory INNER JOIN ServiceTicket ON TicketHistory.ServiceTicketID = ServiceTicket.ServiceTicketID WHERE ServiceID = @ServiceID", con);

            cmd.Parameters.AddWithValue("ServiceID", txtServiceID1.Text);


            SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
            DataTable dtCustomerGridView = new DataTable();
            sqlAdapter.Fill(dtCustomerGridView);
            grdvwTicketDisplay.DataSource = dtCustomerGridView;
            grdvwTicketDisplay.DataBind();
        }
    }
}

