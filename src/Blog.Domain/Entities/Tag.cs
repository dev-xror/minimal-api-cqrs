namespace Blog.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        // Navigation property
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
