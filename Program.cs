using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(6);
        }        
        static void DrawPyramid(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = i; j < height; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=2*i-1; k++)
                {
                    Console.Write("*"+"");
                }
                Console.WriteLine();
            }
        }
    }
}
