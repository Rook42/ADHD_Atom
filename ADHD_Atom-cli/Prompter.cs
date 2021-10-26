using System.Collections.Generic;
using System.IO;
using System;
using str = ADHD_Atom_cli.ApplicationStrings;

namespace ADHD_Atom_cli
{
    public partial class Prompter
    {

        static Dictionary<Activity, string> activityDict = new Dictionary<Activity, string>
        {
            {Activity.Help, str.HelpCommand},
            {Activity.Exit, str.ExitCommand},
            {Activity.Task, str.TaskCommand},
            {Activity.Tasks, str.TasksCommand},
            {Activity.Add, str.AddTaskCommand},
            {Activity.Update, str.UpdateTaskCommand},
            {Activity.Delete, str.DeleteTaskCommand}
        };

        public static void ActivityLoop()
        {


            Activity activity = Activity.Help;
            bool exitFlag = false;
            while (!exitFlag)
            {
                var response = Prompt(activityDict[activity]);
                if (activityDict.ContainsValue(response))
                {
                    activity = (Activity)Enum.Parse(typeof(Activity), response);
                }
                else
                {
                    switch (activity)
                    {
                        case Activity.Help:
                            Help();
                            break;
                        case Activity.Exit:
                            exitFlag = true;
                            break;
                        case Activity.Task:
                            Task();
                            break;
                        case Activity.Tasks:
                            Tasks();
                            break;
                        case Activity.Add:
                            Add();
                            break;
                        case Activity.Update:
                            Update();
                            break;
                        case Activity.Delete:
                            Delete();
                            break;
                    }
                }
            }
        }

        public static void Help()
        {
            foreach (Activity activity in Enum.GetValues(typeof(Activity)))
            {
                Console.WriteLine(activityDict[activity]);
                Console.WriteLine()
            }
        }

        public static void Task()
        {
            Console.WriteLine(str.TaskMessage);
        }

        public static void Tasks()
        {
            Console.WriteLine(str.TasksMessage);
        }

        public static void Add()
        {
            Console.WriteLine(str.AddTaskMessage);
        }

        public static void Update()
        {
            Console.WriteLine(str.UpdateTaskMessage);
        }

        public static void Delete()
        {
            Console.WriteLine(str.DeleteTaskMessage);
        }

        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}