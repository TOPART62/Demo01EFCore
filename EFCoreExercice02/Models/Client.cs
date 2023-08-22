using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Models
{
    [Table("client")]
    internal class Client
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("last_name")]
        public string? Lastname { get; set; }
        [Required]
        [Column("first_name")]
        public string? Firstname { get; set; }
        [Column("tel")]
        [Required]
        public string? Tel { get; set; }
    }
}
