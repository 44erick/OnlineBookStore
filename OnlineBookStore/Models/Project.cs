using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    //database will use this model
    public class Project
    {
        //key means we don't put a key since computer will generate it
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        //regex code to make sure ISBN is valid
        [Required][RegularExpression(@"/^(?:ISBN(?:-1[03])?:?\s)?(?=[-0-9\s]{17}$|[-0-9X\s]{13}$|[0-9X]{10}$)(?:97[89][-\s]?)?[0-9]{1,5}[-\s]?(?:[0-9]+[-\s]?){2}[0-9X]$/", ErrorMessage = "ISBN must be in valid format XXX-XXXXXXXXXX")]
        public string Isbn { get; set; }
        [Required]
        public string Category { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int Pages { get; set; }

    }
}