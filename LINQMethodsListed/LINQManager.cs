using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Ansvarar för (Managerar) alla metodanrop, medans metoderna ligger i LINQOperationsMethods
///
namespace LINQMethodsListed
{
    public class LINQManager
    {
        //Alla kända LINQ-mtoder testas nedan: 
        ///Filtering Methods:
        //1. `Where`  alla personer över 30 år
        public static void RunWhere(IEnumerable<Person> people)
        {
            Console.WriteLine("Alla personer över 30 år");
            people
            .Where(p => p.Age > 30)
            .ToList()
            .ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}"));
            Console.WriteLine("-------------------------");
        }
        //2. `Take`  de första 5 personerna i listan.
        public static void RunTake(IEnumerable<Person> people)
        {
            Console.WriteLine("Första 5 personerna i listan");
            people.Take(5)
                .ToList()
                .ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}"));
            Console.WriteLine("-------------------------");
        }
    }
}
