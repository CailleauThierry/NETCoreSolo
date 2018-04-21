using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y=");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum;
                sum = x+y;
                Console.WriteLine("Result: {0}", arg0: sum);
            } while (true);
        }
    }
}
