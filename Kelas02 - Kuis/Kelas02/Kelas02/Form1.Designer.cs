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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(28, 25);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(724, 183);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 0;
            this.pictureAsli.TabStop = false;
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(28, 253);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(724, 183);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 1;
            this.pictureHasil.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonE);
            this.groupBox1.Controls.Add(this.buttonT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(778, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance Similarity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 35);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 35);
            this.textBox1.TabIndex = 5;
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
            this.buttonE.Location = new System.Drawing.Point(26, 334);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(332, 51);
            this.buttonE.TabIndex = 1;
            this.buttonE.Text = "Check Similarity";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonT
            // 
            this.buttonT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonT.Location = new System.Drawing.Point(26, 277);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(332, 51);
            this.buttonT.TabIndex = 0;
            this.buttonT.Text = "Threshold";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureHasil);
            this.Controls.Add(this.pictureAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

