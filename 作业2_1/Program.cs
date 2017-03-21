using System;

namespace 作业2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p_c = new Chinese();
            var p_a = new Americans();
            Console.WriteLine("===================");
            p_c.hi();
            p_a.hi();
        }
    }
}
