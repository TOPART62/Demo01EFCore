using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRelationsBlog.Models
{
    internal class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime PublishedOn { get; set; } = DateTime.Now;
        public bool Archived { get; set; } = false;

        // Propriété du blog
        //[ForeignKey(nameof(Blog))] -- facultatif
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }  
    }
}
