using System;

namespace 作业
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = Convert.ToInt16(Console.ReadLine());
            var i2 = Convert.ToInt16(Console.ReadLine());
            if (i1 > 0 && i2 > 0)
            {
                Console.WriteLine(i1 + 1 + i2);
            }
            else if (i1 < 0 && i2 < 0)
            {
                Console.WriteLine((i1 - 10) * i2);
            }
            else if (i1 == 0 && i2 == 0)
            {
                Console.WriteLine("ERROR.");
            }
            else
            {
                Console.WriteLine(Math.Abs(i1 * i2));
            }
            
        }
    }
}
