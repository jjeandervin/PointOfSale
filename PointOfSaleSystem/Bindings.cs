using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using PointOfSale.Entity;

namespace PointOfSale.Bus
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProductWriter>().To<ProductWriter>();
            this.Bind<IProductCodeProvider>().To<ProductCodeProvider>();
            this.Bind<IProductReader>().To<ProductReader>();
            this.Bind<IProductManager>().To<ProductManager>();
        }
    }
}
