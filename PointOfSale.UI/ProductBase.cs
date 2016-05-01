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
using PointOfSale.Entity;

namespace PointOfSale.UI
{
    public partial class ProductBase : Form
    {
        protected IProductManager _productManager;

        public ProductBase()
        {
            InitializeComponent();

        }
        protected void ProductSaved_EventHandler(object sender, EventArgs e)
        {
            this._productManager.ProductWriter.Write(productForm1.Product);
            this.Close();
        }

        protected void CancelClicked_EventHandler(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
