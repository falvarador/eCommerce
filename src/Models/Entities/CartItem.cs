namespace eCommerce.WebApi.Model
{
    using System;

    public partial class CartItem
    {
        public long CartItemId { get; set; }
        public long UserId { get; set; }
        public long ProductsDetail { get; set; }
        public bool SavedForLater { get; set; }
        public long Quantity { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
