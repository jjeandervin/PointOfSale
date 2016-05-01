namespace PointOfSale.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public Product()
        {}

        public Product(IProductCodeProvider productCodeProvider)
        {
            this.ProductCode = productCodeProvider.GenerateNew();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("product_code")]
        public int ProductCode { get; set; }

        [StringLength(32)]
        [Column("name")]
        public string ItemName { get; set; }

        [StringLength(512)]
        [Column("description")]
        public string Description { get; set; }

        [Column("price", TypeName = "numeric")]
        public decimal? Price { get; set; }
    }
}
