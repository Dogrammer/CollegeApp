using System;

namespace College.Model.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}