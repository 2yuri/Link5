using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infrastructure.Models
{
    [Table("layouts")]
    public class Layout
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("logo_negative")]
        public bool LogoNegative { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public long UserId { get; set; }

        [NotMapped]
        public User User { get; set; }
    }
}
