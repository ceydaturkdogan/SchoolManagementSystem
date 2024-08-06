using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Person
    {
        private string name;
        private string surName;
        private DateTime birthDay;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }

        public string SurName
        {
            get
            { return surName;
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

        public void DisplayInfo()
        {
            Console.WriteLine($"İsim:{Name}\nSoyisim:{SurName}\nDoğum Tarihi:{BirthDate}");
        }
    }
}
