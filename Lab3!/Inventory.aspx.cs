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
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnViewAllServices_Click(object sender, EventArgs e)
        //{
        //    grdvwServDisplay.DataSource = null;
        //    grdvwServDisplay.DataBind();

        //    String sqlQuery = "SELECT CustFirstName, CustLastName, Customer.CustomerID, Service.ServiceID, Service.ServiceDate FROM Customer RIGHT OUTER JOIN Service ON Customer.CustomerID = Service.CustomerID ORDER BY CustLastName";


        //    SqlConnection sqlConnect = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
        //    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery, sqlConnect);
        //    DataTable dtCustomerGridView = new DataTable();
        //    sqlAdapter.Fill(dtCustomerGridView);
        //    grdvwServDisplay.DataSource = dtCustomerGridView;
        //    grdvwServDisplay.DataBind();
        //}

        protected void btnViewAllInv_Click(object sender, EventArgs e)
        {
            grdviewInvDisplay.DataSource = null;
            grdviewInvDisplay.DataBind();

            String sqlQuery = "SELECT CustomerLastName, ServiceDate, Inventory.ItemInInventory, Inventory.InventoryDate, Inventory.ItemCost, Inventory.ItemID, Inventory.ServiceID FROM Service INNER JOIN Inventory On Service.ServiceID = Inventory.ServiceID ORDER BY CustomerLastName";
            

            SqlConnection sqlConnect = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery, sqlConnect);
            DataTable dtCustomerGridView = new DataTable();
            sqlAdapter.Fill(dtCustomerGridView);
            grdviewInvDisplay.DataSource = dtCustomerGridView;
            grdviewInvDisplay.DataBind();
        }
    


        protected void btnAddInv_Click(object sender, EventArgs e)
        {
            {

                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
                con.Open();


                String query = "INSERT INTO Inventory (ItemInInventory,InventoryDate,ItemCost,ItemID,ServiceID) VALUES ('" + txtItemName1.Text + "','" + txtInventoryDate1.Text +
                    "','" + txtItemCost1.Text + "','" + txtItemID1.Text + "','" + txtServiceID1.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        protected void btnPopulateInv_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ItemID = rnd.Next(1, 100000);

            txtItemName1.Text = "Desk";
            txtInventoryDate1.Text = "03/22/2020";
            txtItemCost1.Text = "210";
            txtServiceID1.Text = "837164";
            txtItemID1.Text = ItemID.ToString();
        }

        protected void btnGenerateItemID_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ItemID = rnd.Next(1, 100000);
            txtItemID1.Text = ItemID.ToString();
        }

        protected void ddlInv_SelectedIndexChanged1(object sender, EventArgs e) 

        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            con.Open();


            grdviewInvDisplay.DataSource = null;
            grdviewInvDisplay.DataBind();

            SqlCommand cmd = new SqlCommand("SELECT CustomerLastName, ServiceDate, Inventory.ItemInInventory, Inventory.InventoryDate, Inventory.ItemCost, Inventory.ItemID, Inventory.ServiceID FROM Service INNER JOIN Inventory On Service.ServiceID = Inventory.ServiceID WHERE CustomerID = @CustID",con);

            cmd.Parameters.AddWithValue("CustID", ddlInv.SelectedValue);

        
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                DataTable dtCustomerGridView = new DataTable();
                sqlAdapter.Fill(dtCustomerGridView);
                grdviewInvDisplay.DataSource = dtCustomerGridView;
                grdviewInvDisplay.DataBind();
        }

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


        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(Page);
        }
    }
}