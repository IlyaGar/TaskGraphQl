namespace GraphQLAPI.Data.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }    
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int StatusId { get; set; }
        public Status Status { get; set; } = null!;

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; } = null!;

        //public Guid? AssignedToId { get; set; }
        //public User? AssignedTo { get; set; }
    }
}
