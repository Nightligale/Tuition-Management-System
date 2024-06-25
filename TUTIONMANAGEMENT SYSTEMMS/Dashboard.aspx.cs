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
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
                if (!IsPostBack)
                {
                    DisplayDashboard();
                }
            }

            private void DisplayDashboard()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["TuitionManagementDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                // Most Excellent Students
                // Class with the most excellent students
                lblMostExcellentClass.Text = GetClassWithMostStudents(conn, "Excellent");

                // Class with the average students
                lblAverageClass.Text = GetClassWithMostStudents(conn, "Average");

                // Class with the poor students
                lblPoorClass.Text = GetClassWithMostStudents(conn, "Poor");

                conn.Close();
            }
        }

        private string GetClassWithMostStudents(SqlConnection conn, string status)
        {
            string query = "SELECT TOP 1 Class, COUNT(*) AS StudentCount FROM Students WHERE EducationalStatus = @Status GROUP BY Class ORDER BY StudentCount DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Status", status);

            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : "No data available";
        }
    }


}
            
