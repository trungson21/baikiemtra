namespace baikiemtra
{
    partial class main
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
            this.LstCart = new System.Windows.Forms.ListView();
            this.Tensanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.BtnRemoveFromCart = new System.Windows.Forms.Button();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.LstProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstCart
            // 
            this.LstCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tensanpham,
            this.Gia,
            this.Soluong});
            this.LstCart.HideSelection = false;
            this.LstCart.Location = new System.Drawing.Point(447, 51);
            this.LstCart.Name = "LstCart";
            this.LstCart.Size = new System.Drawing.Size(330, 218);
            this.LstCart.TabIndex = 0;
            this.LstCart.UseCompatibleStateImageBehavior = false;
            this.LstCart.View = System.Windows.Forms.View.Details;
            this.LstCart.SelectedIndexChanged += new System.EventHandler(this.LstCart_SelectedIndexChanged);
            // 
            // Tensanpham
            // 
            this.Tensanpham.Text = "Tên sản phẩm";
            this.Tensanpham.Width = 119;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            this.Gia.Width = 108;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số lượng";
            this.Soluong.Width = 98;
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(124, 318);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(105, 23);
            this.BtnAddToCart.TabIndex = 2;
            this.BtnAddToCart.Text = "Add";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // BtnRemoveFromCart
            // 
            this.BtnRemoveFromCart.Location = new System.Drawing.Point(346, 318);
            this.BtnRemoveFromCart.Name = "BtnRemoveFromCart";
            this.BtnRemoveFromCart.Size = new System.Drawing.Size(105, 23);
            this.BtnRemoveFromCart.TabIndex = 3;
            this.BtnRemoveFromCart.Text = "Remove";
            this.BtnRemoveFromCart.UseVisualStyleBackColor = true;
            this.BtnRemoveFromCart.Click += new System.EventHandler(this.BtnRemoveFromCart_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(544, 318);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(105, 23);
            this.BtnCheckOut.TabIndex = 4;
            this.BtnCheckOut.Text = "CheckOut";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // LstProduct
            // 
            this.LstProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LstProduct.HideSelection = false;
            this.LstProduct.Location = new System.Drawing.Point(31, 51);
            this.LstProduct.Name = "LstProduct";
            this.LstProduct.Size = new System.Drawing.Size(330, 218);
            this.LstProduct.TabIndex = 5;
            this.LstProduct.UseCompatibleStateImageBehavior = false;
            this.LstProduct.View = System.Windows.Forms.View.Details;
            this.LstProduct.SelectedIndexChanged += new System.EventHandler(this.LstProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 101;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(444, 285);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblTotalAmount1
            // 
            this.lblTotalAmount1.AutoSize = true;
            this.lblTotalAmount1.Location = new System.Drawing.Point(343, 285);
            this.lblTotalAmount1.Name = "lblTotalAmount1";
            this.lblTotalAmount1.Size = new System.Drawing.Size(44, 16);
            this.lblTotalAmount1.TabIndex = 7;
            this.lblTotalAmount1.Text = "label1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 490);
            this.Controls.Add(this.lblTotalAmount1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.LstProduct);
            this.Controls.Add(this.BtnCheckOut);
            this.Controls.Add(this.BtnRemoveFromCart);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.LstCart);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstCart;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Button BtnRemoveFromCart;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.ColumnHeader Tensanpham;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.ListView LstProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount1;
    }
}

