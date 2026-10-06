namespace TaskMangerApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
