using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFCore.Models
{
    internal class Student
    {
        [Key] // data annotation => comportement par défaut EFCore (facultatif dans le cas ou on nomme <Id>)
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set;}
        public string? Phone{ get; set; }
        public string? Email { get; set; }

    }
}
