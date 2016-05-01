using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSale.Entity.Model
{
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductCode { get; set; }

        [StringLength(32)]
        public string ItemName { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        public Guid? SellerId { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
