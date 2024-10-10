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
            new Person { Name = "Anna", Age = 25 },
            new Person { Name = "David", Age = 32 },
            new Person { Name = "Karl", Age = 28 },
            new Person { Name = "Cecilia", Age = 22 },
            new Person { Name = "Gudrun", Age = 45 }
            };
        }
    }

}
