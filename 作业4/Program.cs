using System;
using System.Linq;

namespace 作业4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "3", "a", "8", "haha" };
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
            a.Reverse();
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
