using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Project.Courses
{
    public partial class ViewCourses : Form
    {
        public ViewCourses()
        {
            InitializeComponent();
        }

        private void ViewCourses_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Courses", con))
                {
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
