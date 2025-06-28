namespace GraphQLAPI.Data.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
