using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The summation result is: {0}", Sum(5, 7));
        }
        static int Sum(int x, int y)
        {
            return x+y;
        }
    }
}
