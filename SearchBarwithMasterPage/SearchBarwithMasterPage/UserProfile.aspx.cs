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
    public partial class UserProfile : System.Web.UI.Page





    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                lblMessage.Visible = false;
                string userID = Request.QueryString["ID"];

                if (userID == null)
                {
                    Response.Redirect("Homepage.aspx");
                }


                string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(cs))
                {

                    SqlCommand cmd2 = new SqlCommand("getImageID", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramID = new SqlParameter() 
                    {

                        ParameterName = "@Id",
                        Value=userID
                    };
                    cmd2.Parameters.Add(paramID);

                    SqlCommand cmd3 = new SqlCommand("viewComments", conn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    SqlParameter PID = new SqlParameter() 
                    {
                        ParameterName = "@ID",
                        Value=userID
                    };
                    cmd3.Parameters.Add(PID);







                    SqlCommand cmd = new SqlCommand("spGetUserID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@ID",userID);
                    cmd.Parameters.Add(param);
                    conn.Open();
                    gridview1.DataSource = cmd3.ExecuteReader();
                    gridview1.DataBind();
                    conn.Close();
                    conn.Open();
                    
                    
                    
                   using( SqlDataReader rdr = cmd.ExecuteReader())
                   {
                       while (rdr.Read())
                       {
                           lblID.Text = rdr["ID"].ToString();
                           lblUsername.Text = rdr["Username"].ToString();
                           lblDesc.Text = rdr["Description"].ToString();
                           lblIntest.Text = rdr["Intrests"].ToString();
                           lblGender.Text = rdr["Gender"].ToString();
                           lblO.Text = rdr["Orientation"].ToString();
                           lblType.Text = rdr["Type"].ToString();
                       
                       }


                   }

                 byte[] bytes= ( byte[])cmd2.ExecuteScalar();
                 string strBase64 = Convert.ToBase64String(bytes);
                 ProfilePic.ImageUrl = "data:Image/png;base64,"+strBase64;
                    conn.Close();

                }

            }
        }
       

        protected void btnPost_Click(object sender, EventArgs e)
        {
            String Comments = txrComments.Text;
             string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
             using (SqlConnection con = new SqlConnection(cs))
             {
                 SqlCommand cmd = new SqlCommand("spInsertCommments", con);
                 cmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter paramID = new SqlParameter() 
                 { 
                     ParameterName="@ID",
                     Value=Request.QueryString["ID"]
                 };
                 cmd.Parameters.Add(paramID);

                 SqlParameter paramCom = new SqlParameter() 
                 {
                     ParameterName = "@Comments",
                     Value=Comments
                
                 };
                 cmd.Parameters.Add(paramCom);

                 SqlParameter paramNewID = new SqlParameter()
                 {

                     ParameterName = "@NewID",
                     Value = -1,
                     Direction = ParameterDirection.Output
                 };
                 
                 cmd.Parameters.Add(paramNewID);
                 con.Open();
                 cmd.ExecuteNonQuery();
                 con.Close();

            
             
             
             }
        }

        protected void gridview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username="";
            string userID = Request.QueryString["ID"];
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {

                SqlCommand cmd2 = new SqlCommand("spGetUserID", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@ID", userID);
                cmd2.Parameters.Add(param);
                conn.Open();
                SqlDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    username = rdr["Username"].ToString();
                }
                SqlCommand cmd = new SqlCommand("spMakeFriends", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paramUser = new SqlParameter() 
                {
                    ParameterName = "@Username",
                    Value = username
                };
                cmd.Parameters.Add(paramUser);

                SqlParameter paramID = new SqlParameter() 
                {

                    ParameterName = "@FriendID",
                    Value=userID
                };
                cmd.Parameters.Add(paramID);

                SqlParameter paramName = new SqlParameter() 
                {

                    ParameterName = "@Name",
                    Value = User.Identity.GetUserName()
                };
                cmd.Parameters.Add(paramName);
                SqlParameter paramNewID = new SqlParameter()
                {

                    ParameterName = "@NewID",
                    Value = -1,
                    Direction = ParameterDirection.Output
                };
conn.Close();
conn.Open();
                cmd.Parameters.Add(paramNewID);
                cmd.ExecuteNonQuery();
                conn.Close();
                

                lblMessage.Visible = true;
                lblMessage.Text = "Added to Friends List";
            
            }
        }
    }
}