using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write(" type \"exit\" to quit or x=");
                string val1 = Console.ReadLine();
                if(val1 == "exit")
                break;
                int x = Convert.ToInt32(val1);

                Console.Write("y=");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum;
                sum = x+y;
                Console.WriteLine("Result: {0}", arg0: sum);
            } while (true);
        }
    }
}
