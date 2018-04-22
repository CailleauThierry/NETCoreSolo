using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = Sum(5, 7);
            Console.WriteLine("The summation result is: {0}", result);
        }
        static int Sum(int x, int y)
        {
            return x+y;
        }
    }
}
