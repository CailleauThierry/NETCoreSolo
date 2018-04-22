using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 8;
            SayHi();
            Console.WriteLine("Result from squaring y is: {0}",Sqr(y));
        }
        static int Sqr(int x)
        {
            int result = x*x;
            return result;
        }
        static void SayHi() => Console.WriteLine("Hello!");

    }
}
