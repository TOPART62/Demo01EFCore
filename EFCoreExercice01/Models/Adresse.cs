using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice01.Models
{
    internal class Adresse
    {
        [Key] 
        public int Id { get; set; }
        public string? NumeroVoie{ get; set; }
        public string? Complement{ get; set; }
        public string? IntituleVoie { get; set; }
        [Required]
        public string? Commune { get; set; }
        public int CodePostal { get; set; }
    }
}
