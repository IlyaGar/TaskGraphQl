namespace GraphQLAPI.Data.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public ICollection<User> Tasks { get; set; } = new List<User>();
    }
}
