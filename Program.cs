using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.5;
            Print(x);
            Print(y);
        }        
        static void Print(int a)
        {
            Console.WriteLine("Prints int a:"+a);
        }
            static void Print(double a)
        {
            Console.WriteLine("Prints int a:"+a);
        }
    }
}
