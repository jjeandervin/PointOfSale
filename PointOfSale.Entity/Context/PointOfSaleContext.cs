using System.Data.Entity;

namespace PointOfSale.Entity.Context
{
    public partial class PointOfSaleContext : DbContext
    {
        public PointOfSaleContext()
            : base("name=PointOfSaleContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(11, 2);
        }
    }
}
