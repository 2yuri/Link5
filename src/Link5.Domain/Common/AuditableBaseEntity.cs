using System;
namespace Link5.Domain.Common
{
    public class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
