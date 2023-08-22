using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRelationsBlog.Models
{
    internal class Tag
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //public List<Blog> Blogs { get; set; }   
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();

    }
}
