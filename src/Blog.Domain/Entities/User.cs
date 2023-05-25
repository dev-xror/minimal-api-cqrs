namespace Blog.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }

        // Foreign Key
        public Guid RoleId { get; set; }

        // Navigation properties
        public Role? Role { get; set; }
        public UserProfile? UserProfile { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
