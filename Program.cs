using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(6));
        }        
        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num-1);
        }
    }
}
