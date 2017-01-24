using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNet.Identity;

namespace SearchBarwithMasterPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Format("Hello {0}!!", User.Identity.GetUserName());
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from Users", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                HomepageGridView.DataSource = rdr;
                HomepageGridView.DataBind();
                conn.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfile.aspx?ID=" + ((LinkButton)sender).Text);

        }

        private void LoadImage()
        {
            string cs = ConfigurationManager.ConnectionStrings["BaewatchConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from Users", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                HomepageGridView.DataSource = rdr;
                HomepageGridView.DataBind();
                conn.Close();

            }
        }

        protected void btnMale_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Genders.aspx");

        }

        protected void btnFemale_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Females.aspx");

        }

        protected void Btnstraight_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/straight.aspx");
        }

        protected void BtnGay_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/gay.aspx");

        }

        protected void BtnOther_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Other.aspx");

        }

        protected void Long_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LongTerm.aspx");
        }

        protected void Short_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShortTerm.aspx");
        }

        protected void Friends_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Friends.aspx");
        }
    }
}