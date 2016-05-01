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

        public event EventHandler SaveClicked;

        public event EventHandler CancelClicked;

        protected virtual void OnSaveClicked()
        {
            if (SaveClicked != null)
                SaveClicked(this, new EventArgs());
        }

        protected virtual void OnCancelClicked()
        {
            if (CancelClicked != null)
                CancelClicked(this, new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtProductCode.Text.Length == 0)
                MessageBox.Show("Please enter product code.", "Missing Product Code",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (this.txtName.Text.Length == 0)
                MessageBox.Show("Please enter product name.", "Missing Product Name",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (this.txtPrice.Text.Length == 0)
                MessageBox.Show("Please enter a price.", "Missing Price",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                OnSaveClicked();
            }
        }

        public void GetNextProductCode(IProductCodeProvider provider)
        {
            this._productCode = provider.GenerateNew();
        }

        public Product Product
        {
            get
            {
                this.UpdateProductFromForm();
                return this._product;
            }

            set
            {
                this._product = value;
                this.UpdateFormFromProduct();
            }
        }

        private void UpdateProductFromForm()
        {
            this._product.ProductCode = this._productCode;
            this._product.ItemName = this._itemName;
            this._product.Description = this._description;
            this._product.Price = this._price;
        }

        private void UpdateFormFromProduct()
        {
            this._productCode = this._product.ProductCode;
            this._itemName = this._product.ItemName;
            this._description = this._product.Description;
            this._price = this._product.Price;
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

        private decimal? _price
        {
            get { return Convert.ToDecimal(this.txtPrice.Text); }
            set { this.txtPrice.Text = value.ToString(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.OnCancelClicked();
        }
    }
}
