namespace Coffee_Machine
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbDrinkOptions;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblDrinkInfo;
        private System.Windows.Forms.NumericUpDown numQuantity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbDrinkOptions = new System.Windows.Forms.ComboBox();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblDrinkInfo = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDrinkOptions
            // 
            this.cmbDrinkOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrinkOptions.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbDrinkOptions.FormattingEnabled = true;
            this.cmbDrinkOptions.Location = new System.Drawing.Point(20, 30);
            this.cmbDrinkOptions.Name = "cmbDrinkOptions";
            this.cmbDrinkOptions.Size = new System.Drawing.Size(150, 24);
            this.cmbDrinkOptions.TabIndex = 0;
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(20, 110);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(150, 30);
            this.btnCheckStock.TabIndex = 1;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Enabled = false;
            this.btnBuy.Location = new System.Drawing.Point(20, 150);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(150, 30);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy Now";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(20, 190);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(150, 30);
            this.btnRefill.TabIndex = 3;
            this.btnRefill.Text = "Refill Ingredients & Stock";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(180, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(180, 90);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock: ";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(180, 120);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(62, 13);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblDrinkInfo
            // 
            this.lblDrinkInfo.AutoSize = true;
            this.lblDrinkInfo.Location = new System.Drawing.Point(180, 150);
            this.lblDrinkInfo.Name = "lblDrinkInfo";
            this.lblDrinkInfo.Size = new System.Drawing.Size(53, 13);
            this.lblDrinkInfo.TabIndex = 8;
            this.lblDrinkInfo.Text = "Drink Info";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(180, 30);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(40, 20);
            this.numQuantity.TabIndex = 9;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblDrinkInfo);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.cmbDrinkOptions);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
