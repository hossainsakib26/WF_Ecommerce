namespace WindowsFormsEcommerceWork.User_Interface.Customer_Side
{
    partial class ProductList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCartColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vWAllDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.CartButton = new System.Windows.Forms.Button();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.slDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodctNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodctNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWAllDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productDetailsIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.AddToCartColumn});
            this.ProductDataGridView.DataSource = this.vWAllDetailsBindingSource;
            this.ProductDataGridView.Location = new System.Drawing.Point(13, 123);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.Size = new System.Drawing.Size(347, 315);
            this.ProductDataGridView.TabIndex = 0;
            this.ProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDetailsIdDataGridViewTextBoxColumn
            // 
            this.productDetailsIdDataGridViewTextBoxColumn.DataPropertyName = "ProductDetailsId";
            this.productDetailsIdDataGridViewTextBoxColumn.HeaderText = "ProductDetailsId";
            this.productDetailsIdDataGridViewTextBoxColumn.Name = "productDetailsIdDataGridViewTextBoxColumn";
            this.productDetailsIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // AddToCartColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddToCartColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AddToCartColumn.HeaderText = "Buy";
            this.AddToCartColumn.Name = "AddToCartColumn";
            // 
            // vWAllDetailsBindingSource
            // 
            this.vWAllDetailsBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Buyer_Side_VM.VW_AllDetails);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Product";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(381, 85);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(0, 18);
            this.categoryLabel.TabIndex = 1;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(381, 123);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(0, 18);
            this.ProductLabel.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(381, 163);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 18);
            this.priceLabel.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(384, 202);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(37, 21);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // CartButton
            // 
            this.CartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartButton.Location = new System.Drawing.Point(384, 245);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(106, 32);
            this.CartButton.TabIndex = 3;
            this.CartButton.Text = "Add To Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DataSource = this.productBindingSource;
            this.ProductComboBox.DisplayMember = "Name";
            this.ProductComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(141, 69);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(167, 26);
            this.ProductComboBox.TabIndex = 4;
            this.ProductComboBox.ValueMember = "Id";
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Business_Side.Product);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.categoryBindingSource;
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(141, 37);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(167, 26);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.ValueMember = "Id";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Business_Side.Category);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(427, 205);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 13);
            this.msgLabel.TabIndex = 6;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AutoGenerateColumns = false;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn2,
            this.prodctNameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.singlePriceDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.CartDataGridView.DataSource = this.orderBindingSource;
            this.CartDataGridView.Location = new System.Drawing.Point(384, 284);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.Size = new System.Drawing.Size(550, 154);
            this.CartDataGridView.TabIndex = 0;
            this.CartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            // 
            // slDataGridViewTextBoxColumn1
            // 
            this.slDataGridViewTextBoxColumn1.DataPropertyName = "Sl";
            this.slDataGridViewTextBoxColumn1.HeaderText = "Sl";
            this.slDataGridViewTextBoxColumn1.Name = "slDataGridViewTextBoxColumn1";
            // 
            // productIdDataGridViewTextBoxColumn2
            // 
            this.productIdDataGridViewTextBoxColumn2.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn2.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn2.Name = "productIdDataGridViewTextBoxColumn2";
            this.productIdDataGridViewTextBoxColumn2.Visible = false;
            // 
            // prodctNameDataGridViewTextBoxColumn1
            // 
            this.prodctNameDataGridViewTextBoxColumn1.DataPropertyName = "ProdctName";
            this.prodctNameDataGridViewTextBoxColumn1.HeaderText = "Prodct";
            this.prodctNameDataGridViewTextBoxColumn1.Name = "prodctNameDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // singlePriceDataGridViewTextBoxColumn1
            // 
            this.singlePriceDataGridViewTextBoxColumn1.DataPropertyName = "SinglePrice";
            this.singlePriceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.singlePriceDataGridViewTextBoxColumn1.Name = "singlePriceDataGridViewTextBoxColumn1";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Order);
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "Sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "Sl";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            this.productIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // prodctNameDataGridViewTextBoxColumn
            // 
            this.prodctNameDataGridViewTextBoxColumn.DataPropertyName = "ProdctName";
            this.prodctNameDataGridViewTextBoxColumn.HeaderText = "ProdctName";
            this.prodctNameDataGridViewTextBoxColumn.Name = "prodctNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // singlePriceDataGridViewTextBoxColumn
            // 
            this.singlePriceDataGridViewTextBoxColumn.DataPropertyName = "SinglePrice";
            this.singlePriceDataGridViewTextBoxColumn.HeaderText = "SinglePrice";
            this.singlePriceDataGridViewTextBoxColumn.Name = "singlePriceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // ShowCartButton
            // 
            this.ShowCartButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowCartButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_shopping_cart_48;
            this.ShowCartButton.Location = new System.Drawing.Point(874, 12);
            this.ShowCartButton.Name = "ShowCartButton";
            this.ShowCartButton.Size = new System.Drawing.Size(60, 58);
            this.ShowCartButton.TabIndex = 7;
            this.ShowCartButton.UseVisualStyleBackColor = false;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.ShowCartButton);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.ProductDataGridView);
            this.Name = "ProductList";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWAllDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource vWAllDetailsBindingSource;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodctNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodctNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDetailsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AddToCartColumn;
        private System.Windows.Forms.Button ShowCartButton;
    }
}