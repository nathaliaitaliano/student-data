using Common;
using System;
using System.Collections.Generic;
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
            Database.ExecuteQuery(sql);
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

        public void UpdateStudent(Student student)
        {
            string sql = $"Update dbo.Students set Name='{student.Name}', Surname='{student.Surname}', " +
                $"Birthday='{student.DateOfBirth}' where StudentId='{student.StudentId}'";
            Database.ExecuteQuery(sql);
        }

        public void DeleteStudentById(Int32 studentId)
        {
            string sql = $"Delete dbo.Students where StudentId='{studentId}'";
            Database.ExecuteQuery(sql);
        }

        private List<Student> CreateStudentList(String sql)
        {
            List<object[]> studentsData = Database.ReadData(sql);
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