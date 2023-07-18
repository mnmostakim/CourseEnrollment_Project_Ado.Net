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

namespace ADO.NET_Project.Enrollments
{
    public partial class AddEnrollment : Form
    {
        public AddEnrollment()
        {
            InitializeComponent();
        }

        private void AddEnrollment_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void LoadCombo()
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.comboBox1.DataSource = dt;
                    da.SelectCommand.CommandText = "SELECT  * FROM Courses";
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    this.comboBox2.DataSource = dt1;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                con.Open();
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Enrollments 
                                            (StudentID, CourseID, EnrollDate, PaymentDate, CourseFeePayment) VALUES
                                            (@si, @ci, @ed, @pd, @cp)", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@si", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@ci", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@ed", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@pd", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@cp", decimal.Parse(textBox5.Text));

                        try
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Data Save Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tran.Commit();
                                this.textBox5.Clear();
                                this.dateTimePicker1.Value = DateTime.Now;
                                this.dateTimePicker2.Value = DateTime.Now;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error Message: {ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tran.Rollback();
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                        }
                    }
                }
            }

        }
    }
}
