﻿namespace PointOfSale.UI
{
    partial class NewProduct
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
            this.productForm1 = new PointOfSale.UI.ProductForm();
            this.SuspendLayout();
            // 
            // productForm1
            // 
            this.productForm1.Location = new System.Drawing.Point(13, 13);
            this.productForm1.Name = "productForm1";
            this.productForm1.Size = new System.Drawing.Size(571, 345);
            this.productForm1.TabIndex = 0;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 352);
            this.Controls.Add(this.productForm1);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private ProductForm productForm1;
    }
}