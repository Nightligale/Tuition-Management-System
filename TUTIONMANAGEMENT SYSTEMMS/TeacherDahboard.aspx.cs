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
    public partial class TeacherDahboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["TeacherID"] == null)
            {
                Response.Redirect("TeaLogin.aspx");
            }

            lblTeacherName.Text = Session["TeacherName"].ToString();

            if (!IsPostBack)
            {
                BindStudentsGrid();
            }
        }

        private void BindStudentsGrid()
        {

            SqlConnection conn = new SqlConnection("Data Source=Nimisha;Initial Catalog=TuitionManagementDB;Integrated Security=True");
            {
                string query = "SELECT * FROM Students";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                gvStudents.DataSource = reader;
                gvStudents.DataBind();
            }
        }
    }
}
    
