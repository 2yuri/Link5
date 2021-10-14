using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infrastructure.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir mais do que 3 caracteres")]
        [Column("full_name")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(6, ErrorMessage = "Este campo deve possuir mais do que 6 caracteres")]
        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [DefaultValue(false)]
        [Column("verified")]
        public bool Verified { get; set; }

        [DefaultValue(true)]
        [Column("active")]
        public bool Active { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("Uudated_at")]
        public DateTime UpdatedAt { get; set; }

        [NotMapped]
        public List<Link> Links { get; set; }

        [NotMapped]
        public List<Hash> Hashes { get; set; }

        [NotMapped]
        public Layout Layout { get; set; }
    }
}
