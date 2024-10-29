namespace TaskManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<int> AssignedTaskIds { get; set; } = new List<int>();
    }
}
