namespace Prak04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.rBEdge = new System.Windows.Forms.RadioButton();
            this.rBEmbo = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.rBSharp = new System.Windows.Forms.RadioButton();
            this.rBBlur = new System.Windows.Forms.RadioButton();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFaktor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.textBoxK33 = new System.Windows.Forms.TextBox();
            this.textBoxK32 = new System.Windows.Forms.TextBox();
            this.textBoxK31 = new System.Windows.Forms.TextBox();
            this.textBoxK23 = new System.Windows.Forms.TextBox();
            this.textBoxK22 = new System.Windows.Forms.TextBox();
            this.textBoxK21 = new System.Windows.Forms.TextBox();
            this.textBoxK13 = new System.Windows.Forms.TextBox();
            this.textBoxK12 = new System.Windows.Forms.TextBox();
            this.textBoxK11 = new System.Windows.Forms.TextBox();
            this.pictureHasil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(37, 36);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(378, 244);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 0;
            this.pictureAsli.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.rBEdge);
            this.groupBox1.Controls.Add(this.rBEmbo);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rBSharp);
            this.groupBox1.Controls.Add(this.rBBlur);
            this.groupBox1.Controls.Add(this.textBoxOffset);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFaktor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.textBoxK33);
            this.groupBox1.Controls.Add(this.textBoxK32);
            this.groupBox1.Controls.Add(this.textBoxK31);
            this.groupBox1.Controls.Add(this.textBoxK23);
            this.groupBox1.Controls.Add(this.textBoxK22);
            this.groupBox1.Controls.Add(this.textBoxK21);
            this.groupBox1.Controls.Add(this.textBoxK13);
            this.groupBox1.Controls.Add(this.textBoxK12);
            this.groupBox1.Controls.Add(this.textBoxK11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(444, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konvolusi";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOpen.Location = new System.Drawing.Point(17, 416);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(227, 53);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // rBEdge
            // 
            this.rBEdge.AutoSize = true;
            this.rBEdge.Location = new System.Drawing.Point(306, 213);
            this.rBEdge.Name = "rBEdge";
            this.rBEdge.Size = new System.Drawing.Size(115, 33);
            this.rBEdge.TabIndex = 22;
            this.rBEdge.TabStop = true;
            this.rBEdge.Text = "Edging";
            this.rBEdge.UseVisualStyleBackColor = true;
            this.rBEdge.CheckedChanged += new System.EventHandler(this.rBEdge_CheckedChanged);
            // 
            // rBEmbo
            // 
            this.rBEmbo.AutoSize = true;
            this.rBEmbo.Location = new System.Drawing.Point(306, 163);
            this.rBEmbo.Name = "rBEmbo";
            this.rBEmbo.Size = new System.Drawing.Size(147, 33);
            this.rBEmbo.TabIndex = 21;
            this.rBEmbo.TabStop = true;
            this.rBEmbo.Text = "Embosing";
            this.rBEmbo.UseVisualStyleBackColor = true;
            this.rBEmbo.CheckedChanged += new System.EventHandler(this.rBEmbo_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(253, 416);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(227, 53);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rBSharp
            // 
            this.rBSharp.AutoSize = true;
            this.rBSharp.Location = new System.Drawing.Point(306, 113);
            this.rBSharp.Name = "rBSharp";
            this.rBSharp.Size = new System.Drawing.Size(162, 33);
            this.rBSharp.TabIndex = 20;
            this.rBSharp.TabStop = true;
            this.rBSharp.Text = "Sharpening";
            this.rBSharp.UseVisualStyleBackColor = true;
            this.rBSharp.CheckedChanged += new System.EventHandler(this.rBSharp_CheckedChanged);
            // 
            // rBBlur
            // 
            this.rBBlur.AutoSize = true;
            this.rBBlur.Location = new System.Drawing.Point(306, 63);
            this.rBBlur.Name = "rBBlur";
            this.rBBlur.Size = new System.Drawing.Size(122, 33);
            this.rBBlur.TabIndex = 19;
            this.rBBlur.TabStop = true;
            this.rBBlur.Text = "Blurring";
            this.rBBlur.UseVisualStyleBackColor = true;
            this.rBBlur.CheckedChanged += new System.EventHandler(this.rBBlur_CheckedChanged);
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(157, 286);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(50, 35);
            this.textBoxOffset.TabIndex = 18;
            this.textBoxOffset.Text = "0";
            this.textBoxOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Offset";
            // 
            // textBoxFaktor
            // 
            this.textBoxFaktor.Location = new System.Drawing.Point(157, 229);
            this.textBoxFaktor.Name = "textBoxFaktor";
            this.textBoxFaktor.Size = new System.Drawing.Size(50, 35);
            this.textBoxFaktor.TabIndex = 16;
            this.textBoxFaktor.Text = "0";
            this.textBoxFaktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Faktor";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProcess.Location = new System.Drawing.Point(17, 353);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(463, 53);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Proses";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textBoxK33
            // 
            this.textBoxK33.Location = new System.Drawing.Point(157, 161);
            this.textBoxK33.Name = "textBoxK33";
            this.textBoxK33.Size = new System.Drawing.Size(50, 35);
            this.textBoxK33.TabIndex = 8;
            this.textBoxK33.Text = "0";
            this.textBoxK33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK32
            // 
            this.textBoxK32.Location = new System.Drawing.Point(87, 161);
            this.textBoxK32.Name = "textBoxK32";
            this.textBoxK32.Size = new System.Drawing.Size(50, 35);
            this.textBoxK32.TabIndex = 7;
            this.textBoxK32.Text = "0";
            this.textBoxK32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK31
            // 
            this.textBoxK31.Location = new System.Drawing.Point(17, 161);
            this.textBoxK31.Name = "textBoxK31";
            this.textBoxK31.Size = new System.Drawing.Size(50, 35);
            this.textBoxK31.TabIndex = 6;
            this.textBoxK31.Text = "0";
            this.textBoxK31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK23
            // 
            this.textBoxK23.Location = new System.Drawing.Point(157, 111);
            this.textBoxK23.Name = "textBoxK23";
            this.textBoxK23.Size = new System.Drawing.Size(50, 35);
            this.textBoxK23.TabIndex = 5;
            this.textBoxK23.Text = "0";
            this.textBoxK23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK22
            // 
            this.textBoxK22.Location = new System.Drawing.Point(87, 111);
            this.textBoxK22.Name = "textBoxK22";
            this.textBoxK22.Size = new System.Drawing.Size(50, 35);
            this.textBoxK22.TabIndex = 4;
            this.textBoxK22.Text = "0";
            this.textBoxK22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK21
            // 
            this.textBoxK21.Location = new System.Drawing.Point(17, 111);
            this.textBoxK21.Name = "textBoxK21";
            this.textBoxK21.Size = new System.Drawing.Size(50, 35);
            this.textBoxK21.TabIndex = 3;
            this.textBoxK21.Text = "0";
            this.textBoxK21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK13
            // 
            this.textBoxK13.Location = new System.Drawing.Point(157, 61);
            this.textBoxK13.Name = "textBoxK13";
            this.textBoxK13.Size = new System.Drawing.Size(50, 35);
            this.textBoxK13.TabIndex = 2;
            this.textBoxK13.Text = "0";
            this.textBoxK13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK12
            // 
            this.textBoxK12.Location = new System.Drawing.Point(87, 61);
            this.textBoxK12.Name = "textBoxK12";
            this.textBoxK12.Size = new System.Drawing.Size(50, 35);
            this.textBoxK12.TabIndex = 1;
            this.textBoxK12.Text = "0";
            this.textBoxK12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK11
            // 
            this.textBoxK11.Location = new System.Drawing.Point(17, 61);
            this.textBoxK11.Name = "textBoxK11";
            this.textBoxK11.Size = new System.Drawing.Size(50, 35);
            this.textBoxK11.TabIndex = 0;
            this.textBoxK11.Text = "0";
            this.textBoxK11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(37, 292);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(378, 244);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 2;
            this.pictureHasil.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.pictureHasil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxK13;
        private System.Windows.Forms.TextBox textBoxK12;
        private System.Windows.Forms.TextBox textBoxK11;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textBoxK33;
        private System.Windows.Forms.TextBox textBoxK32;
        private System.Windows.Forms.TextBox textBoxK31;
        private System.Windows.Forms.TextBox textBoxK23;
        private System.Windows.Forms.TextBox textBoxK22;
        private System.Windows.Forms.TextBox textBoxK21;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFaktor;
        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.RadioButton rBEdge;
        private System.Windows.Forms.RadioButton rBEmbo;
        private System.Windows.Forms.RadioButton rBSharp;
        private System.Windows.Forms.RadioButton rBBlur;
        private System.Windows.Forms.Button btnOpen;
    }
}

