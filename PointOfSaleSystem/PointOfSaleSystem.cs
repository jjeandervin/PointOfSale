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
        public PointOfSaleSystem(IProductWriter productWriter, IProductCodeProvider productCodeProvider)
        {
            InitializeComponent();
            this.products1.ProductCodeProvider = productCodeProvider;
            this.products1.ProductWriter = productWriter;
        }
    }
}
