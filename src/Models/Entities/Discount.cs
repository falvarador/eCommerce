namespace eCommerce.WebApi.Model
{
    using System;

    public partial class Discount : Auditable
    {
        public long DiscountId { get; set; }
        public string Code { get; set; }
        public float DiscountValue { get; set; }
        public int Quantity { get; set; }
        public DiscountType Type { get; set; }
        public DateTime Valid { get; set; }
    }
}
