namespace Blog.Domain.Entities
{
    public class PostStatus
    {
        public Guid Id { get; set; }
        public string? Status { get; set; }
        public string? Color { get; set; } // New property
        public string? Icon { get; set; } // New property

        // Navigation property
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
