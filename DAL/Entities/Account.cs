using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Account
    {
        [Required]
        public int ID { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        public string Age { get; set; }


        [Required]
        public string Gender { get; set; }


        [Required]
        public string Telephone { get; set; }


        [Required]
        public string Notification { get; set; }


        [Required]
        public string Password { get; set; }

        public DateTime Date { get; set; }
    }
}
