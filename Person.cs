using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOPFirstClass
{
    public class Person
    {
        private string _name;
        private string _surName;
        private DateTime _birthDate;
        public string status;


        public string name
        {
            get { return name; }
            set { _name = value; }
        }

        public string surName
        {
            get { return surName; }
            set { _surName = value; }
        }
        public DateTime birthDate
        {
            get { return birthDate; }
            set { _birthDate = value; }
        }

        public void Greeting()
        {
            Console.WriteLine($"Hi! My name is {_name} {_surName}. I born in {_birthDate}.  I am {status}. ");
        }
    }
}
