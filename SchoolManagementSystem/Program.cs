
using System;
using SchoolManagementSystem;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Person student = new Person();
            student.Name = "Ceyda";
            student.SurName = "Türkdoğan";
            student.BirthDate = new DateTime(1995,01,21);

            student.ShowInformation();

        }
    }
}

