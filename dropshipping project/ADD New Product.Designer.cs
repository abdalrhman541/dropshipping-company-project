namespace dropshipping_project
{
    partial class ADD_Product
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Product_Name_Btn = new System.Windows.Forms.TextBox();
            this.Price_Btn = new System.Windows.Forms.TextBox();
            this.Quantity_Btn = new System.Windows.Forms.TextBox();
            this.Date_New_Product_Added = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Location = new System.Drawing.Point(30, 44);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(75, 13);
            this.Product_Name.TabIndex = 2;
            this.Product_Name.Text = "Product Name";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(30, 131);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time Added to warehouse";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(30, 215);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 6;
            this.Price.Text = "Price";
            // 
            // Product_Name_Btn
            // 
            this.Product_Name_Btn.Location = new System.Drawing.Point(33, 78);
            this.Product_Name_Btn.Name = "Product_Name_Btn";
            this.Product_Name_Btn.Size = new System.Drawing.Size(100, 20);
            this.Product_Name_Btn.TabIndex = 7;
            // 
            // Price_Btn
            // 
            this.Price_Btn.Location = new System.Drawing.Point(33, 262);
            this.Price_Btn.Name = "Price_Btn";
            this.Price_Btn.Size = new System.Drawing.Size(100, 20);
            this.Price_Btn.TabIndex = 9;
            // 
            // Quantity_Btn
            // 
            this.Quantity_Btn.Location = new System.Drawing.Point(33, 169);
            this.Quantity_Btn.Name = "Quantity_Btn";
            this.Quantity_Btn.Size = new System.Drawing.Size(100, 20);
            this.Quantity_Btn.TabIndex = 10;
            // 
            // Date_New_Product_Added
            // 
            this.Date_New_Product_Added.Location = new System.Drawing.Point(33, 340);
            this.Date_New_Product_Added.Name = "Date_New_Product_Added";
            this.Date_New_Product_Added.Size = new System.Drawing.Size(208, 20);
            this.Date_New_Product_Added.TabIndex = 11;
            // 
            // ADD_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date_New_Product_Added);
            this.Controls.Add(this.Quantity_Btn);
            this.Controls.Add(this.Price_Btn);
            this.Controls.Add(this.Product_Name_Btn);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ADD_Product";
            this.Text = "ADD_Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox Product_Name_Btn;
        private System.Windows.Forms.TextBox Price_Btn;
        private System.Windows.Forms.TextBox Quantity_Btn;
        private System.Windows.Forms.DateTimePicker Date_New_Product_Added;
    }
}