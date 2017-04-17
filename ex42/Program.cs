using System;
using System.Collections.Generic;
using System.Threading;

namespace ex42
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new ListEx<int>() {1,2,2,3,3,3,4,4,4,4};
            print(l);
            Console.WriteLine();
            print(l.countAll());
            Thread.Sleep(5000);
        }

        static void print(IList<int> l) // 这里用int其实有个问题
        {
            foreach(var i in l)
            {
                Console.Write(i);
                Console.Write(' ');
            }
        }
    }
}
