namespace WindowsFormsEcommerceWork.User_Interface.Business_Side.Products_Related
{
    partial class ProductDetails_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails_UI));
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.DeletePictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.categorylabel = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.ReportButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ProductListButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.vMProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMProductDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AutoGenerateColumns = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn});
            this.detailsDataGridView.DataSource = this.vMProductDetailsBindingSource;
            this.detailsDataGridView.Location = new System.Drawing.Point(227, 362);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.Size = new System.Drawing.Size(651, 160);
            this.detailsDataGridView.TabIndex = 33;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Business_Side.Product);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Business_Side.Category);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(365, 99);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(202, 26);
            this.categoryComboBox.TabIndex = 32;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // DeletePictureBox
            // 
            this.DeletePictureBox.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_delete_bin_;
            this.DeletePictureBox.Location = new System.Drawing.Point(445, 308);
            this.DeletePictureBox.Name = "DeletePictureBox";
            this.DeletePictureBox.Size = new System.Drawing.Size(30, 29);
            this.DeletePictureBox.TabIndex = 31;
            this.DeletePictureBox.TabStop = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(369, 77);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 30;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.Location = new System.Drawing.Point(365, 307);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_delete_32;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(858, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(365, 195);
            this.totalPriceTextBox.Multiline = true;
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(202, 26);
            this.totalPriceTextBox.TabIndex = 28;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(365, 163);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(202, 26);
            this.quantityTextBox.TabIndex = 27;
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categorylabel.Location = new System.Drawing.Point(272, 101);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(81, 20);
            this.categorylabel.TabIndex = 25;
            this.categorylabel.Text = "Category";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCode.Location = new System.Drawing.Point(259, 197);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(94, 20);
            this.labelCode.TabIndex = 26;
            this.labelCode.Text = "Total Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelQuantity.Location = new System.Drawing.Point(277, 165);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 20);
            this.labelQuantity.TabIndex = 24;
            this.labelQuantity.Text = "Quantity";
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_graph_32;
            this.ReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.Location = new System.Drawing.Point(0, 320);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ReportButton.Size = new System.Drawing.Size(220, 60);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Reports";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportButton.UseVisualStyleBackColor = false;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HistoryButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_activity_history_32;
            this.HistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoryButton.Location = new System.Drawing.Point(0, 260);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HistoryButton.Size = new System.Drawing.Size(220, 60);
            this.HistoryButton.TabIndex = 7;
            this.HistoryButton.Text = "History";
            this.HistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HistoryButton.UseVisualStyleBackColor = false;
            // 
            // ProductListButton
            // 
            this.ProductListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.ProductListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductListButton.FlatAppearance.BorderSize = 0;
            this.ProductListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductListButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_basket_32;
            this.ProductListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductListButton.Location = new System.Drawing.Point(0, 200);
            this.ProductListButton.Name = "ProductListButton";
            this.ProductListButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ProductListButton.Size = new System.Drawing.Size(220, 60);
            this.ProductListButton.TabIndex = 5;
            this.ProductListButton.Text = "Product\'s Details";
            this.ProductListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductListButton.UseVisualStyleBackColor = false;
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.ProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_basket_32;
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(0, 140);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ProductButton.Size = new System.Drawing.Size(220, 60);
            this.ProductButton.TabIndex = 2;
            this.ProductButton.Text = "Product";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.categoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryButton.Image = global::WindowsFormsEcommerceWork.Properties.Resources.icons8_medium_priority_32;
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(0, 80);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.categoryButton.Size = new System.Drawing.Size(220, 60);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Category";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryButton.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(288, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.HistoryButton);
            this.panel1.Controls.Add(this.ProductListButton);
            this.panel1.Controls.Add(this.ProductButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 532);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(282, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Product";
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.productBindingSource;
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(365, 131);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(202, 26);
            this.productComboBox.TabIndex = 32;
            this.productComboBox.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(262, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cost Price";
            // 
            // costPriceTextBox
            // 
            this.costPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPriceTextBox.Location = new System.Drawing.Point(365, 227);
            this.costPriceTextBox.Multiline = true;
            this.costPriceTextBox.Name = "costPriceTextBox";
            this.costPriceTextBox.Size = new System.Drawing.Size(202, 26);
            this.costPriceTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(262, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sale Price";
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePriceTextBox.Location = new System.Drawing.Point(365, 259);
            this.salePriceTextBox.Multiline = true;
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(202, 26);
            this.salePriceTextBox.TabIndex = 28;
            // 
            // vMProductDetailsBindingSource
            // 
            this.vMProductDetailsBindingSource.DataSource = typeof(WindowsFormsEcommerceWork.Models.Business_Side_VM.VM_ProductDetails);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // ProductDetails_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(890, 534);
            this.ControlBox = false;
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.DeletePictureBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.salePriceTextBox);
            this.Controls.Add(this.costPriceTextBox);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetails_UI";
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vMProductDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.PictureBox DeletePictureBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button ProductListButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vMProductDetailsBindingSource;
    }
}