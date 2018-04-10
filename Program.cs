using System;

namespace NETCoreSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter a value for age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value 16 or 42 or 70 will result in non-default case. Entered value was: {0}", age);

            switch (age)
            {
                case 16:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }
        }
    }
}
