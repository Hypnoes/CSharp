using System;
using System.Threading;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine() == "How is the weather?")
            {
                Console.WriteLine("It's fine, if you can see the sun or the moon or stars.");
            }
            else if (Console.ReadLine() == "......")
            {
                Console.WriteLine("88");
            }
            else
            {
                Console.WriteLine("再见。");
            }
            Thread.Sleep(5000);
        }
    }
}
