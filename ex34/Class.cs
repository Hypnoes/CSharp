using System;

namespace ex34
{
    class Book : BClass
    {
        public Book() { Console.Beep(); }
        public Book(int id, string n)
        {
            name = n;
            ID = id;
        }
    }
    
    class Reader : BClass
    {
        public Book[] b = new Book[5];
        public int num = 0;

        public void borrow(int id)
        {
            if (num >= 5)
            {
                return;
            }
            else
            {
                b[num] = Library.findBook(id);
                num = num + 1;
            }
        }

        public Reader() { Console.Beep(); }
        public Reader(int id, string n)
        {
            ID = id;
            name = n;
        }
    }

    class BClass
    {
        public string name;
        public int ID;

        public string toString()
        {
            return name + string.Format("({0})", ID.ToString());
        }
    }

    static class Library
    {
        static public Book[] l = new Book[10] 
        {
            new Book(100, "C语言"),
            new Book(110, "数据结构"),
            new Book(210, "软件工程"),
            new Book(208, "操作系统"),
            new Book(000, ""),
            new Book(000, ""),
            new Book(000, ""),
            new Book(000, ""),
            new Book(000, ""),
            new Book(000, ""),
        };
        static public void addBook() { }
        static public void rmvBook() { }
        static public Book findBook(int id)
        {
            foreach (var item in l)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return new Book(0, "查无此书");
        }
    }
}
