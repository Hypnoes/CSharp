﻿using System;

namespace 作业2_1
{
    class Person
    {
        public virtual void hi() { }
    }

    class Americans : Person
    {
        public override void hi()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Chinese : Person
    {
        public override void hi()
        {
            Console.WriteLine("你好!");
        }
    }
}
