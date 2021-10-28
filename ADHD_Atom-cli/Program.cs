using System;
namespace ADHD_Atom_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationStringStore str = new ApplicationStringStore();
            Prompter prompter = new Prompter(str);
            prompter.ActivityLoop();
        }
    }
}
