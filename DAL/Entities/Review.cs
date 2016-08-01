using System;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Review
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
