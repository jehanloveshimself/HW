using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name;
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
            //Console.WriteLine("What is your age ?");
            //int age = Console.ReadLine();
            Console.WriteLine("Good morning");
            if (name == "Arif" || name == "Mehedi") Console.WriteLine("You are an AP!");
            else if (name == "Sanwar") Console.WriteLine("You are an AGM!");
            else if (name == "Shahin") Console.WriteLine("You are a Driver!");
            else if (name == "Jalal") Console.WriteLine("You are an MLSS!");
            else if (name == "Khaled") Console.WriteLine("You are an DM!");
            else if (name == "Rafiqul" || name == "Devashis") Console.WriteLine("You are a JO!");
            else if (name == "Shahriar" || name == "Sonjoy") Console.WriteLine("You are an SA!");
            else if (name == "Amdadul") Console.WriteLine("You are an SP!");
            else if (name == "Masum" || name == "Mobassher" || name == "Tonmoy" || name == "Nahid") Console.WriteLine("You are a CS!");
            else if (name == "Jahangir" || name == "Mamun" || name == "Ibrahim" || name == "Bulbul") Console.WriteLine("You are a CO!");
            else Console.WriteLine("You are an imposter!");

        }
    }
}
