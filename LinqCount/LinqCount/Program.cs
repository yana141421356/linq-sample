using System;
using System.Collections;
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
            // http://smdn.jp/programming/netfx/tips/implement_linq/
            IEnumerable<int> source = new List<int>() { 0, 1, 2, 3, 4 };
            //Console.WriteLine(source.Count());
            int count = 0;
            foreach (var e in source)
            {
                count++;
            }
            Console.WriteLine(Count(source));
            
            Console.ReadLine();
        }

        static int Count<TSource>(IEnumerable<TSource> source)
        {
            int count = 0;

            foreach (var e in source)
            {
                count++;
            }
            return count;
        }

        public class Collection<T> : IEnumerable<T>
        {
            List<T> list;

            public Collection()
            {
                list = new List<T>();
            }

            public void AddObject(T item)
            {
                list.Add(item);
            }

            public IEnumerator<T> GetEnumerator()
            {
                for( int i = 0; i < 10; i++)
                {
                    if ( i % 2 == 0)
                    {
                        yield return list[i];
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
