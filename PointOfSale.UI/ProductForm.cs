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
    public partial class ProductForm : UserControl
    {
        public ProductForm()
        {
            InitializeComponent();
            this._product = new Product();
        }

        private Product _product;

        public delegate void ProductSavedHandler();

        public event EventHandler SaveClicked;

        protected virtual void OnSaveClicked()
        {
            if (SaveClicked != null)
                SaveClicked(this, new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtProductCode.Text.Length == 0)
                MessageBox.Show("Please enter product code.");
            else if (this.txtName.Text.Length == 0)
                MessageBox.Show("Please enter product name.");
            else if (this.txtPrice.Text.Length == 0)
                MessageBox.Show("Please enter a price.");
            else
            {
                OnSaveClicked();
            }
        }

        public void GetNextProductCode(IProductCodeProvider provider)
        {
            this._productCode = provider.Load();
        }

        public Product Product
        {
            get
            {
                this.UpdateProductFromForm();
                return this._product;
            }

            set { this._product = value; }
        }

        private void UpdateProductFromForm()
        {
            this._product.ProductCode = this._productCode;
            this._product.ItemName = this._itemName;
            this._product.Description = this._description;
            this._product.Price = this._price;
        }

        private int _productCode
        {
            get { return Convert.ToInt32(this.txtProductCode.Text); }
            set { this.txtProductCode.Text = value.ToString(); }
        }

        private string _itemName => this.txtName.Text;

        private string _description => this.txtDescription.Text;

        private decimal _price => Convert.ToDecimal(this.txtPrice.Text);
    }
}
