using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Entity.Context;

namespace PointOfSale.Entity
{
    public class ProductWriter : IProductWriter
    {
        public void Write(Product product)
        {
            using (PointOfSaleContext context = new PointOfSaleContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
