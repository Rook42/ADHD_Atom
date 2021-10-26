
namespace ADHD_Atom_cli
{
    // Strings depot for the (CLI) application.
    // Idea: Group command strings for simple help text generation.
    public static class ApplicationStrings
    {
        public const string AppName = "ADHD Atom";
        public const string Welcome = "Welcome to " + AppName + "!";
        public const string Goodbye = "Goodbye!";
        public const string Help = "Type 'help' to see a list of available commands, or 'exit' to exit.";
        public const string HelpCommand = "help";
        public const string HelpCommandDescription = "Displays a list of available commands.";
        public const string ExitCommand = "exit";
        public const string ExitCommandDescription = "Exits the application.";
        public const string TasksCommand = "tasks";
        public const string TasksCommandDescription = "Displays a list of tasks.";
        public const string TaskCommand = "task";
        public const string TaskCommandDescription = "Displays a task.";
        public const string AddTaskCommand = "add";
        public const string AddTaskCommandDescription = "Adds a task.";
        public const string UpdateTaskCommand = "update";
        public const string UpdateTaskCommandDescription = "Updates a task.";
        public const string DeleteTaskCommand = "delete";
        public const string DeleteTaskCommandDescription = "Deletes a task.";

        public const string TaskTitleParameter = "title";
        public const string TaskTitleParameterDescription = "The title of the task.";
        public const string TaskTitleParameterPrompt = "Title: ";
        public const string TaskDescriptionParameter = "description";
        public const string TaskDescriptionParameterDescription = "The description of the task.";
        public const string TaskDescriptionParameterPrompt = "Description: ";
        public const string TaskStatusParameter = "status";
        public const string TaskStatusParameterDescription = "The status of the task.";
        public const string TaskStatusParameterPrompt = "Status: ";
    }
}