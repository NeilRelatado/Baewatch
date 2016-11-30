using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using Microsoft.AspNet.Identity;

namespace SearchBarwithMasterPage
{
    public partial class AccountSettings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DeleteConfirm.aspx");
        }

        protected void btnUpdateDesc_Click(object sender, EventArgs e)
        {
            string username = User.Identity.GetUserName();
            string Description = txtDescription.Text;
            int ID = 0;
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetProfileByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUser = new SqlParameter()
                {
                    ParameterName = "@Username",
                    Value = username
                };
                cmd.Parameters.Add(paramUser);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr["ID"]);
                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand("spUpdateDescription", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter paramID = new SqlParameter()
                {
                    ParameterName = "@ID",
                    Value = ID
                };
                cmd2.Parameters.Add(paramID);
                SqlParameter paramDesc = new SqlParameter()
                {
                    ParameterName = "@Description",
                    Value = Description

                };
                cmd2.Parameters.Add(paramDesc);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Description has been changed";
            }


        }

        protected void btnUpdateInt_Click(object sender, EventArgs e)
        {
            string username = User.Identity.GetUserName();
            string Intrests = txtIntrests.Text;
            int ID = 0;
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetProfileByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUser = new SqlParameter()
                {
                    ParameterName = "@Username",
                    Value = username
                };
                cmd.Parameters.Add(paramUser);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr["ID"]);
                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand("spUpdateIntrests", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter paramID = new SqlParameter()
                {

                    ParameterName = "@ID",
                    Value = ID
                };
                cmd2.Parameters.Add(paramID);
                SqlParameter paramInt = new SqlParameter()
                {

                    ParameterName = "@Intrest",
                    Value = Intrests

                };
                cmd2.Parameters.Add(paramInt);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Intrests has been changed";



            }
        }

        protected void btnUpdateGender_Click(object sender, EventArgs e)
        {
            String Gender = "";
            string username = User.Identity.GetUserName();
            if (Male.Checked)
            {
                Gender = "Male";

            }

            else if (Female.Checked)
            {
                Gender = "Female";
            }

            else if (Other.Checked)
            {

                Gender = "Other";

            }


            int ID = 0;
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetProfileByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUser = new SqlParameter()
                {
                    ParameterName = "@Username",
                    Value = username
                };
                cmd.Parameters.Add(paramUser);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr["ID"]);
                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand("spUpdateGender", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter paramid = new SqlParameter()
                {
                    ParameterName = "@ID",
                    Value = ID

                };
                cmd2.Parameters.Add(paramid);

                SqlParameter paramGender = new SqlParameter()
                {

                    ParameterName = "@Gender",
                    Value = Gender

                };
                cmd2.Parameters.Add(paramGender);

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Gender has been changed";



            }



        }

        protected void btnOrientation_Click(object sender, EventArgs e)
        {
            String O = "";
            string username = User.Identity.GetUserName();
            if (Strait.Checked)
            {
                O = "Strait";
            }

            if (Gay.Checked)
            {
                O = "Gay";

            }

            if (OtherOrientation.Checked)
            {
                O = "Other";
            }

            int ID = 0;
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetProfileByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUser = new SqlParameter()
                {
                    ParameterName = "@Username",
                    Value = username
                };
                cmd.Parameters.Add(paramUser);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr["ID"]);
                }
                con.Close();
                SqlCommand cmd2 = new SqlCommand("spUpdateOrein", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter paramID = new SqlParameter() 
                { 
                ParameterName="ID",
                Value=ID
                };
                cmd2.Parameters.Add(paramID);
                SqlParameter paramO = new SqlParameter() 
                {
                    ParameterName = "@Orientation",
                    Value=O
               
                };
                cmd2.Parameters.Add(paramO);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                lblMessage.Text = "Orientation has changed";
            }
        }
    }
}