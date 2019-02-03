using System;

namespace Class1CoderGirlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name_input = Console.ReadLine();
            string standardGreeting = ("Hello, " + name_input + ".");

            if (name_input == "Amar")
            {
                Console.WriteLine(standardGreeting + " I like your shoes.");
                Console.ReadLine(standardGreeting + " I like your shoes.");
                

            }
