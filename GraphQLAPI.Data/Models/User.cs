namespace GraphQLAPI.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int UserRoleId { get; set; }

        public UserRole Role { get; set; } = new UserRole();
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
