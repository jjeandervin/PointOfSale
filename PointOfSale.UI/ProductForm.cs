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

        public Product Product
        {
            get
            {
                if (this._product == null)
                    this._product = new Product();

                this.UpdateProduct();
                return this._product;

            }

            set { this._product = value; }
        }

        private void UpdateProduct()
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

        private string _itemName
        {
            get { return this.txtName.Text; }
            set { this.txtName.Text = value; }
        }

        private string _description
        {
            get { return this.txtDescription.Text; }
            set { this.txtDescription.Text = value; }
        }

        private decimal _price
        {
            get { return Convert.ToDecimal(this.txtPrice.Text); }
            set { this.txtPrice.Text = value.ToString(); }
        }

       
    }
}
