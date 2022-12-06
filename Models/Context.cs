using Microsoft.EntityFrameworkCore;
namespace CIDM_3312_FINAL_PROJECT_YOTAM.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base (options)
            {

            }
            protected override void OnModelCreating (ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<cart>().HasKey(c=> new {c.CheckoutID, c.itemID});
            }
            public DbSet<item> items {get;set;}= default!;
            public DbSet<Checkout> Checkouts {get;set;}= default!;
            public DbSet<cart> carts{get;set;}=default!;
    }
}