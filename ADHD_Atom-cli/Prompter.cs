using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;

/*
* Controller for CLI UI
*/

// TODO: Activities/Prompts/Commands naming, use, and description need to be reworked.
// ... the relationship should be clarified between the three.
// ... this will help with Activity.None not mapping to a prompt,
// ... and some prompts not mapping to Commands strings. 
// IDEA: If Activity.None is just for Startup and error handling,
// ... then it should become Activity.Startup and Activity.Error.
// TODO: Activity.None > Activity.Startup & Activity.Error
namespace ADHD_Atom_cli
{
    public partial class Prompter
    {
        ApplicationStringStore str;
        Dictionary<Activity, Tuple<string, string>> prompts;
        public Prompter(ApplicationStringStore stringStore)
        {
            // Initialize the string store
            str = stringStore;

            // Map strings to their respective prompts
            // TODO: Tuple is probably the wrong substructure. Item1, Item2 aren't descriptive.
            prompts = new Dictionary<Activity, Tuple<string, string>>();
            foreach (Activity activity in (Activity[])Enum.GetValues(typeof(Activity)))
            {
                if (activity == Activity.None)
                    continue;
                else
                {
                    string name = str.GetString("Commands", activity.ToString(), "name"); // Refactor later for internationalization
                    string prompt = str.GetString("Commands", activity.ToString(), "prompt");
                    prompts.Add(activity, new Tuple<string, string>(name, prompt));
                }
            }
        }

        // Primary activity behavior loop for interactive use.
        public void ActivityLoop()
        {

            Activity activity = Activity.None;
            while (activity != Activity.Exit)
            {
                var response = "";
                // Startup
                if (activity == Activity.None)
                {
                    Console.WriteLine(str.GetString("UI", "Welcome"));
                    response = Console.ReadLine();
                }
                else // Prompt, get response string
                {
                    response = Prompt(prompts[activity].Item2);
                }

                // Attempt to parse response string to activity enum
                if (prompts.Values.Any(x => x.Item1 == response))
                {
                    activity = prompts.First(x => x.Value.Item1 == response).Key;
                }
                else // Invalid response: re-prompt
                {
                    Console.WriteLine(str.GetString("Help", "InvalidCommand"));
                    Console.WriteLine(str.GetString("UI", "HelpReminder"));
                    activity = Activity.None;
                }
                switch (activity)
                {
                    case Activity.Help:
                        Help();
                        break;
                    case Activity.Exit:
                        Console.WriteLine(str.GetString("UI", "Goodbye"));
                        break;
                    case Activity.Add:
                        Add();
                        break;
                    case Activity.Delete:
                        Delete();
                        break;
                    case Activity.Tasks:
                        Tasks();
                        break;
                    case Activity.Update:
                        Update();
                        break;
                    case Activity.Task:
                        Task();
                        break;
                    default:
                        // TODO: What should be done when an invalid activity is selected?
                        break;
                }
            }
        }

        // Displays a list of tasks.
        private void Tasks()
        {
            throw new NotImplementedException();
        }

        // Prompts for a task to display in more detail.
        private void Task()
        {
            throw new NotImplementedException();
        }

        // Prompts to add a task.
        private void Add()
        {
            throw new NotImplementedException();
        }

        // Prompts to update a task.
        private void Update()
        {
            throw new NotImplementedException();
        }

        // Prompts to delete a task.
        private void Delete()
        {
            throw new NotImplementedException();
        }

        // Prints the help menu.
        public void Help()
        {
            foreach (Activity activity in prompts.Keys)
            {
                string format = "{0}: {1}";
                string outLine = string.Format(format, prompts[activity].Item1, str.GetString("Commands", activity.ToString(), "description"));
                Console.WriteLine(outLine);
                Console.WriteLine();
            }
        }

        // Prompts the user with @message and returns the response.
        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

    }
}
