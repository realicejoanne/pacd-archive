namespace Kelas02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureAsli = new System.Windows.Forms.PictureBox();
            this.pictureHasil = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonE = new System.Windows.Forms.Button();
            this.pictureEkspektasi = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkspektasi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(187, 25);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(549, 132);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 0;
            this.pictureAsli.TabStop = false;
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(187, 345);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(549, 132);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 1;
            this.pictureHasil.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxE);
            this.groupBox1.Controls.Add(this.textBoxT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(778, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 452);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance Similarity";
            // 
            // textBoxE
            // 
            this.textBoxE.Enabled = false;
            this.textBoxE.Location = new System.Drawing.Point(26, 197);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(332, 35);
            this.textBoxE.TabIndex = 6;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(26, 97);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(332, 35);
            this.textBoxT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Euclidean Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threshold Value (T):";
            // 
            // buttonE
            // 
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonE.Location = new System.Drawing.Point(26, 377);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(332, 51);
            this.buttonE.TabIndex = 1;
            this.buttonE.Text = "Check Similarity";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // pictureEkspektasi
            // 
            this.pictureEkspektasi.Image = ((System.Drawing.Image)(resources.GetObject("pictureEkspektasi.Image")));
            this.pictureEkspektasi.Location = new System.Drawing.Point(187, 185);
            this.pictureEkspektasi.Name = "pictureEkspektasi";
            this.pictureEkspektasi.Size = new System.Drawing.Size(549, 132);
            this.pictureEkspektasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEkspektasi.TabIndex = 3;
            this.pictureEkspektasi.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expectation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(37, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result";
            // 
            // textBoxS
            // 
            this.textBoxS.Enabled = false;
            this.textBoxS.Location = new System.Drawing.Point(26, 297);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(332, 35);
            this.textBoxS.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Smallest Euclidean Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureEkspektasi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureHasil);
            this.Controls.Add(this.pictureAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkspektasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureEkspektasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

