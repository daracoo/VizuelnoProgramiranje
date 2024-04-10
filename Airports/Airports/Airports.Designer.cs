namespace Airports
{
    partial class Airports
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
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.tbAverageDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(358, 21);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(244, 238);
            this.lbDestinations.TabIndex = 0;
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(24, 21);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(244, 238);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(24, 285);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(244, 34);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Додади аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(24, 344);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(244, 34);
            this.btnDeleteAirport.TabIndex = 3;
            this.btnDeleteAirport.Text = "Избриши аеордром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(24, 399);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(244, 34);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(358, 310);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(244, 20);
            this.tbMostExpensiveDestination.TabIndex = 5;
            this.tbMostExpensiveDestination.Visible = false;
            // 
            // tbAverageDestination
            // 
            this.tbAverageDestination.Location = new System.Drawing.Point(358, 375);
            this.tbAverageDestination.Name = "tbAverageDestination";
            this.tbAverageDestination.Size = new System.Drawing.Size(244, 20);
            this.tbAverageDestination.TabIndex = 6;
            this.tbAverageDestination.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Најскапа дестинација";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // Airports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverageDestination);
            this.Controls.Add(this.tbMostExpensiveDestination);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.lbDestinations);
            this.Name = "Airports";
            this.Text = "Аеродроми";
            this.Load += new System.EventHandler(this.Airports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.TextBox tbAverageDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

