using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskSecond.Models
{
    public class Book
    {
        public Book()
        {

        }
        [Required]
        public int BookId { get; set; }

        [Display(Name = "Book Name")]
        [MaxLength(100, ErrorMessage = "Book Name must be 100 characters or less"), MinLength(5)]
        public string BookName { get; set; }

        public int? Pages { get; set; }

        public Genre Genre { get; set; }

        public string Publisher { get; set; }
        [JsonIgnore]
        public virtual ICollection<Author> Authors { get; set; }


    }
}