using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCount
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> source = new List<int>() { 0, 1, 2, 3, 4 };
            Console.WriteLine(source.Count());
            Console.ReadLine();
        }
    }
}
