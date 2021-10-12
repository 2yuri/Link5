using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infra.Core.Models
{
    public class Link
    {
        public Link()
        {
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column("title")]
        public string Title { get; set; }


        [Column("url")]
        public string Url { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public long UserId { get; set; }
    }
}
