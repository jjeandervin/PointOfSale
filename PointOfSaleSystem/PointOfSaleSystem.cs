using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Entity;
using PointOfSale.UI;

namespace PointOfSaleSystem
{
    public partial class PointOfSaleSystem : Form
    {
        private readonly IProductWriter productWriter;
        private readonly IProductCodeProvider productCodeProvider;

        public PointOfSaleSystem(IProductWriter productWriter, IProductCodeProvider productCodeProvider)
        {
            InitializeComponent();
            this.productWriter = productWriter;
            this.productCodeProvider = productCodeProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmNewProduct = new NewProduct(this.productWriter, this.productCodeProvider);
            frmNewProduct.ShowDialog();
        }
    }
}
