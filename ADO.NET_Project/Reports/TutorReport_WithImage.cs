using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer;
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

namespace ADO.NET_Project.Reports
{
    public partial class TutorReport_WithImage : Form
    {
        
        public TutorReport_WithImage()
        {
            InitializeComponent();
        }

        private void TutorReport_WithImage_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutors", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tutors1");
                    ds.Tables["Tutors1"].Columns.Add(new DataColumn("image", typeof(System.Byte[])));
                    for (var i = 0; i < ds.Tables["Tutors1"].Rows.Count; i++)
                    {
                        ds.Tables["Tutors1"].Rows[i]["image"] = File.ReadAllBytes(Path.Combine(Path.GetFullPath(@"..\..\Pictures"), ds.Tables["Tutors1"].Rows[i]["TutorPicture"].ToString()));
                    }
                    TutorReportWithImage rpt = new TutorReportWithImage();
                    rpt.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource = rpt;
                    this.crystalReportViewer1.Refresh();
                }
            }
        }
    }

}
