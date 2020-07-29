using System;

namespace objectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            var tom = new Computer("grey");
            tom.Name = "Louis";
            Console.WriteLine(tom.Name);
        }
    }
}
