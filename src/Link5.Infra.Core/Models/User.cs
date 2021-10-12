using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infra.Core.Models
{
    public class User
    {
        public User()
        {
        }

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
        [Column("activated")]
        public bool Activated { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("Uudated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
