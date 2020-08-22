namespace eCommerce.WebApi.Model
{
    public partial class OrderItem
    {
        public long OrdenItemId { get; set; }
        public long OrderId { get; set; }
        public long ProductDetail { get; set; }
        public int Quantity { get; set; }
    }
}
