using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine("Returned value: {0}", a); //demonstrates that only the vlaue of "a" is being used
        }
        static int Sqr(int x)
        {
            return x * x;
        }
    }
}
