using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace TaskSecond.Models
{
    public class Author
    {
        public Author()
        {

        }
        [Required]
        public int AuthorId { get; set; }

        [Display(Name = "Author Name")]
        [MaxLength(100, ErrorMessage = "Author Name must be 100 characters or less"), MinLength(5)]
        public string AuthorName { get; set; }

        public int BookId { get; set; }

        [Display(Name = "Book(s)")]
        [JsonIgnore]
        public virtual ICollection<Book> Book { get; set; }


    }
}