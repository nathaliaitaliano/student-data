using Common;
using DataAccess;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm(Common.Student student)
        {
            InitializeComponent();
            textBoxStudentId.Text = student.StudentId.ToString();
            textBoxUpdateName.Text = student.Name;
            textBoxUpdateSurname.Text = student.Surname;
            pickerUpdateDateOfBirth.Value = student.DateOfBirth;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 studentId = Int32.Parse(textBoxStudentId.Text);
            String name = textBoxUpdateName.Text;
            String surname = textBoxUpdateSurname.Text;
            DateTime dateOfBirth = pickerUpdateDateOfBirth.Value;

            Student student = new Student(studentId, name, surname, dateOfBirth);

            StudentDao studentDao = new StudentDao ();
            studentDao.UpdateStudent(student);
            MessageBox.Show("Student updated succesfully");
        }
    }
}