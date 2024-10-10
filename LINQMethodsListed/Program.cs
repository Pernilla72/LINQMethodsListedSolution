using System.Linq;
using static LINQMethodsListed.LINQManager;
using static LINQMethodsListed.LINQOperationsMethods;


namespace LINQMethodsListed
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = Data.GetPeople();

            LINQManager.RunWhere(people);
            //LINQManager.RunSelect(people);  
            LINQManager.RunTake(people);
            //LINQManager.RunOrderBy(people);
            //LINQManager.RunUnion(people);
            //LINQManager.RunFirstOrDefault(people);
            //LINQManager.RunSingle(people);
            //LINQManager.RunSelectMany(people);

            
            Console.WriteLine("Programmet har avslutats.");
        }
    }
}
