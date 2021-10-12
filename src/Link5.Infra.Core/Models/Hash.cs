using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infra.Core.Models
{
    public class Hash
    {
        public Hash()
        {
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("hash")]
        public Guid hash { get; set; }


        [Column("expires_at")]
        public DateTime ExpiresAt { get; set; }


        [ForeignKey("User")]
        [Column("user_id")]
        public long UserId { get; set; }

    }
}
