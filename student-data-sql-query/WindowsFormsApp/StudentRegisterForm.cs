using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;
using DataAccess;
using log4net;

namespace WindowsFormsApp
{
    public partial class StudentRegisterForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StudentDao));
        public StudentRegisterForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBoxName.Text;
                String surname = textBoxSurname.Text;
                DateTime dateOfBirth = pickerDateOfBirth.Value;

                Student student = new Student(name, surname, dateOfBirth);

                StudentDao studentDao = new StudentDao();
                studentDao.Add(student);
                MessageBox.Show("Student added succesfully");
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }

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

        private void btnSearchStudentId_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDao studentDao = new StudentDao();
                String studentId = textBoxStudentId.Text;

                if (String.IsNullOrEmpty(studentId))
                {
                    MessageBox.Show("ID can't be null!");
                    return;
                }

                Student student = studentDao.GetStudentById(Int32.Parse(studentId));

                if (student == null)
                {
                    MessageBox.Show("Invalid student ID!");
                    return;
                }

                String studentById = student.ToString();
                MessageBox.Show(studentById);
            }
            catch(ArgumentNullException exception) 
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
            catch (FormatException exception)
            {
                log.Error("Format exception!", exception);
                throw;
            }
            catch (OverflowException exception)
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            try
            {
                String studentId = textBoxStudentId.Text;
                StudentDao studentDao = new StudentDao();

                studentDao.DeleteStudentById(Int32.Parse(studentId));
                MessageBox.Show("Student deleted succesfully!");
            }
            catch (ArgumentNullException exception)
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
            catch (FormatException exception)
            {
                log.Error("Format exception!", exception);
                throw;
            }
            catch (OverflowException exception)
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try 
            {
            StudentDao studentDao = new StudentDao();
            String studentId = textBoxStudentId.Text;
            Student student = studentDao.GetStudentById(Int32.Parse(studentId));

            var updateStudent = new UpdateStudentForm(student);
            updateStudent.Show();
            }
            catch (ArgumentNullException exception)
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
            catch (FormatException exception)
            {
                log.Error("Format exception!", exception);
                throw;
            }
            catch (OverflowException exception)
            {
                log.Error("Argument null exception!", exception);
                throw;
            }
        }
    }
}