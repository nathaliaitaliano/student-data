using System;

namespace Common
{
    public class Student
    {
        public Int32 StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        {
        }

        public Student(Int32 studentId, String name, String surname, DateTime dateOfBirth):this(name, surname, dateOfBirth)
        {
            this.StudentId = studentId;
        }

        public Student(String name, String surname, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
        }

        public override String ToString()
        {
            return "ID: " + StudentId + " - " + "Name: " + Name + " " + Surname + " - " 
                + "Date of Birth: " + DateOfBirth.ToString("dd/MM/yyyy");
        }
    }
}