using LINQMethodsListed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethodsListed
{
    public static class Data
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
            new Person { FirstName = "Anna", LastName = "Green", Age = 25, BirthDay = new DateTime(1999, 05, 07), Occupation = "Teacher" ,Gender =Gender.Female },
            new Person { FirstName = "David", LastName = "Lund", Age = 50, BirthDay = new DateTime(1941, 06, 12), Occupation = "Driver" ,Gender =Gender.Male },
            new Person { FirstName = "Karl", LastName = "Olsson", Age = 62, BirthDay = new DateTime(1962, 01, 01), Occupation = "Farmer", Gender = Gender.Male }, 
            new Person { FirstName = "Cecilia", LastName = "Ek", Age = 18, BirthDay = new DateTime(2006, 02, 11), Occupation = "Studenr" ,Gender =Gender.Female },
            new Person { FirstName = "Gudrun", LastName = "Svensk", Age = 64, BirthDay = new DateTime(1960, 05, 28), Occupation = "Teacher", Gender = Gender.Female },
            new Person { FirstName = "Gun", LastName = "Larsson", Age = 58, BirthDay = new DateTime(1966, 03, 05), Occupation = "Chef", Gender = Gender.Female },
            new Person { FirstName = "Gunnar", LastName = "Broman", Age = 55, BirthDay = new DateTime(1969, 08, 02), Occupation = "Farmer", Gender = Gender.Male },
            new Person { FirstName = "Anne", LastName = "Lilja", Age = 22, BirthDay = new DateTime(2002, 12, 07), Occupation = "Student", Gender = Gender.Female }
            };
        }
    }
}
