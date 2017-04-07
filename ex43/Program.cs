using System;
using System.Collections.Generic;
using System.Threading;

namespace ex43
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new ListEx<int>() {1,2,2,3,3,3,4,4,4,4};
            print(l);
            Console.WriteLine();
            var t1 = Test(l.sortCount);
            var t2 = Test(l.countAll);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Thread.Sleep(5000);
        }

        static void print(IList<int> l) // 这里用int其实有个问题
        {
            foreach(var i in l)
            {
                Console.Write(i);
                Console.Write(',');
            }
        }

        static int Test(Func<List<int>> t)
        {
            var start = DateTime.Now;
            t();
            var end = DateTime.Now;
            return (end - start).Milliseconds;
        }
    }
}
