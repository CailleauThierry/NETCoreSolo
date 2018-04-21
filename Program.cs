using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 42;
            string msg;
            if (age>18)
                msg = "Welcome in!";
            else
                msg = "Sorry";
            Console.WriteLine(msg);

            msg = (age>=18)? "Welcome in son!":"Sorry son!";
            Console.WriteLine(msg);
        }
    }
}
