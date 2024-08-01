using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOPFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Instance and defining fields/properties of student sample ▼
            Person person1 = new Person();
            person1.name = "Mert";
            person1.surName = "Topçu";
            person1.birthDate = new DateTime(1995, 1, 17);
            person1.status = "Student";

            // ▼ Instance and defining fields/properties of teacher sample ▼
            Person person2 = new Person();
            person2.name = "Sertan";
            person2.surName = "Bozkuş";
            person2.birthDate = new DateTime(1994, 1, 1);
            person2.status = "Teacher";

            // ▼ Getting their informations with method in Person class 'Person.cs' ▼
            person1.Greeting();
            person2.Greeting();
        }
    }
}
