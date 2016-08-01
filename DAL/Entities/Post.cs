using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Post
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
