using System;
namespace task1.test2
{
    class program
    {
        public static void Main(string[] args)
        {
            Pair<String> pair = new Pair<string>("AN", "NGA");
            Console.WriteLine("({0}, {1})", pair.First, pair.Second);
            Console.ReadLine();
        }
    }
}

