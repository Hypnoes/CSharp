﻿using System;
using System.Threading;

namespace ex21
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
            Thread.Sleep(5000);
        }
    }
}