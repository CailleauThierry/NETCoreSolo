using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            // Condition evaluated after increment has happended, this control loop runs 5 times
            while(++num < 6)
                Console.WriteLine(num);
            num = 0;
            // Condition evaluated before increment explained why it runs 6 times  
            while(num++ < 6)
                Console.WriteLine(num);
        }
    }
}
