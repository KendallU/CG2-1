using System;

namespace CG2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            Console.Write("Type your name here:");
            string myFirstname;
            myFirstname = Console.ReadLine();
            Console.WriteLine("Hello," + myFirstname);
            Console.ReadLine();

        }
    }
}
