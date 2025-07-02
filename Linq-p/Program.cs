using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var  lstnumber = new List<int>() { 12,23,12,12,13,32,11,11,12,56,7,89,};
            //var distnict  = lstnumber.Distinct().ToList();
            var lstnumber = new List<int>() { 1,2,3,4,5,6,7 };
            var lempty = new List<int>() { };
            //var leven = lstnumber.Where(a => a % 2== 0).ToList();
            //var lodd = lstnumber.Where(a => a%2 != 0).ToList();
            //var asc = lstnumber.OrderBy(x => x).ToList(); ;
            //var dec = lstnumber.OrderByDescending(x => x).ToList();
            var first  = lstnumber.First();
            //var firstemprt = lempty.First();
            lstnumber.RemoveAt(0);
            var li  = lstnumber.Count();



        }
    }
}
