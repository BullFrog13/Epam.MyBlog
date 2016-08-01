using System;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Account
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Notification { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime Date { get; set; }
    }
}
