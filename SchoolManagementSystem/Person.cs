using System;

namespace SchoolManagementSystem
{
    public class Person
    {
        private string firstName;
        private string surName;
        private DateTime birthDay;
        public string Name {
            get
            {
                return firstName;
            }
            set
            {
                firstName=value;
            }
        }

        public string SurName
        {
            get
            { 
                return surName;
            }

            set
            {
                surName=value;
            }
        }

        public DateTime BirthDate {
            get 
            {
                return birthDay;
            }

            set
            {

                birthDay=value;
            }
        
        } 

        public void ShowInformation()
        {
            Console.WriteLine($"İsim:{Name}\nSoyisim:{SurName}\nDoğum Tarihi:{BirthDate}");
        }
    }
}
