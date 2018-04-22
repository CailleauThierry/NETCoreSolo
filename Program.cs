using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.5;
            string txt = "Your variable is";
            Print(x);
            Print(y);
            Print(txt, 5.6);
        }        
        static void Print(int a)
        {
            Console.WriteLine("Prints int a:"+a);
        }
        static void Print(double a)
        {
            Console.WriteLine("Prints int a:"+a);
        }
        static void Print(string label, double a)
        {
            Console.WriteLine(label+": "+a);
        }
    }
}
