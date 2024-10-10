using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethodsListed
{
    public class LINQManager
    {
        //Alla kända LINQ-mtoder testas nedan: 
        ///Filtering Methods:
        //1. `Where`
        static IEnumerable<Person> WhereMethod(IEnumerable<Person> people)
        {
            return people.Where(p => p.Age > 30);
        }

        //2. `Distinct`

        //3. `DistinctBy` (nyare)

        //4. `Except`

        //5. `ExceptBy` (nyare)

        //6. `Intersect`

        //7. `IntersectBy` (nyare)

        //8. `Skip`

        //9. `SkipWhile`

        //10. `Take`

        //11. `TakeWhile`

        //12. `OfType`
    }
}
