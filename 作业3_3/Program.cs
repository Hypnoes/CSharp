using System;
using System.Threading;

namespace 作业3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Reader(1234, "王华");
            var r2 = new Reader(2600, "李兵");

            r1.borrow(100);
            r1.borrow(110);
            r1.borrow(210);
            r2.borrow(208);

            outPut(r1);
            outPut(r2);
            Thread.Sleep(5000);
        }

        static void outPut(Reader r)
        {
            Console.WriteLine("读者" + r.toString() + "所借的图书:");
            foreach (var i in r.b)
            {
                var d = 1;
                Console.WriteLine("\t" + string.Format("{0}:", d) + i.toString());
            }
        }
    }
}
