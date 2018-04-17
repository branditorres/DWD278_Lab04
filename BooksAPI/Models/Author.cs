﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksAPI.Models
{
    public class Author
    {

        public int AuthorId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}