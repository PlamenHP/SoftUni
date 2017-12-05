﻿using System.ComponentModel.DataAnnotations;
using static BookShop.Data.DataConstants;

namespace BookShop.Data.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AuthornameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AuthornameMaxLength)]
        public string LastName { get; set; }
    }
}
