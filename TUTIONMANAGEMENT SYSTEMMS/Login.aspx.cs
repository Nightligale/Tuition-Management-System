using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TUTIONMANAGEMENT_SYSTEMMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = ddlUserType.SelectedValue;
            //  SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            string query = "";
            if (userType == "Student")
            {
                query = "SELECT * FROM Students WHERE Username = @Username AND Password = @Password";
            }
            else if (userType == "Teacher")
            {
                query = "SELECT * FROM Teachers WHERE Username = @Username AND Password = @Password";
            }

            SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
               Session["UserID"] = userType == "Student" ? reader["StudentID"] : reader["TeacherID"];
                Session["Username"] = reader["Username"];
                Session["Role"] = reader["Role"];
                Session["UserType"] = userType;
                Response.Redirect("ViewStudent.aspx"); // Redirect to the welcome page or dashboard
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }

            reader.Close();
            conn.Close();
        }
    }
}
