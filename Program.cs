using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The largest number is: {0}", Max(5, 7));
        }
        static int Max(int a, int b)
        {
            if (a>b)
            {
                return a;  // DotNetCore requires those curly braces before the else is accepted
            }
            else
                return b;
        }
    }
}
