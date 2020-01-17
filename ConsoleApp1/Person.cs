using System;

namespace ConsoleApp1
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }

    }
}