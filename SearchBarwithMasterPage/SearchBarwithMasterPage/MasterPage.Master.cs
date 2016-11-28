using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchBarwithMasterPage
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        public static string passingText;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Panel SearchPanel
        { 
         get 
         {
             return this.panelSearch;
         }
        }

        public Button SearchButton
        {
            get
            {
                return this.btnSearch;
            }
        }

        public string SearchTerm
        {

            get 
            {
                return this.txtSearch.Text;
            }
        
        
        
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("~/SearchBar.aspx?"+txtSearch.Text);
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Homepage.aspx");
        }

        protected void SignOut(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Login.aspx");
        }

        protected void Friends_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/FriendsListaspx.aspx");
        }

    }
}