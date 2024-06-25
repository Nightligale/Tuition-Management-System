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
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddStudent_Click(object sender, EventArgs e)

        {     
            string name = txtName.Text;
            string address = txtAddress.Text;
            string studentClass = txtClass.Text;
            string status = ddlStatus.SelectedValue;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtrole.Text;

            // Database connection and insertion logic

            SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            {
                string query = "INSERT INTO Students (Name, Address, Class, EducationalStatus,Username,Password,Role) VALUES (@Name, @Address, @Class, @Status,@Username,@Password,@Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Class", studentClass);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Username", username);
             cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
