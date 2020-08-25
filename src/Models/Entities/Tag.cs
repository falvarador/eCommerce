namespace eCommerce.WebApi.Model
{
    public partial class Tag : Auditable
    {
        public long TagId { get; set; }
        public string TagName { get; set; }
    }
}
