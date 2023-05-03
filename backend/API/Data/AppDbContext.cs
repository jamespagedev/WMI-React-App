using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<CarModel> Cars  { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CarModel>(b => b.HasKey(c => new {c.Id, c.PublicId}));
            
            builder.Entity<CarModel>()
                .HasOne(c => c.Country)
                .WithMany()
                .HasForeignKey(c => c.CountryId);
            
            builder.Entity<CountryModel>();
        }
    }
}