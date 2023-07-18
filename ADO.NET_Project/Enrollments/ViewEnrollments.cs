using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Project.Enrollments
{
    public partial class View_Enrollments : Form
    {
        public View_Enrollments()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Enrollments_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Enrollments", con))
                {
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }
                this.dataGridView1.AutoGenerateColumns = false;
            }
        }
    }
}
