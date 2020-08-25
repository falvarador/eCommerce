namespace eCommerce.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public partial class User : SoftDeleted
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Role Type { get; set; }
        public Address Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
