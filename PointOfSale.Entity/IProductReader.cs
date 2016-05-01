using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Entity.Model;

namespace PointOfSale.Entity
{
    public interface IProductReader
    {
        IEnumerable<Product> ReadAll();

        Product ReadByProductCode(int productCode);
    }
}
