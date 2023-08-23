using Microsoft.EntityFrameworkCore;
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
        [Comment("-- id du client --")]
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Comment("-- nom du client --")]
        [Required]
        [Column("last_name")]
        public string? Lastname { get; set; }
        [Comment("-- prenom du client --")]
        [Required]
        [Column("first_name")]
        public string? Firstname { get; set; }
        [Comment("-- telephone du client --")]
        [Column("tel")]
        [Required]
        public string? Tel { get; set; }
    }
}
