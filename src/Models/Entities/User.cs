namespace eCommerce.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime DayJoined { get; set; }
        public DateTime Modified { get; set; }
        public Role Type { get; set; }
        public bool Deleted { get; set; }
        public Address Address { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
