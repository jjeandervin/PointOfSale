using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Bus;
using PointOfSale.Entity;

namespace PointOfSale.UI
{
    public partial class Products : UserControl
    {
        private IEnumerable<Product> _products;
        public Products()
        {
            InitializeComponent();
            this.btnDelete.Enabled = this.btnEditProduct.Enabled = false;
        }

        public IProductManager ProductManager { get; set; }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form NewProduct = new NewProduct(this.ProductManager);
            NewProduct.ShowDialog();
            this.LoadProductListView();
        }

        public void InitializeProductListView()
        {
            this.lvProducts.Columns.Add("Product Code");
            this.lvProducts.Columns.Add("Name");
            this.lvProducts.Columns.Add("Price");
            this.LoadProductListView();
            
        }

        private void LoadProductListView()
        {
            this.lvProducts.Items.Clear();
            this._products = this.ProductManager.ProductReader.ReadAll();
            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(product.ProductCode.ToString());
                item.SubItems.Add(product.ItemName);
                item.SubItems.Add(string.Format("${0}", product.Price.ToString()));
                lvProducts.Items.Add(item);
            }
            this.lvProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.SizeLastColumn(this.lvProducts);
            this.btnDelete.Enabled = this.btnEditProduct.Enabled = this.lvProducts.SelectedItems.Count > 0;
        }

        private void listView1_Resize(object sender, System.EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int productCode = Convert.ToInt32(this.lvProducts.SelectedItems[0].Text);
            Form NewProduct = new EditProduct(this.ProductManager, productCode);
            NewProduct.ShowDialog();
            this.LoadProductListView();
        }

        private void lvProducts_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            bool productSelected = this.btnDelete.Enabled = this.btnEditProduct.Enabled = this.lvProducts.SelectedItems.Count > 0;
            this.SetDescriptionText(productSelected);
        }

        private void SetDescriptionText(bool productSelected)
        {
            if (productSelected)
                this.txtDescription.Text =
                    this._products
                        .FirstOrDefault(x => x.ProductCode == Convert.ToInt32(this.lvProducts.SelectedItems[0].Text))
                        .Description;
            else
                this.txtDescription.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productName = this.lvProducts.SelectedItems[0].SubItems[1].Text;
            string dialogMessage = string.Format("Are you sure you want to permanently delete {0}?", productName);
            DialogResult result = MessageBox.Show(dialogMessage, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int productCode = Convert.ToInt32(this.lvProducts.SelectedItems[0].Text);
            if (result == DialogResult.Yes)
                this.ProductManager.ProductWriter.DeleteByProductCode(productCode);

            this.LoadProductListView();
        }
    }
}
