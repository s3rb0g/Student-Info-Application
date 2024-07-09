using StudentNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = firstName.Text.ToString();
            string lname = lastName.Text.ToString();
            int studId = int.Parse(studID.Text);

            StudentInfo student = new StudentInfo();

            student.firstName = fname;
            student.lastName = lname;
            student.studentID = studId;

            listStudentID.Items.Add(student.studentID);
            listFirstname.Items.Add(student.firstName);
            listLastName.Items.Add(student.lastName);

            firstName.Clear();
            lastName.Clear();
            studID.Clear();


        }
    }
}
