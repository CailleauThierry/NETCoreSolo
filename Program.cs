using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            // runs 5 times pre increments, condition evaluated after increment has happended
            while(++num < 6)
                Console.WriteLine(num);
            num = 0;
            // runs 6 times post increment   
            while(num++ < 6)
                Console.WriteLine(num);
        }
    }
}
