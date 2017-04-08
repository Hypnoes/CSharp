using System;
using System.IO;

namespace ex51
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = args[0];
            string path2 = args[1];
            try
            {
                string p2 = File.ReadAllText(path2);
                File.AppendAllText(path1, p2);
            }
            catch (System.Exception)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
