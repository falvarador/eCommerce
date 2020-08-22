namespace eCommerce.WebApi.Infraestructure
{
    using eCommerce.WebApi.Model;
    using Microsoft.EntityFrameworkCore;

    public class InfraestructureContext : DbContext 
    {
        #region Configuration

        public InfraestructureContext(DbContextOptions<InfraestructureContext> options)
            : base(options)
        {
            
        }   

        #endregion

        #region Tables

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new MovieGenderMapping());
            // modelBuilder.Entity<MovieActor>().HasKey(x => new { x.MovieId, x.PersonId });

            base.OnModelCreating(modelBuilder);
        }

        // public DbSet<Movie> Movies { get; set; }
        
        // public DbSet<Gender> Genders { get; set; }

        // public DbSet<Person> People { get; set; }

        // public DbSet<MovieGender> MoviesGenders { get; set; }

        // public DbSet<MovieActor> MoviesActors { get; set; }

        #endregion
    }
}
