﻿

namespace Tecnoline.common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]

        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublisOn { get; set; }


    }
}
