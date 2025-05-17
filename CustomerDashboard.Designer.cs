namespace GörselProgramlamaProje
{
    partial class CustomerDashboard
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(137, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(167, 90);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(100, 26);
            this.txtGuests.TabIndex = 1;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(167, 148);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 28);
            this.cmbTime.TabIndex = 2;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(167, 219);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(140, 32);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "rezerve et";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "kisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.dtpDate);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}