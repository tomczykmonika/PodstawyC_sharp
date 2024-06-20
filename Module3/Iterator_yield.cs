using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module3
{
    public class Iterator_yield
    {
        public static IEnumerable<int> GetYieldedData()
        {
            // tak też można:
            // yield return 1;
            // yield return 2;
            // yield return 3;

            Console.WriteLine("YIELD start");

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"Get yield data element: {i}");
                yield return i;
                // istnieje również yield break;
                // np.
                // if (i % 3 == 0)
                // { yield break; }
            }

            Console.WriteLine("YIELD end");
        }

        public static IEnumerable<int> GetListData()
        {
            Console.WriteLine("LIST start");
            var result = new List<int>();
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"Get list data element: {i}");
                result.Add(i);
            }
            Console.WriteLine("LIST end");
            return result;
        }
        public static void YieldExample()
        {
            /*
            W przypadku listy najpierw musi zostać pobrana cała lista i dopiero następuje jej iteracja.
            W przypadku yield dzieje się to przy każdym elemencie.
             */
            var yieldedData = GetYieldedData();
            foreach (int i in yieldedData)
            {
                Console.WriteLine(i);
                //dodatkowy warunek - można zauwżyć, że w przypadku yield
                //nie pobieramy całej listy bez sensu 
                if (i > 5)
                {
                    break;
                }
            }
            var listData = GetListData();
            foreach (int i in listData)
            {
                Console.WriteLine(i);
                //dodatkowy warunek - można zauwżyć, że w przypadku yield
                //nie pobieramy całej listy bez sensu 
                if (i > 5)
                {
                    break;
                }
            }

        }
    }
}
