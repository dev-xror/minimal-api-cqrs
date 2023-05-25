using System;

namespace Blog.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }
        public DateTime PublishDate { get; set; }

        // Foreign Key
        public Guid PostId { get; set; }

        // Navigation property
        public Post? Post { get; set; }
    }
}
