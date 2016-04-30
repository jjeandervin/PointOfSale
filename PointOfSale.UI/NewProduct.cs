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

namespace PointOfSale.UI
{
    public partial class NewProduct : Form
    {
        private readonly IProductWriter productWriter;
        private readonly IProductCodeProvider productCodeProvider;
        public NewProduct(IProductWriter productWriter, IProductCodeProvider productCodeProvider)
        {
            this.productCodeProvider = productCodeProvider;
            this.productWriter = productWriter;
            InitializeComponent();
            this.productForm1.SaveClicked += new EventHandler(ProductSaved_EventHandler);
        }

        private void ProductSaved_EventHandler(object sender, EventArgs e)
        {
            this.productWriter.Write(productForm1.Product);
            MessageBox.Show(String.Format("Hello, {0} has been saved to the database!", productForm1.Product.ItemName));
            this.Close();
        }
    }
}
