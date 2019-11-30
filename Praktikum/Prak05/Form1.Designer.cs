namespace Prak05
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
            this.pictureHasil = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMDilasi = new System.Windows.Forms.Button();
            this.filtering = new System.Windows.Forms.ComboBox();
            this.btnMErosi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rMDot = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.rMRing = new System.Windows.Forms.RadioButton();
            this.rMCross = new System.Windows.Forms.RadioButton();
            this.rMPlus = new System.Windows.Forms.RadioButton();
            this.rMBox = new System.Windows.Forms.RadioButton();
            this.btnFiltering = new System.Windows.Forms.Button();
            this.textBoxK33 = new System.Windows.Forms.TextBox();
            this.textBoxK32 = new System.Windows.Forms.TextBox();
            this.textBoxK31 = new System.Windows.Forms.TextBox();
            this.textBoxK23 = new System.Windows.Forms.TextBox();
            this.textBoxK22 = new System.Windows.Forms.TextBox();
            this.textBoxK21 = new System.Windows.Forms.TextBox();
            this.textBoxK13 = new System.Windows.Forms.TextBox();
            this.textBoxK12 = new System.Windows.Forms.TextBox();
            this.textBoxK11 = new System.Windows.Forms.TextBox();
            this.pictureAsli = new System.Windows.Forms.PictureBox();
            this.bgType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(33, 291);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(378, 244);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 5;
            this.pictureHasil.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bgType);
            this.groupBox1.Controls.Add(this.btnMDilasi);
            this.groupBox1.Controls.Add(this.filtering);
            this.groupBox1.Controls.Add(this.btnMErosi);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rMDot);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.rMRing);
            this.groupBox1.Controls.Add(this.rMCross);
            this.groupBox1.Controls.Add(this.rMPlus);
            this.groupBox1.Controls.Add(this.rMBox);
            this.groupBox1.Controls.Add(this.btnFiltering);
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
            this.groupBox1.Location = new System.Drawing.Point(440, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 500);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masking 3x3 / Filtering";
            // 
            // btnMDilasi
            // 
            this.btnMDilasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMDilasi.Location = new System.Drawing.Point(253, 214);
            this.btnMDilasi.Name = "btnMDilasi";
            this.btnMDilasi.Size = new System.Drawing.Size(229, 53);
            this.btnMDilasi.TabIndex = 31;
            this.btnMDilasi.Text = "Dilasi";
            this.btnMDilasi.UseVisualStyleBackColor = true;
            this.btnMDilasi.Click += new System.EventHandler(this.btnMDilasi_Click);
            // 
            // filtering
            // 
            this.filtering.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filtering.FormattingEnabled = true;
            this.filtering.Items.AddRange(new object[] {
            "Median",
            "Average",
            "Maximum",
            "Minimum"});
            this.filtering.Location = new System.Drawing.Point(17, 295);
            this.filtering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filtering.Name = "filtering";
            this.filtering.Size = new System.Drawing.Size(465, 37);
            this.filtering.TabIndex = 30;
            this.filtering.Text = "Choose Mode";
            // 
            // btnMErosi
            // 
            this.btnMErosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMErosi.Location = new System.Drawing.Point(17, 214);
            this.btnMErosi.Name = "btnMErosi";
            this.btnMErosi.Size = new System.Drawing.Size(229, 53);
            this.btnMErosi.TabIndex = 29;
            this.btnMErosi.Text = "Erosi";
            this.btnMErosi.UseVisualStyleBackColor = true;
            this.btnMErosi.Click += new System.EventHandler(this.btnMErosi_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(255, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(227, 53);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rMDot
            // 
            this.rMDot.AutoSize = true;
            this.rMDot.Location = new System.Drawing.Point(372, 103);
            this.rMDot.Name = "rMDot";
            this.rMDot.Size = new System.Drawing.Size(75, 33);
            this.rMDot.TabIndex = 24;
            this.rMDot.TabStop = true;
            this.rMDot.Text = "Dot";
            this.rMDot.UseVisualStyleBackColor = true;
            this.rMDot.CheckedChanged += new System.EventHandler(this.rMDot_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOpen.Location = new System.Drawing.Point(17, 423);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(229, 53);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // rMRing
            // 
            this.rMRing.AutoSize = true;
            this.rMRing.Location = new System.Drawing.Point(372, 53);
            this.rMRing.Name = "rMRing";
            this.rMRing.Size = new System.Drawing.Size(88, 33);
            this.rMRing.TabIndex = 22;
            this.rMRing.TabStop = true;
            this.rMRing.Text = "Ring";
            this.rMRing.UseVisualStyleBackColor = true;
            this.rMRing.CheckedChanged += new System.EventHandler(this.rMRing_CheckedChanged);
            // 
            // rMCross
            // 
            this.rMCross.AutoSize = true;
            this.rMCross.Location = new System.Drawing.Point(246, 153);
            this.rMCross.Name = "rMCross";
            this.rMCross.Size = new System.Drawing.Size(101, 33);
            this.rMCross.TabIndex = 21;
            this.rMCross.TabStop = true;
            this.rMCross.Text = "Cross";
            this.rMCross.UseVisualStyleBackColor = true;
            this.rMCross.CheckedChanged += new System.EventHandler(this.rMCross_CheckedChanged);
            // 
            // rMPlus
            // 
            this.rMPlus.AutoSize = true;
            this.rMPlus.Location = new System.Drawing.Point(246, 103);
            this.rMPlus.Name = "rMPlus";
            this.rMPlus.Size = new System.Drawing.Size(85, 33);
            this.rMPlus.TabIndex = 20;
            this.rMPlus.TabStop = true;
            this.rMPlus.Text = "Plus";
            this.rMPlus.UseVisualStyleBackColor = true;
            this.rMPlus.CheckedChanged += new System.EventHandler(this.rMPlus_CheckedChanged);
            // 
            // rMBox
            // 
            this.rMBox.AutoSize = true;
            this.rMBox.Location = new System.Drawing.Point(246, 53);
            this.rMBox.Name = "rMBox";
            this.rMBox.Size = new System.Drawing.Size(79, 33);
            this.rMBox.TabIndex = 19;
            this.rMBox.TabStop = true;
            this.rMBox.Text = "Box";
            this.rMBox.UseVisualStyleBackColor = true;
            this.rMBox.CheckedChanged += new System.EventHandler(this.rMBox_CheckedChanged);
            // 
            // btnFiltering
            // 
            this.btnFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiltering.Location = new System.Drawing.Point(17, 340);
            this.btnFiltering.Name = "btnFiltering";
            this.btnFiltering.Size = new System.Drawing.Size(465, 53);
            this.btnFiltering.TabIndex = 9;
            this.btnFiltering.Text = "Proses Filtering";
            this.btnFiltering.UseVisualStyleBackColor = true;
            this.btnFiltering.Click += new System.EventHandler(this.btnFiltering_Click);
            // 
            // textBoxK33
            // 
            this.textBoxK33.Location = new System.Drawing.Point(157, 153);
            this.textBoxK33.Name = "textBoxK33";
            this.textBoxK33.Size = new System.Drawing.Size(50, 35);
            this.textBoxK33.TabIndex = 8;
            this.textBoxK33.Text = "0";
            this.textBoxK33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK32
            // 
            this.textBoxK32.Location = new System.Drawing.Point(87, 153);
            this.textBoxK32.Name = "textBoxK32";
            this.textBoxK32.Size = new System.Drawing.Size(50, 35);
            this.textBoxK32.TabIndex = 7;
            this.textBoxK32.Text = "0";
            this.textBoxK32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK31
            // 
            this.textBoxK31.Location = new System.Drawing.Point(17, 153);
            this.textBoxK31.Name = "textBoxK31";
            this.textBoxK31.Size = new System.Drawing.Size(50, 35);
            this.textBoxK31.TabIndex = 6;
            this.textBoxK31.Text = "0";
            this.textBoxK31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK23
            // 
            this.textBoxK23.Location = new System.Drawing.Point(157, 103);
            this.textBoxK23.Name = "textBoxK23";
            this.textBoxK23.Size = new System.Drawing.Size(50, 35);
            this.textBoxK23.TabIndex = 5;
            this.textBoxK23.Text = "0";
            this.textBoxK23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK22
            // 
            this.textBoxK22.Location = new System.Drawing.Point(87, 103);
            this.textBoxK22.Name = "textBoxK22";
            this.textBoxK22.Size = new System.Drawing.Size(50, 35);
            this.textBoxK22.TabIndex = 4;
            this.textBoxK22.Text = "0";
            this.textBoxK22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK21
            // 
            this.textBoxK21.Location = new System.Drawing.Point(17, 103);
            this.textBoxK21.Name = "textBoxK21";
            this.textBoxK21.Size = new System.Drawing.Size(50, 35);
            this.textBoxK21.TabIndex = 3;
            this.textBoxK21.Text = "0";
            this.textBoxK21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK13
            // 
            this.textBoxK13.Location = new System.Drawing.Point(157, 53);
            this.textBoxK13.Name = "textBoxK13";
            this.textBoxK13.Size = new System.Drawing.Size(50, 35);
            this.textBoxK13.TabIndex = 2;
            this.textBoxK13.Text = "0";
            this.textBoxK13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK12
            // 
            this.textBoxK12.Location = new System.Drawing.Point(87, 53);
            this.textBoxK12.Name = "textBoxK12";
            this.textBoxK12.Size = new System.Drawing.Size(50, 35);
            this.textBoxK12.TabIndex = 1;
            this.textBoxK12.Text = "0";
            this.textBoxK12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK11
            // 
            this.textBoxK11.Location = new System.Drawing.Point(17, 53);
            this.textBoxK11.Name = "textBoxK11";
            this.textBoxK11.Size = new System.Drawing.Size(50, 35);
            this.textBoxK11.TabIndex = 0;
            this.textBoxK11.Text = "0";
            this.textBoxK11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(33, 35);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(378, 244);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 3;
            this.pictureAsli.TabStop = false;
            // 
            // bgType
            // 
            this.bgType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bgType.FormattingEnabled = true;
            this.bgType.Items.AddRange(new object[] {
            "White",
            "Black"});
            this.bgType.Location = new System.Drawing.Point(372, 149);
            this.bgType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bgType.Name = "bgType";
            this.bgType.Size = new System.Drawing.Size(110, 37);
            this.bgType.TabIndex = 32;
            this.bgType.Text = "Choose Mode";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RadioButton rMRing;
        private System.Windows.Forms.RadioButton rMCross;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rMPlus;
        private System.Windows.Forms.RadioButton rMBox;
        private System.Windows.Forms.Button btnFiltering;
        private System.Windows.Forms.TextBox textBoxK33;
        private System.Windows.Forms.TextBox textBoxK32;
        private System.Windows.Forms.TextBox textBoxK31;
        private System.Windows.Forms.TextBox textBoxK23;
        private System.Windows.Forms.TextBox textBoxK22;
        private System.Windows.Forms.TextBox textBoxK21;
        private System.Windows.Forms.TextBox textBoxK13;
        private System.Windows.Forms.TextBox textBoxK12;
        private System.Windows.Forms.TextBox textBoxK11;
        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.RadioButton rMDot;
        private System.Windows.Forms.Button btnMErosi;
        private System.Windows.Forms.Button btnMDilasi;
        private System.Windows.Forms.ComboBox filtering;
        private System.Windows.Forms.ComboBox bgType;
    }
}

