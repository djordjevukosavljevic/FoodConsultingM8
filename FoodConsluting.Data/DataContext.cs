using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }
   
        DbSet<Standard> Standards { get; set; }
        DbSet<Review> Reviews {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Review>();


        }


    }
}