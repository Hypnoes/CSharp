using System;
using System.Collections.Generic;

namespace ex43
{
    class ListEx<T> : List<T>
    {
        public List<int> sortCount()
        {
            var a = new List<int>();
            var b = this;
            this.Sort();
            for(var i = 0; i < this.Count; i++)
            {
                var s = b.FindAll(x => x.Equals(this[i])).Count;
                a.Add(s);
                b.RemoveRange(0,s);
            }
            return a;
        }

        public List<int> countAll()
        {
            var a = new List<int>();
            var b = this;
            foreach(var i in this)
            {
                var s = b.FindAll(x => x.Equals(i)).Count;
                a.Add(s);
                b.RemoveAll(x => x.Equals(i));
            }
            return a;
        }
    }

    class Type : IComparable
    {
        public int CompareTo(object o)
        {
            return 0;
        }
    }
}