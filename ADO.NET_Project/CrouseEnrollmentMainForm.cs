using ADO.NET_Project.Courses;
using ADO.NET_Project.Enrollments;
using ADO.NET_Project.Reports;
using ADO.NET_Project.Students;
using ADO.NET_Project.Tutors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Project
{
    public partial class CrouseEnrollmentMainForm : Form
    {
        public CrouseEnrollmentMainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewTutorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewTutors { MdiParent = this }.Show();
        }

        private void addTutorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddTutors { MdiParent = this }.Show();
        }

        private void editUpdateTutorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditTutors { MdiParent = this }.Show();
        }

        private void CrouseEnrollmentMainForm_Load(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewStudents { MdiParent = this }.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddStudent { MdiParent = this }.Show();
        }

        private void editDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditStudent { MdiParent = this }.Show();
        }

        /*private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewCourses { MdiParent = this }.Show();
        }*/

        /*private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCourse { MdiParent = this }.Show();
        }*/

        /*private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Courses { MdiParent = this }.Show();
        }*/

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewCourses { MdiParent = this }.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCourse { MdiParent = this }.Show();
        }

        private void editDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EditCourse { MdiParent = this }.Show();
        }

        /*private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Enrollments { MdiParent = this }.Show();
        }*/

        private void viewEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View_Enrollments { MdiParent = this }.Show();
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentsReport { MdiParent = this }.Show();
        }

        private void courseTutorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CourseTutor_Report { MdiParent = this }.Show();
        }

        private void tutorReportWithImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TutorReport_WithImage { MdiParent = this }.Show();
        }

        /*private void courseTutorSubReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CourseTutor_SubReport { MdiParent = this }.Show();
        }*/

        private void addEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*new AddEnrollments { MdiParent = this }.Show();*/
        }

        private void addEnrollmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddEnrollment { MdiParent=this}.Show();
        }

        private void courseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Course_Report { MdiParent = this }.Show();
        }

        private void courseTutorSubReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSubRepoer { MdiParent = this }.Show();
        }
    }
}
