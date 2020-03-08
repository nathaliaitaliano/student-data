using System;

namespace Common
{
    public class Student
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        {
        }

        public Student(String name, String surname, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
