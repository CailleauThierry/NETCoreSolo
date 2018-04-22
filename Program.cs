using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(ref a);
            Console.WriteLine("Returned value: {0}", a); //demonstrates passing value by Reference
        }
        static int Sqr(ref int x)
        {
            x =x*x;
            return x;
        }
    }
}
