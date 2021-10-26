using System;
using str = ADHD_Atom_cli.ApplicationStrings;

namespace ADHD_Atom_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(str.Welcome);

            Prompter.ActivityLoop();

            Console.WriteLine(str.Goodbye);

        }
    }
}
