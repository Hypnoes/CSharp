using System;
using System.Threading;

namespace 作业2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Car("A", "B", "red", 4, 260);
            var c2 = new Car("X", "Y", "black", 2, 340);
            c1.speedUp();
            c1.speedDown();
            c2.speedUp();
            c2.speedDown();
            Console.WriteLine("...");
            Thread.Sleep(5000);
            
        }
    }
}
