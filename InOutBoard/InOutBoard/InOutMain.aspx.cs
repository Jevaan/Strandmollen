using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Reflection;

namespace InOutBoard
{
    public partial class InOutMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListView2.InsertItemPosition = InsertItemPosition.FirstItem;
            if (IsPostBack)
            {
                if (Request.QueryString["Guest"] == "1")
                {
                    RemoveGuest(Request.QueryString["ID"]);
                }
                else
                    UpdateStatus(Request.QueryString["Option"],Request.QueryString["ID"]);

            }
        }

        public void UpdateStatus(string NewStatus, string UserID)
        {
            if (NewStatus != "Notify" && NewStatus != null)
            {
                string SQLUpdateStatus = "UPDATE Availability SET SID="+ NewStatus + " WHERE EID=" + UserID;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InOutBoardConnectionString"].ConnectionString);
                SqlCommand comm = new SqlCommand(SQLUpdateStatus, cn);
                comm.Connection.Open();
                comm.ExecuteNonQuery();
                cn.Close();
                ListView1.DataBind();
                PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                // make collection editable 
                isreadonly.SetValue(this.Request.QueryString, false, null);
                // remove 
                this.Request.QueryString.Remove("Option");
                this.Request.QueryString.Remove("ID");
                //DebugLabel.Text = "Status: " + NewStatus + " for user: " + UserID;
            }
            if (NewStatus == "Notify")
            {
                
            }
        }
        private void RemoveGuest(string GuestID)
        {
            string SQLUpdateStatus = "UPDATE Guests SET InHouse='false' WHERE ID=" + GuestID;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InOutBoardConnectionString"].ConnectionString);
            SqlCommand comm = new SqlCommand(SQLUpdateStatus, cn);
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            cn.Close();
            ListView2.DataBind();
            PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            // make collection editable 
            isreadonly.SetValue(this.Request.QueryString, false, null);
            // remove 
            this.Request.QueryString.Remove("Option");
            this.Request.QueryString.Remove("ID");
            this.Request.QueryString.Remove("Guest");

        }

        protected void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ListView1.DataBind();
        }
        
        public string ImagePath(object Image)
        {
            string FullPath = "/images/nophoto.jpg";
            if (Image.ToString() != "" && Image.ToString() != null && Image.ToString() !="guest")
                FullPath = @"http://d4infonet/Documents/Employee/Images/" + Image.ToString() + ".jpg";
            if (Image.ToString() == "guest")
                FullPath = "/images/guest.jpg";
            return FullPath;
        }
        public void InsertGuest(object sender, EventArgs e)
        {
            SqlDataGuests.Insert();

        }


    }
}