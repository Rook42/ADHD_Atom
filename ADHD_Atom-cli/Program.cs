using System;
namespace ADHD_Atom_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationStringStore str = new ApplicationStringStore();
            Console.WriteLine(str.GetString("UI", "Welcome"));
            Prompter prompter = new Prompter(str);
            prompter.ActivityLoop();
            Console.WriteLine(str.GetString("UI", "Goodbye"));
        }
    }
}
