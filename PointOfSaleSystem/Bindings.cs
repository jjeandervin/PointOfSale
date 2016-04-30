using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using PointOfSale.Entity;

namespace PointOfSaleSystem
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProductWriter>().To<ProductWriter>();
        }
    }
}
