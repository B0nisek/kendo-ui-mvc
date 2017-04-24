using DAL.Entities;
using System.Data.Entity;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DbContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.Addresses)
                .Map(m => m.ToTable("CustomerAddress"));
        }
    }
}
