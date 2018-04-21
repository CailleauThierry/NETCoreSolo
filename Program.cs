using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            for(; x<30; x+=3)
            {
                Console.WriteLine(format: "Value of x is: {0}", arg0: x);
            }
            x=10;
            for(; x>1; x-=2)
            {
                Console.WriteLine(format: "Value of x is: {0}", arg0: x);
                x-=2;
            }
        }
    }
}
