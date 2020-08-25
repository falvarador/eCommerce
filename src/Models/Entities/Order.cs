namespace eCommerce.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Order
    {
        public long OrderId { get; set; }
        public string Status { get; set; }
        public double Amount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ICollection<Discount> Discounts { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
