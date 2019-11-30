namespace Prak07
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.picHasil = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtCross = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trkBar = new System.Windows.Forms.TrackBar();
            this.radXor = new System.Windows.Forms.RadioButton();
            this.radOr = new System.Windows.Forms.RadioButton();
            this.radAnd = new System.Windows.Forms.RadioButton();
            this.radAmp = new System.Windows.Forms.RadioButton();
            this.radMin = new System.Windows.Forms.RadioButton();
            this.radMax = new System.Windows.Forms.RadioButton();
            this.radCro = new System.Windows.Forms.RadioButton();
            this.radAvg = new System.Windows.Forms.RadioButton();
            this.radMul = new System.Windows.Forms.RadioButton();
            this.radDif = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHasil)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(24, 23);
            this.pic1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(375, 385);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 51;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(414, 23);
            this.pic2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(375, 385);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 53;
            this.pic2.TabStop = false;
            // 
            // btnProses
            // 
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnProses.Location = new System.Drawing.Point(846, 32);
            this.btnProses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(290, 92);
            this.btnProses.TabIndex = 56;
            this.btnProses.Text = "Process";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // picHasil
            // 
            this.picHasil.Location = new System.Drawing.Point(804, 23);
            this.picHasil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHasil.Name = "picHasil";
            this.picHasil.Size = new System.Drawing.Size(375, 385);
            this.picHasil.TabIndex = 55;
            this.picHasil.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtCross);
            this.groupBox.Controls.Add(this.btnProses);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.trkBar);
            this.groupBox.Controls.Add(this.radXor);
            this.groupBox.Controls.Add(this.radOr);
            this.groupBox.Controls.Add(this.radAnd);
            this.groupBox.Controls.Add(this.radAmp);
            this.groupBox.Controls.Add(this.radMin);
            this.groupBox.Controls.Add(this.radMax);
            this.groupBox.Controls.Add(this.radCro);
            this.groupBox.Controls.Add(this.radAvg);
            this.groupBox.Controls.Add(this.radMul);
            this.groupBox.Controls.Add(this.radDif);
            this.groupBox.Controls.Add(this.radSub);
            this.groupBox.Controls.Add(this.radAdd);
            this.groupBox.Location = new System.Drawing.Point(24, 503);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Size = new System.Drawing.Size(1155, 145);
            this.groupBox.TabIndex = 57;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Process";
            // 
            // txtCross
            // 
            this.txtCross.Enabled = false;
            this.txtCross.Location = new System.Drawing.Point(700, 32);
            this.txtCross.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCross.Name = "txtCross";
            this.txtCross.ReadOnly = true;
            this.txtCross.Size = new System.Drawing.Size(115, 26);
            this.txtCross.TabIndex = 67;
            this.txtCross.Text = "0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nilai Cross-Fading";
            // 
            // trkBar
            // 
            this.trkBar.Location = new System.Drawing.Point(559, 76);
            this.trkBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trkBar.Maximum = 9;
            this.trkBar.Minimum = 1;
            this.trkBar.Name = "trkBar";
            this.trkBar.Size = new System.Drawing.Size(256, 69);
            this.trkBar.TabIndex = 65;
            this.trkBar.Value = 1;
            this.trkBar.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // radXor
            // 
            this.radXor.AutoSize = true;
            this.radXor.Location = new System.Drawing.Point(438, 100);
            this.radXor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radXor.Name = "radXor";
            this.radXor.Size = new System.Drawing.Size(69, 24);
            this.radXor.TabIndex = 62;
            this.radXor.Text = "XOR";
            this.radXor.UseVisualStyleBackColor = true;
            this.radXor.CheckedChanged += new System.EventHandler(this.radXor_CheckedChanged);
            // 
            // radOr
            // 
            this.radOr.AutoSize = true;
            this.radOr.Location = new System.Drawing.Point(439, 66);
            this.radOr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOr.Name = "radOr";
            this.radOr.Size = new System.Drawing.Size(58, 24);
            this.radOr.TabIndex = 61;
            this.radOr.Text = "OR";
            this.radOr.UseVisualStyleBackColor = true;
            this.radOr.CheckedChanged += new System.EventHandler(this.radOr_CheckedChanged);
            // 
            // radAnd
            // 
            this.radAnd.AutoSize = true;
            this.radAnd.Location = new System.Drawing.Point(439, 32);
            this.radAnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAnd.Name = "radAnd";
            this.radAnd.Size = new System.Drawing.Size(68, 24);
            this.radAnd.TabIndex = 60;
            this.radAnd.Text = "AND";
            this.radAnd.UseVisualStyleBackColor = true;
            this.radAnd.CheckedChanged += new System.EventHandler(this.radAnd_CheckedChanged);
            // 
            // radAmp
            // 
            this.radAmp.AutoSize = true;
            this.radAmp.Location = new System.Drawing.Point(287, 32);
            this.radAmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAmp.Name = "radAmp";
            this.radAmp.Size = new System.Drawing.Size(105, 24);
            this.radAmp.TabIndex = 59;
            this.radAmp.Text = "Amplitude";
            this.radAmp.UseVisualStyleBackColor = true;
            this.radAmp.CheckedChanged += new System.EventHandler(this.radAmp_CheckedChanged);
            // 
            // radMin
            // 
            this.radMin.AutoSize = true;
            this.radMin.Location = new System.Drawing.Point(165, 66);
            this.radMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMin.Name = "radMin";
            this.radMin.Size = new System.Drawing.Size(59, 24);
            this.radMin.TabIndex = 58;
            this.radMin.Text = "Min";
            this.radMin.UseVisualStyleBackColor = true;
            this.radMin.CheckedChanged += new System.EventHandler(this.radMin_CheckedChanged);
            // 
            // radMax
            // 
            this.radMax.AutoSize = true;
            this.radMax.Location = new System.Drawing.Point(165, 32);
            this.radMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMax.Name = "radMax";
            this.radMax.Size = new System.Drawing.Size(63, 24);
            this.radMax.TabIndex = 57;
            this.radMax.Text = "Max";
            this.radMax.UseVisualStyleBackColor = true;
            this.radMax.CheckedChanged += new System.EventHandler(this.radMax_CheckedChanged);
            // 
            // radCro
            // 
            this.radCro.AutoSize = true;
            this.radCro.Location = new System.Drawing.Point(287, 100);
            this.radCro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCro.Name = "radCro";
            this.radCro.Size = new System.Drawing.Size(128, 24);
            this.radCro.TabIndex = 56;
            this.radCro.Text = "Cross Fading";
            this.radCro.UseVisualStyleBackColor = true;
            this.radCro.CheckedChanged += new System.EventHandler(this.radCro_CheckedChanged);
            // 
            // radAvg
            // 
            this.radAvg.AutoSize = true;
            this.radAvg.Location = new System.Drawing.Point(287, 66);
            this.radAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAvg.Name = "radAvg";
            this.radAvg.Size = new System.Drawing.Size(93, 24);
            this.radAvg.TabIndex = 55;
            this.radAvg.Text = "Average";
            this.radAvg.UseVisualStyleBackColor = true;
            this.radAvg.CheckedChanged += new System.EventHandler(this.radAvg_CheckedChanged);
            // 
            // radMul
            // 
            this.radMul.AutoSize = true;
            this.radMul.Location = new System.Drawing.Point(165, 100);
            this.radMul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMul.Name = "radMul";
            this.radMul.Size = new System.Drawing.Size(86, 24);
            this.radMul.TabIndex = 54;
            this.radMul.Text = "Multiply";
            this.radMul.UseVisualStyleBackColor = true;
            this.radMul.CheckedChanged += new System.EventHandler(this.radMul_CheckedChanged);
            // 
            // radDif
            // 
            this.radDif.AutoSize = true;
            this.radDif.Location = new System.Drawing.Point(26, 100);
            this.radDif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDif.Name = "radDif";
            this.radDif.Size = new System.Drawing.Size(108, 24);
            this.radDif.TabIndex = 53;
            this.radDif.Text = "Difference";
            this.radDif.UseVisualStyleBackColor = true;
            this.radDif.CheckedChanged += new System.EventHandler(this.radDif_CheckedChanged);
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(26, 66);
            this.radSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(95, 24);
            this.radSub.TabIndex = 52;
            this.radSub.Text = "Subtract";
            this.radSub.UseVisualStyleBackColor = true;
            this.radSub.CheckedChanged += new System.EventHandler(this.radSub_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(26, 32);
            this.radAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(63, 24);
            this.radAdd.TabIndex = 51;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(414, 417);
            this.btnSelect2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(375, 65);
            this.btnSelect2.TabIndex = 54;
            this.btnSelect2.Text = "Select Image";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(24, 417);
            this.btnSelect1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(375, 65);
            this.btnSelect1.TabIndex = 52;
            this.btnSelect1.Text = "Select Image";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(845, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 58;
            this.label2.Text = "Hasil Frame Processing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.picHasil);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHasil)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.PictureBox picHasil;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtCross;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkBar;
        private System.Windows.Forms.RadioButton radXor;
        private System.Windows.Forms.RadioButton radOr;
        private System.Windows.Forms.RadioButton radAnd;
        private System.Windows.Forms.RadioButton radAmp;
        private System.Windows.Forms.RadioButton radMin;
        private System.Windows.Forms.RadioButton radMax;
        private System.Windows.Forms.RadioButton radCro;
        private System.Windows.Forms.RadioButton radAvg;
        private System.Windows.Forms.RadioButton radMul;
        private System.Windows.Forms.RadioButton radDif;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Label label2;
    }
}

