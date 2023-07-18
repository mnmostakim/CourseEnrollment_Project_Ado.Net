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

namespace ADO.NET_Project.Students
{
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.Columns.Add(new DataColumn("image", typeof(System.Byte[])));
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["image"] = File.ReadAllBytes(Path.Combine(Path.GetFullPath(@"..\..\Pictures"), dt.Rows[i]["StudentPicture"].ToString()));
                    }
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.DataSource = dt;

                }
            }
        }
    }
}
