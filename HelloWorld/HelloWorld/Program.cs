using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Faize!");

            int age = 29;

            Console.WriteLine("My age is " + age);

            int favoriteNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("My favorite number is " + favoriteNumber+".");
        }
    }
}
