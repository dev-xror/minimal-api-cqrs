namespace Blog.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        // Navigation property
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
