namespace WindowsFormsEcommerceWork
{
    partial class Base_UI
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
            this.SellerButton = new System.Windows.Forms.Button();
            this.BuyerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SellerButton
            // 
            this.SellerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerButton.Location = new System.Drawing.Point(97, 66);
            this.SellerButton.Name = "SellerButton";
            this.SellerButton.Size = new System.Drawing.Size(179, 39);
            this.SellerButton.TabIndex = 0;
            this.SellerButton.Text = "Seller";
            this.SellerButton.UseVisualStyleBackColor = true;
            this.SellerButton.Click += new System.EventHandler(this.SellerButton_Click);
            // 
            // BuyerButton
            // 
            this.BuyerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyerButton.Location = new System.Drawing.Point(282, 66);
            this.BuyerButton.Name = "BuyerButton";
            this.BuyerButton.Size = new System.Drawing.Size(179, 39);
            this.BuyerButton.TabIndex = 0;
            this.BuyerButton.Text = "Buyer";
            this.BuyerButton.UseVisualStyleBackColor = true;
            // 
            // Base_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 204);
            this.Controls.Add(this.BuyerButton);
            this.Controls.Add(this.SellerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Base_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecommerce App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SellerButton;
        private System.Windows.Forms.Button BuyerButton;
    }
}

