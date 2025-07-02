using System;
using System.Linq;

namespace LinqFirstLec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 1, 2, 3, 4, 5, 6 };
            var k = from i 
                    in ages 
                    where i>1 select i;
            foreach (var age in k) { 
                Console.WriteLine(age);

            }
            Console.ReadKey();




        }
    }
}
