using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Area(h:3,w:2);
            Console.WriteLine("width time height: {0}", res);
        }
        static int Area(int w, int h)
        {
            return w * h;
        }
    }
}
