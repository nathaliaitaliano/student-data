using Common;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    interface IStudentDao
    {
        void Add(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(Int32 studentId);
        void UpdateStudent(Student student);
        void DeleteStudentById(Int32 studentId);
    }
}