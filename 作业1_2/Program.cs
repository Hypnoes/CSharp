using System;
using System.Threading;

namespace 作业1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var max = 0;
            while (input != "END")
            {
                var t = Convert.ToInt16(input);
                if (max < t)
                {
                    max = t;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine(max);
            Thread.Sleep(5000);
        }
    }
}
