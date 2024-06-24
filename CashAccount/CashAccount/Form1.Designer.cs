namespace CashAccount
{
    partial class Form1
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbReceipt = new System.Windows.Forms.ListBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbToPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(22, 31);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(249, 251);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbReceipt
            // 
            this.lbReceipt.FormattingEnabled = true;
            this.lbReceipt.Location = new System.Drawing.Point(318, 31);
            this.lbReceipt.Name = "lbReceipt";
            this.lbReceipt.Size = new System.Drawing.Size(249, 251);
            this.lbReceipt.TabIndex = 1;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(151, 309);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 2;
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(438, 363);
            this.nudTax.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(129, 20);
            this.nudTax.TabIndex = 3;
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Location = new System.Drawing.Point(22, 345);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(249, 23);
            this.btnAddReceipt.TabIndex = 4;
            this.btnAddReceipt.Text = "Додади во сметка";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(22, 392);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(249, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Додади нов";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(318, 297);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(249, 23);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "Избриши ставка";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(438, 326);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(129, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // tbToPay
            // 
            this.tbToPay.Enabled = false;
            this.tbToPay.Location = new System.Drawing.Point(438, 395);
            this.tbToPay.Name = "tbToPay";
            this.tbToPay.Size = new System.Drawing.Size(129, 20);
            this.tbToPay.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вкупно:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Данок(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "За плаќање";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Продукти";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Сметка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbToPay);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.nudTax);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lbReceipt);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Каса";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbReceipt;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbToPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

