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
    public partial class Addteacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            string teacherClass = txtClass.Text;
            string username=txtUsername.Text;   
            string password=txtPassword.Text;
            string role = TextBox1.Text;

            // Database connection and insertion logic

            SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            {
                string query = "INSERT INTO Teachers (Name, Address, Contact, Class,Username,Password,Role) VALUES (@Name, @Address, @Contact, @Class,@Username,@Password,@Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Class", teacherClass);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
    }
}