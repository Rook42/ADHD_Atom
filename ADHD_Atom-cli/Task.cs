public class Task
{
    public enum TaskStatus
    {
        Open,
        InProgress,
        Completed
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }

    public Task(
        string title = "New Task",
        string description = "Task Description",
        TaskStatus status = TaskStatus.Open
    )
    {
        Title = title;
        Description = description;
        Status = status;
    }
}
