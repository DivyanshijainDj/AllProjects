using System;
using System.Collections.Generic;

namespace APIApps.models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public decimal? BasePrice { get; set; }
    }
}
