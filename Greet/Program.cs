using System;

namespace Greet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Greet(string name)
        {
            string greeting; 

            if (name.Equals(""))
            {
                greeting = "Hello, my friend";
            }
            else if (name.ToUpper().Equals(name))
            {
                greeting = $"HELLO {name}!";
            }
            else
            {
                greeting = $"Hello, {name}";
            }

            return greeting;
        }
    }
}
