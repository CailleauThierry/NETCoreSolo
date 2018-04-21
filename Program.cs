using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=10; x<30; x+=3)
            {
                Console.WriteLine(format: "Value of x is: {0}", arg0: x);
            }
            for(int x=10; x>1; x-=2)
            {
                Console.WriteLine(format: "Value of x is: {0}", arg0: x);
            }
        }
    }
}
