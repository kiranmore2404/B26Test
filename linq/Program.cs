// Import necessary namespaces
using System; // Provides fundamental classes and base types
using System.Linq; // For LINQ queries

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "kiran", "samiksha", "kishor", "pankaj", "Abhi" };

            // Corrected LINQ query using Length as a property
            var a = from name in arr
                    where name.Length == "kiran".Length // Compare lengths correctly
                    select name;

            // Output the filtered results
            foreach (string i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
