namespace eCommerce.WebApi.Model
{
    using System;

    public partial class Order
    {
        public long OrderId { get; set; }
        public long UserId { get; set; }
        public long AddressId { get; set; }
        public long DiscountId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; }
        public double Amount { get; set; }
    }
}
