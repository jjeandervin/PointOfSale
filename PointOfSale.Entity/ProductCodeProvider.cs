using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Entity.Context;

namespace PointOfSale.Entity
{
    public class ProductCodeProvider : IProductCodeProvider
    {
        private const int StartingCode = 90000001;

        public int Load()
        {
            using (PointOfSaleContext context = new PointOfSaleContext())
            {
                IEnumerable<int> productCodes = this.GetProductCodes(context);

                if (!productCodes.Any())
                    return ProductCodeProvider.StartingCode;

                int productCode = this.GetNextProductCode(productCodes);
                return productCode;
            }
        }

        private IEnumerable<int> GetProductCodes(PointOfSaleContext context)
        {
                IEnumerable<int> productCodes = (from p in context.Products
                                                 orderby p.ProductCode ascending 
                                                 select p.ProductCode);
                return productCodes;
        }

        private int GetNextProductCode(IEnumerable<int> productCodes)
        {
            int productCode = Enumerable.Range(productCodes.Min(), productCodes.Count() + 1).Except(productCodes).First(); 
            return productCode;
        }
    }
}
