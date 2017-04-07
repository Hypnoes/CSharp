using System;
using System.Threading;

namespace ex14
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
            Array.Reverse(a);
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
            Thread.Sleep(5000);
        }
    }
}
