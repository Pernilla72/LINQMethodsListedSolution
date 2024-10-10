using System.Linq;

namespace LINQMethodsListed
{
    public class Program
    {
        static void Main(string[] args)
        {

            var people = Data.GetPeople();

            WhereMethod();
            
        }

    }
}
