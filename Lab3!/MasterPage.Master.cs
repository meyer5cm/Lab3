﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Lab2
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                lblUserLoggedIn.Text = Session["UserName"].ToString() + " successfully logged in";
            }
            else
            {
                Session["InvalidUse"] = "You must first login to access this page!";
                Response.Redirect("LoginPage.aspx");
            }
        }
 
            //Button Click Events
            protected void btnAddCustomer_Click(object sender, EventArgs e)
            {
                Response.Redirect("AddCust.aspx");
            }

            protected void btnAddServiceEvent_Click(object sender, EventArgs e)
            {
                Response.Redirect("AddServ.aspx");
            }

            protected void btnEditViewCustomer_Click(object sender, EventArgs e)
            {
                Response.Redirect("EditCust.aspx");
            }

            protected void btnEditViewServiceEvent_Click(object sender, EventArgs e)
            {
                Response.Redirect("EditServ2.aspx");
            }

            protected void btnViewEngagements_Click(object sender, EventArgs e)
            {

            }

            protected void btnViewInventory_Click(object sender, EventArgs e)
            {
                 Response.Redirect("Inventory.aspx");
             }

            protected void btnMyAccount_Click(object sender, EventArgs e)
            {

            }

            protected void txtSearch_TextChanged(object sender, EventArgs e)
            {

            }

            protected void btnSearch_Click(object sender, EventArgs e)
            { 
        
             }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx?loggedout=true");
        }
    }

}
