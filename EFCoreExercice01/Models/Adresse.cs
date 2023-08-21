using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice01.Models
{
    internal class Adresse
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("numero_voie")]
        public string? NumeroVoie{ get; set; }
        [Column("complement")]
        public string? Complement{ get; set; }
        [Required]
        [Column("intitule_voie")]
        [StringLength(50, ErrorMessage = "intitule_voie cannot exceed 50 characters ")]
        //[MaxLength(50, ErrorMessage = "intitule_voie cannot exceed 50 characters ! ")]
        public string? IntituleVoie { get; set; }
        [Required]
        [Column("commune")]
        public string? Commune { get; set; }
        [Required]
        [Column("code_postal")]
        [Range(00000,99999, ErrorMessage = "code_postal between 00000 and 99999")]
        public int CodePostal { get; set; }
    }
}
