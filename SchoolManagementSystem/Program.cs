
using System;
using SchoolManagementSystem;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Person firstStudent = new Person() {
            Name = "Ali",
            SurName = "Acar",
            BirthDate = new DateTime(1995,01,21)
            };

            Person secondStudent = new Person() { 
            Name = "Veli",
            SurName = "Çetinkaya",
            BirthDate = new DateTime(1995, 04, 21)
            };
           
            Person firstTeacher = new Person() { 
            Name = "Semra",
            SurName = "Yılmaz",
            BirthDate = new DateTime(1995, 03, 21)
            };
            
            Person secondTeacher = new Person()
            {
                Name = "Esra",
                SurName = "Sayın",
                BirthDate = new DateTime(1995,02 ,21)
            };





            firstStudent.ShowInformation();
            secondStudent.ShowInformation();
            firstTeacher.ShowInformation();
            secondTeacher.ShowInformation();

        }
    }
}

