using System;
using System.Collections.Generic;

namespace Blog.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        // Navigation property
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
