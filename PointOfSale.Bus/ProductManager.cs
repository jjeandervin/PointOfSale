using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Entity;

namespace PointOfSale.Bus
{
    public class ProductManager : IProductManager
    {
        public ProductManager(IProductWriter productWriter, IProductReader productReader, IProductCodeProvider productCodeProvider)
        {
            this.ProductWriter = productWriter;
            this.ProductReader = productReader;
            this.ProductCodeProvider = productCodeProvider;
        }

        public IProductWriter ProductWriter { get; }
        public IProductReader ProductReader { get; }
        public IProductCodeProvider ProductCodeProvider { get; }
    }
}
