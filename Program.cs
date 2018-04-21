using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =0;
            while (num < 20)
            {
                if (num == 5)
                {
                    break;
                }

                Console.WriteLine(num);
                num++;
            }
        }
    }
}
