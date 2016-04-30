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

namespace PointOfSaleSystem
{
    public partial class PointOfSaleSystem : Form
    {
        private readonly IProductWriter productWriter;
        public PointOfSaleSystem(IProductWriter productWriter, IProductCodeProvider productCodeProvider)
        {
            InitializeComponent(productCodeProvider);
            this.productWriter = productWriter;
            this.productForm1.SaveClicked += new EventHandler(ProductSaved_EventHandler);
        }

        private void ProductSaved_EventHandler(object sender, EventArgs e)
        {
            this.productWriter.Write(productForm1.Product);
            MessageBox.Show(String.Format("Hello, {0} has been saved to the database!", productForm1.Product.ItemName));
        }

    }
}
