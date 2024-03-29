﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloRepeat.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } 
    }
}
