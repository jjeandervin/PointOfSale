using PointOfSale.Entity;

namespace PointOfSaleSystem
{
    partial class PointOfSaleSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.products1 = new PointOfSale.UI.Products();
            this.tabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.products1);
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(652, 318);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // products1
            // 
            this.products1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.products1.BackColor = System.Drawing.SystemColors.Control;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Name = "products1";
            this.products1.ProductCodeProvider = null;
            this.products1.Size = new System.Drawing.Size(652, 318);
            this.products1.TabIndex = 0;
            // 
            // PointOfSaleSystem
            // 
            this.ClientSize = new System.Drawing.Size(685, 359);
            this.Controls.Add(this.tabControl1);
            this.Name = "PointOfSaleSystem";
            this.tabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Products;
        private PointOfSale.UI.Products products1;
    }
}

