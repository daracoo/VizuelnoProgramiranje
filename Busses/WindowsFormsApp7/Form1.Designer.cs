namespace WindowsFormsApp7
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
            this.lbBusses = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBusses
            // 
            this.lbBusses.FormattingEnabled = true;
            this.lbBusses.Location = new System.Drawing.Point(24, 26);
            this.lbBusses.Name = "lbBusses";
            this.lbBusses.Size = new System.Drawing.Size(252, 251);
            this.lbBusses.TabIndex = 0;
            this.lbBusses.SelectedIndexChanged += new System.EventHandler(this.lbBusses_SelectedIndexChanged);
            this.lbBusses.SelectedValueChanged += new System.EventHandler(this.lbBusses_SelectedValueChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.Location = new System.Drawing.Point(341, 26);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(252, 251);
            this.lbLines.TabIndex = 1;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(24, 306);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(252, 23);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(24, 351);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(252, 23);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "ИЗбриши автобус";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(24, 397);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(252, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(341, 322);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(252, 20);
            this.tbMostExpensive.TabIndex = 5;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(341, 378);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(252, 20);
            this.tbAverage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Најскапа линија";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просечна цена на линиите";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Автобуси";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Линии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbMostExpensive);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBusses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBusses;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

