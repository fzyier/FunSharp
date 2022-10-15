using System;

namespace FunSharp
{
    class Program
    {
        static string Likes(string[] name) => name.Length switch
            {
                0 => "no one likes this",
                1 => $"{name[0]} likes this",
                2 => $"{name[0]} and {name[1]} like this",
                3 => $"{name[0]}, {name[1]} and {name[2]} like this",
                _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this"
            };
        static void Main()
        {
            string[] name = new string[] {""};

            name = new string[] { "Peter" };
            Console.WriteLine(Likes(name));

            name = new string[] { "Jacob", "Alex" };
            Console.WriteLine(Likes(name));

            name = new string[] { "Max", "John", "Mark" };
            Console.WriteLine(Likes(name));

            name = new string[] { "Alex", "Jacob", "Mark", "Max" };
            Console.WriteLine(Likes(name));
        }
    }
}