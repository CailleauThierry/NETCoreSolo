using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
        }
        int Sqr(int x)
        {
            int result = x*x;
            return result;
        }
        static void SayHi()
        {
            Console.WriteLine("Hello!");
        }

    }
}
