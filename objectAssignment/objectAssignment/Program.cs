using System;

namespace objectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            var tom = new Male("grey");
            tom.Name = "Louis";
            Console.WriteLine(tom.Name);
        }
    }
}
