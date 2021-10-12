using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link5.Infra.Core.Models
{
    public class Log
    {
        public Log()
        {
        }

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
    }
}
