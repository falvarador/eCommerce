namespace eCommerce.WebApi.Model
{
    using System;

    public partial class Discount
    {
        public long DiscountId { get; set; }
        public string Name { get; set; }
        public float DiscountDiscount { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Valid { get; set; }
        public int Quantity { get; set; }
    }
}
