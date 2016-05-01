using System.Data.Entity;

namespace PointOfSale.Entity.Model
{
    public partial class PointOfSaleContext : DbContext
    {
        public PointOfSaleContext()
            : base("name=StoreDb")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(11, 2);
        }
    }
}
