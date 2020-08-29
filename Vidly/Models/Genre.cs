﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        [Required]
        public byte Id { get; set; }

        [Display(Name = "Movie Genre")]
        public string Name { get; set; }
    }
}