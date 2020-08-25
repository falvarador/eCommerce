namespace eCommerce.WebApi.Model
{
    public partial class Category : Auditable
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
