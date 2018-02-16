using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskSecond.Models
{
    public class ViewModel
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public int? Pages { get; set; }

        public Genre Genre { get; set; }

        public string Publisher { get; set; }
        //public string AuthorName { get; set; }
        [UIHint("AuthorsEditor")]
        public IEnumerable<Author> Authors { get; set; }
        //public IQueryable<string> AuthorNames { get; set; }
    }
}