namespace Tugas101
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.picHistogram = new System.Windows.Forms.PictureBox();
            this.buttonConts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInv = new System.Windows.Forms.Button();
            this.buttonGrayjust = new System.Windows.Forms.Button();
            this.buttonGrayweight = new System.Windows.Forms.Button();
            this.pictureHasil = new System.Windows.Forms.PictureBox();
            this.buttonBright = new System.Windows.Forms.Button();
            this.buttonThres = new System.Windows.Forms.Button();
            this.textBoxBright = new System.Windows.Forms.TextBox();
            this.textBoxThres = new System.Windows.Forms.TextBox();
            this.buttonHistEq = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGrayPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(32, 33);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(471, 285);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 0;
            this.pictureAsli.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digital Image Processing Program";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(1065, 26);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(180, 44);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Change Image";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // picHistogram
            // 
            this.picHistogram.BackColor = System.Drawing.Color.White;
            this.picHistogram.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picHistogram.Location = new System.Drawing.Point(532, 295);
            this.picHistogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHistogram.Name = "picHistogram";
            this.picHistogram.Size = new System.Drawing.Size(349, 262);
            this.picHistogram.TabIndex = 44;
            this.picHistogram.TabStop = false;
            // 
            // buttonConts
            // 
            this.buttonConts.Location = new System.Drawing.Point(896, 584);
            this.buttonConts.Name = "buttonConts";
            this.buttonConts.Size = new System.Drawing.Size(349, 44);
            this.buttonConts.TabIndex = 45;
            this.buttonConts.Text = "Contrast Stretching";
            this.buttonConts.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(527, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(526, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thresholding";
            // 
            // buttonInv
            // 
            this.buttonInv.Location = new System.Drawing.Point(533, 224);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(348, 39);
            this.buttonInv.TabIndex = 50;
            this.buttonInv.Text = "Invert";
            this.buttonInv.UseVisualStyleBackColor = true;
            this.buttonInv.Click += new System.EventHandler(this.buttonInv_Click);
            // 
            // buttonGrayjust
            // 
            this.buttonGrayjust.Location = new System.Drawing.Point(896, 118);
            this.buttonGrayjust.Name = "buttonGrayjust";
            this.buttonGrayjust.Size = new System.Drawing.Size(349, 39);
            this.buttonGrayjust.TabIndex = 51;
            this.buttonGrayjust.Text = "Grayscale-Justified";
            this.buttonGrayjust.UseVisualStyleBackColor = true;
            this.buttonGrayjust.Click += new System.EventHandler(this.buttonGrayjust_Click);
            // 
            // buttonGrayweight
            // 
            this.buttonGrayweight.Location = new System.Drawing.Point(896, 170);
            this.buttonGrayweight.Name = "buttonGrayweight";
            this.buttonGrayweight.Size = new System.Drawing.Size(349, 39);
            this.buttonGrayweight.TabIndex = 52;
            this.buttonGrayweight.Text = "Grayscale-Weighted";
            this.buttonGrayweight.UseVisualStyleBackColor = true;
            this.buttonGrayweight.Click += new System.EventHandler(this.buttonGrayweight_Click);
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(32, 343);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(471, 285);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 53;
            this.pictureHasil.TabStop = false;
            // 
            // buttonBright
            // 
            this.buttonBright.Location = new System.Drawing.Point(794, 118);
            this.buttonBright.Name = "buttonBright";
            this.buttonBright.Size = new System.Drawing.Size(87, 39);
            this.buttonBright.TabIndex = 54;
            this.buttonBright.Text = "SET";
            this.buttonBright.UseVisualStyleBackColor = true;
            this.buttonBright.Click += new System.EventHandler(this.buttonBright_Click);
            // 
            // buttonThres
            // 
            this.buttonThres.Location = new System.Drawing.Point(794, 165);
            this.buttonThres.Name = "buttonThres";
            this.buttonThres.Size = new System.Drawing.Size(87, 39);
            this.buttonThres.TabIndex = 55;
            this.buttonThres.Text = "SET";
            this.buttonThres.UseVisualStyleBackColor = true;
            this.buttonThres.Click += new System.EventHandler(this.buttonThres_Click);
            // 
            // textBoxBright
            // 
            this.textBoxBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxBright.Location = new System.Drawing.Point(679, 122);
            this.textBoxBright.Name = "textBoxBright";
            this.textBoxBright.Size = new System.Drawing.Size(95, 26);
            this.textBoxBright.TabIndex = 56;
            // 
            // textBoxThres
            // 
            this.textBoxThres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxThres.Location = new System.Drawing.Point(678, 169);
            this.textBoxThres.Name = "textBoxThres";
            this.textBoxThres.Size = new System.Drawing.Size(96, 26);
            this.textBoxThres.TabIndex = 57;
            // 
            // buttonHistEq
            // 
            this.buttonHistEq.Location = new System.Drawing.Point(533, 584);
            this.buttonHistEq.Name = "buttonHistEq";
            this.buttonHistEq.Size = new System.Drawing.Size(348, 44);
            this.buttonHistEq.TabIndex = 58;
            this.buttonHistEq.Text = "Histogram Equalization";
            this.buttonHistEq.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(896, 295);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 262);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGrayPoint
            // 
            this.buttonGrayPoint.Location = new System.Drawing.Point(896, 224);
            this.buttonGrayPoint.Name = "buttonGrayPoint";
            this.buttonGrayPoint.Size = new System.Drawing.Size(349, 39);
            this.buttonGrayPoint.TabIndex = 60;
            this.buttonGrayPoint.Text = "Grayscale-Weighted-Pointer";
            this.buttonGrayPoint.UseVisualStyleBackColor = true;
            this.buttonGrayPoint.Click += new System.EventHandler(this.buttonGrayPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 661);
            this.Controls.Add(this.buttonGrayPoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHistEq);
            this.Controls.Add(this.textBoxThres);
            this.Controls.Add(this.textBoxBright);
            this.Controls.Add(this.buttonThres);
            this.Controls.Add(this.buttonBright);
            this.Controls.Add(this.pictureHasil);
            this.Controls.Add(this.buttonGrayweight);
            this.Controls.Add(this.buttonGrayjust);
            this.Controls.Add(this.buttonInv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConts);
            this.Controls.Add(this.picHistogram);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.PictureBox picHistogram;
        private System.Windows.Forms.Button buttonConts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInv;
        private System.Windows.Forms.Button buttonGrayjust;
        private System.Windows.Forms.Button buttonGrayweight;
        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.Button buttonThres;
        private System.Windows.Forms.TextBox textBoxBright;
        private System.Windows.Forms.TextBox textBoxThres;
        private System.Windows.Forms.Button buttonHistEq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGrayPoint;
    }
}

