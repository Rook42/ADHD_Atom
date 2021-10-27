using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;

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


        public void ActivityLoop()
        {

            Activity activity = Activity.None;
            while (activity != Activity.Exit)
            {
                var response = "";
                // Print the prompt
                if (activity == Activity.None)
                    response = Console.ReadLine();
                else
                {
                    response = Prompt(prompts[activity].Item2);
                }
                if (prompts.Values.Any(x => x.Item1 == response))
                {
                    activity = prompts.First(x => x.Value.Item1 == response).Key;
                }
                else
                {
                    switch (activity)
                    {
                        case Activity.Help:
                            Help();
                            break;
                        case Activity.Exit:
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
                            Console.WriteLine(str.GetString("Help", "InvalidCommand"));
                            Console.WriteLine(str.GetString("UI", "HelpReminder"));
                            break;
                    }
                }
            }
        }

        private void Tasks()
        {
            throw new NotImplementedException();
        }

        private void Task()
        {
            throw new NotImplementedException();
        }

        private void Add()
        {
            throw new NotImplementedException();
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        private void Delete()
        {
            throw new NotImplementedException();
        }

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
        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

    }
}
