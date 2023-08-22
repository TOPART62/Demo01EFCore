using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRelationsBlog.Models
{
    internal class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string? Name { get; set; }
        [Required]
        public string? SiteUri { get; set; }
        public BlogHeader? Header { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        //public List<Tag> Tags { get; set; } = new List<Tag>();
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();

    }
}
