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
using PointOfSale.UI;

namespace PointOfSaleSystem
{
    public partial class PointOfSaleSystem : Form
    {
        public PointOfSaleSystem(IProductManager productManager)
        {
            InitializeComponent();
            this.products1.ProductManager = productManager;
            this.products1.InitializeProductListView();
        }
    }
}
