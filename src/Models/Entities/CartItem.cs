namespace eCommerce.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public partial class CartItem
    {
        public long CartItemId { get; set; }
        public bool SavedForLater { get; set; }
        public long Quantity { get; set; }
        public DateTime Created { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
