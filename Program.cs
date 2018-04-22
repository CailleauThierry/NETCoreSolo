using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With a default power of 2 the result is: {0}", Pow(4));
            Console.WriteLine("With a power of 2 the result is: {0}", Pow(4,2));
            Console.WriteLine("With a power of 4 the result is: {0}", Pow(4,4));
        }
        static int Pow(int x, int y=2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
