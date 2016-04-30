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
        private void InitializeComponent(IProductCodeProvider productCodeProvider)
        {
            this.productForm1 = new PointOfSale.UI.ProductForm(productCodeProvider);
            this.SuspendLayout();
            // 
            // productForm1
            // 
            this.productForm1.Location = new System.Drawing.Point(13, 13);
            this.productForm1.Name = "productForm1";
            this.productForm1.Size = new System.Drawing.Size(439, 294);
            this.productForm1.TabIndex = 0;
            // 
            // PointOfSaleSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 365);
            this.Controls.Add(this.productForm1);
            this.Name = "PointOfSaleSystem";
            this.Text = "PointOfSaleSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private PointOfSale.UI.ProductForm productForm1;
    }
}

