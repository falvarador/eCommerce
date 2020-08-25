namespace eCommerce.WebApi.Model
{
    using System.Collections.Generic;

    public partial class Product : Auditable
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public ICollection<Tag> Tags { get; set; } 
        public ICollection<Category> Categories { get; set; } 
        public ICollection<ProductDetail> ProductDetails { get; set; } 
    }
}
