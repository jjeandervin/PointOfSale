using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Entity;

namespace PointOfSale.Bus
{
    public interface IProductManager
    {
        IProductWriter ProductWriter { get; }
        IProductReader ProductReader { get; }
        IProductCodeProvider ProductCodeProvider { get;}
    }
}
