using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infrastructure.Models
{
    [Table("logs")]
    public class Log
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("lat")]
        public float Lat { get; set; }

        [Column("lng")]
        public float Lng { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [ForeignKey("Logs")]
        [Column("link_id")]
        public long LinkId { get; set; }

        [NotMapped]
        public Link Link { get; set; }
    }
}
