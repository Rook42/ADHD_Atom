using System.IO;
using System;

namespace ADHD_Atom_cli
{
    public class Prompter
    {

        public static string Prompt(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}