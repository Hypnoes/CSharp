using System;
using System.Threading;

namespace ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(5);
            var r = new Rectangle(5, 10);
            Console.WriteLine(Convert.ToString(c.area()));
            Console.WriteLine(Convert.ToString(r.area()));
            Thread.Sleep(5000);
        }
    }
}
