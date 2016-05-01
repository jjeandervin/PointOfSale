using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Bus;

namespace PointOfSale.UI
{
    public partial class NewProduct : ProductBase
    {

        public NewProduct(IProductManager productManager)
        {
            this._productManager = productManager;
            InitializeComponent();
            this.productForm1.GetNextProductCode(this._productManager.ProductCodeProvider);
            this.productForm1.SaveClicked += new EventHandler(ProductSaved_EventHandler);
            productForm1.CancelClicked += new EventHandler(CancelClicked_EventHandler);
        }
    }
}
