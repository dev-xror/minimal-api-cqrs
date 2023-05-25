namespace Blog.Domain.Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        public string? AvatarUrl { get; set; }
        public string? SocialLinks { get; set; } // New property


        // Foreign Key
        public Guid UserId { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
