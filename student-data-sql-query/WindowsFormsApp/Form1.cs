using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;
using DataAccess;

namespace WindowsFormsApp
{
    public partial class formStudent : Form
    {
        public formStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String surname = textBoxSurname.Text;
            DateTime dateOfBirth = pickerDateOfBirth.Value;

            Student student = new Student(name, surname, dateOfBirth);

            StudentDao studentDao = new StudentDao();
            studentDao.Add(student);
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            StudentDao studentDao = new StudentDao();
            List<Student> studentsDataList = studentDao.GetAllStudents();
            string studentsList = "";

            foreach (Student studentData in studentsDataList)
            {
                string studentInformation = studentData.ToString();
                studentsList += studentInformation + "\n";
            }

            MessageBox.Show(studentsList);
        }
    }
}