using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                context.Products.AddOrUpdate(product);
                context.SaveChanges();
            }
        }

        public void DeleteByProductCode(int productCode)
        {
            using (PointOfSaleContext context = new PointOfSaleContext())
            {
                Product product = (from p in context.Products
                                   where p.ProductCode == productCode
                                   select p).FirstOrDefault();

                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
        }
    }
}
