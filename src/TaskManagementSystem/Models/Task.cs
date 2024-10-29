namespace TaskManagementSystem.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; } 
        public int Priority { get; set; } 
        public List<Task> Subtasks { get; set; } = new List<Task>();
        public List<int> DependencyIds { get; set; } = new List<int>();
    }
}
