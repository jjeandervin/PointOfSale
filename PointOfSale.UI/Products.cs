using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Entity;

namespace PointOfSale.UI
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        public IProductWriter ProductWriter;
        public IProductCodeProvider ProductCodeProvider { get; set; }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form NewProduct = new NewProduct(this.ProductWriter, this.ProductCodeProvider);
            NewProduct.ShowDialog();
        }
    }
}
