namespace Blog.Domain.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime PublishDate { get; set; }

        // Foreign Key
        public Guid PostStatusId { get; set; }

        // Navigation property
        public PostStatus? PostStatus { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}