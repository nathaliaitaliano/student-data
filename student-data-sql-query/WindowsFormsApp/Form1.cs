using System;
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
    }
}