

using System;

namespace ProvidenceBooks.Shared
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300X300";
        public int Price { get; set; }
        public int OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
    }
}

