namespace eCommerce.WebApi.Infraestructure
{
    using eCommerce.WebApi.Model;
    using Microsoft.EntityFrameworkCore;

    public class InfraestructureContext : DbContext 
    {
        public InfraestructureContext(DbContextOptions<InfraestructureContext> options)
            : base(options)
        { }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new MovieGenderMapping());
            // modelBuilder.Entity<MovieActor>().HasKey(x => new { x.MovieId, x.PersonId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
