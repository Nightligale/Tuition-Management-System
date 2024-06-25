using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TUTIONMANAGEMENT_SYSTEMMS
{
    public partial class StudentDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentID"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblStudentName.Text = Session["StudentName"].ToString();

            if (!IsPostBack)
            {
                DisplayMotivationalMessage();
            }
        }

        private void DisplayMotivationalMessage()
        {
            string studentName = Session["StudentName"].ToString();

            SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            {
                string query = "SELECT EducationalStatus FROM Students WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string status = reader["EducationalStatus"].ToString();
                    lblMessage.Text = GetMotivationalMessage(status);
                }
            }
        }

        private string GetMotivationalMessage(string status)
        {
            switch (status)
            {
                case "Excellent":
                    return "Keep up the great work!";
                case "Good":
                    return "You're doing well, strive for excellence!";
                case "Average":
                    return "If you try more, you can be great at academics.";
                case "Poor":
                    return "Don't give up, keep pushing and you will improve.";
                default:
                    return "Keep striving for your best!";
            }
        }
    }
}