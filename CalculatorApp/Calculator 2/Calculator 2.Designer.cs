namespace Calculator_2
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
            this.Operation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.Hasil = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.Operasi = new System.Windows.Forms.ComboBox();
            this.Hitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Location = new System.Drawing.Point(152, 78);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(58, 17);
            this.Operation.TabIndex = 0;
            this.Operation.Text = "Operasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasil";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(12, 39);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(139, 22);
            this.txtNilaiA.TabIndex = 4;
            // 
            // Hasil
            // 
            this.Hasil.Location = new System.Drawing.Point(114, 248);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(139, 22);
            this.Hasil.TabIndex = 5;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(213, 39);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(139, 22);
            this.txtNilaiB.TabIndex = 6;
            // 
            // Operasi
            // 
            this.Operasi.FormattingEnabled = true;
            this.Operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.Operasi.Location = new System.Drawing.Point(114, 107);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(139, 24);
            this.Operasi.TabIndex = 7;
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(114, 158);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(139, 38);
            this.Hitung.TabIndex = 8;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Create by : WaBud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operation);
            this.Name = "Form1";
            this.Text = "Calculator 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox Hasil;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.ComboBox Operasi;
        private System.Windows.Forms.Button Hitung;
        private System.Windows.Forms.Label label4;
    }
}

