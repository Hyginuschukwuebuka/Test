using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("buka!");
            var john = new Person();
            john.firstName = "Derichman";
            john.lastName = "Eze";
            john.Introduce();
        }
    }
}