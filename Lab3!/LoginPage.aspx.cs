using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Get("loggedout") == "true")
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "User has successfully logged out";
            }

            if (Session["InvalidUse"] != null)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = Session["InvalidUse"].ToString();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string username = "meyer5cm";
        //    string password = "dukedog";

        //    if (String.Equals(username,txtUserName.Text) && String.Equals(password, txtPassword.Text))
        //    {
        //        Session["UserName"] = txtUserName.Text;
        //        Response.Redirect("AddCust.aspx");
        //    }   
        //    else
        //    {
        //        lblStatus.ForeColor = Color.Red;
        //        lblStatus.Font.Bold = true;
        //        lblStatus.Text = "Either the Username and/or Password are Incorrect";
        //    }
        //}
        //{
        //    String sqlQuery = "SELECT COUNT(1) from Credentials where Username = @Username AND Password = @Password";

        //    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);

        //    SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);

        //    sqlCommand.Parameters.AddWithValue("Username", txtUserName.Text);
        //    sqlCommand.Parameters.AddWithValue("Password", txtPassword.Text);

        //    con.Open();

        //    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

        //    if (count == 1)
        //    {
        //        Session["UserName"] = txtUserName.Text;
        //        Response.Redirect("AddServ.aspx");
        //    }
        //    else
        //    {
        //        lblStatus.ForeColor = Color.Red;
        //        lblStatus.Font.Bold = true;
        //        lblStatus.Text = "Either the Username and/or Password are Incorrect";
        //    }

        //}
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);
            SqlCommand LoginCommand = new SqlCommand();

            LoginCommand.Connection = con;
            LoginCommand.CommandType = CommandType.StoredProcedure;
            LoginCommand.CommandText = "JeremyEzellLab3";

            LoginCommand.Parameters.AddWithValue("UserName", txtUserName.Text);
            LoginCommand.Parameters.AddWithValue("PassWord", txtPassword.Text);

            con.Open();
            SqlDataReader LoginResults = LoginCommand.ExecuteReader();

            if (LoginResults.Read())
            {
                Session["UserName"] = txtUserName.Text;
                Response.Redirect("AddServ.aspx");
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Font.Bold = true;
                lblStatus.Text = "Either the Username and/or Password are Incorrect";
            }
        }


        protected void btnForgotUP_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotUP.aspx");
        }
    }
}