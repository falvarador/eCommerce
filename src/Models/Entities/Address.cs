namespace eCommerce.WebApi.Model
{
    public partial class Address
    {
        public long AddressId { get; set; }
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }
}
