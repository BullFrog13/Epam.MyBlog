using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Tag
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
