using System;

namespace FinanceTaskHelper.Classes
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
        public int Priority { get; set; }

        public TaskItem(int id, string title, DateTime deadline, bool isDone, int priority)
        {
            Id = id;
            Title = title;
            Deadline = deadline;
            IsDone = isDone;
            Priority = priority;
        }

        public TaskItem() { }
    }
}