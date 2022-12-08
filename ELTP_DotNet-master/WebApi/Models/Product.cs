using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Product
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int SubCatId { get; set; }
        public int CategoryId { get; set; }
        public int ManuId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
