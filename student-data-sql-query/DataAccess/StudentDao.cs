using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using log4net;

namespace DataAccess
{
    public class StudentDao
    {
        private static readonly ILog log= LogManager.GetLogger(typeof(StudentDao));

        public void Add(Student student)
        {
            log.Info(student.Name);

            string sql = $"Insert into dbo.Students (Name, Surname, Birthday) " +
                $"values('{student.Name}', '{student.Surname}', '{student.DateOfBirth}')";
            ExecuteQuery(sql);
        }

        public List<Student> GetAllStudents()
        {
            string sql = "Select StudentId, Name, Surname, Birthday from dbo.Students";
            List<Student> studentsList = CreateStudentList(sql);
            return studentsList;
        }

        public Student GetStudentById(Int32 studentId)
        {
            string sql = $"Select * from dbo.Students where StudentId='{studentId}'";
            List<Student> studentById = CreateStudentList(sql);
            return studentById[0];
        }

        public void DeleteStudentById(Int32 studentId)
        {
            string sql = $"Delete dbo.Students where StudentId='{studentId}'";
            ExecuteQuery(sql);
        }

        private  SqlConnection DatabaseConnection()
        {
            string connectionConfiguration;

            connectionConfiguration = @"Data Source=Localhost;Initial Catalog=Vueling;User ID=sa;Password=yourStrong(!)Password";
            return new SqlConnection(connectionConfiguration);
        }

        private void ExecuteQuery(String sql)
        {
            SqlConnection connection = DatabaseConnection();
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand query = new SqlCommand(sql, connection);

            adapter.InsertCommand = query;
            adapter.InsertCommand.ExecuteNonQuery();

            query.Dispose();
            connection.Close();
        }

        private List<object[]> ReadData(String sql)
        {
            SqlConnection connection = DatabaseConnection();
            connection.Open();

            SqlCommand query = new SqlCommand(sql, connection);
            SqlDataReader dataReader = query.ExecuteReader();
            
            List<object[]> studentsList = new List<object[]>();
            
            while(dataReader.Read())
            {
                object[] student = new object[4];
                dataReader.GetValues(student);
                studentsList.Add(student);
            }

            query.Dispose();
            connection.Close();
            return studentsList;
        }

        private List<Student> CreateStudentList(String sql)
        {
            List<object[]> studentsData = ReadData(sql);
            List<Student> studentsLista = new List<Student>();

            foreach (object[] studentData in studentsData)
            {
                Int32 studentId = (Int32)studentData[0];
                String name = (String)studentData[1];
                String surname = (String)studentData[2];
                DateTime dateOfBirth = (DateTime)studentData[3];

                Student student = new Student(studentId, name, surname, dateOfBirth);
                studentsLista.Add(student);
            }
            return studentsLista;
        }
    }
}