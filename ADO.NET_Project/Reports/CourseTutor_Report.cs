using CrystalDecisions.ReportAppServer;
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

namespace ADO.NET_Project.Reports
{
    public partial class CourseTutor_Report : Form
    {
        public CourseTutor_Report()
        {
            InitializeComponent();
        }

        private void CourseTutor_Report_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Courses", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");
                    da.SelectCommand.CommandText = "SELECT * FROM Tutors";
                    da.Fill(ds, "Tutors");
                    CourseTutor rpt = new CourseTutor();
                    rpt.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource = rpt;
                    this.crystalReportViewer1.Refresh();
                }
            }
        }

    }
}
