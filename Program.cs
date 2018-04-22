using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            GetValues(out a,out b);
            Console.WriteLine("Returned value\na: {0}\nand\nb: {1}", a, b); //demonstrates passing value by Output
        }
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
    }
}
