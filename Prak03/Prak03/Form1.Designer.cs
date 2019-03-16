namespace Prak03
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
            this.textBoxThres = new System.Windows.Forms.TextBox();
            this.textBoxBright = new System.Windows.Forms.TextBox();
            this.buttonThres = new System.Windows.Forms.Button();
            this.buttonBright = new System.Windows.Forms.Button();
            this.pictureHasil = new System.Windows.Forms.PictureBox();
            this.buttonGrayweight = new System.Windows.Forms.Button();
            this.buttonGrayjust = new System.Windows.Forms.Button();
            this.buttonInv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAsli = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxThres
            // 
            this.textBoxThres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxThres.Location = new System.Drawing.Point(668, 162);
            this.textBoxThres.Name = "textBoxThres";
            this.textBoxThres.Size = new System.Drawing.Size(96, 26);
            this.textBoxThres.TabIndex = 70;
            // 
            // textBoxBright
            // 
            this.textBoxBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxBright.Location = new System.Drawing.Point(669, 115);
            this.textBoxBright.Name = "textBoxBright";
            this.textBoxBright.Size = new System.Drawing.Size(95, 26);
            this.textBoxBright.TabIndex = 69;
            // 
            // buttonThres
            // 
            this.buttonThres.Location = new System.Drawing.Point(784, 158);
            this.buttonThres.Name = "buttonThres";
            this.buttonThres.Size = new System.Drawing.Size(87, 39);
            this.buttonThres.TabIndex = 68;
            this.buttonThres.Text = "SET";
            this.buttonThres.UseVisualStyleBackColor = true;
            this.buttonThres.Click += new System.EventHandler(this.buttonThres_Click);
            // 
            // buttonBright
            // 
            this.buttonBright.Location = new System.Drawing.Point(784, 111);
            this.buttonBright.Name = "buttonBright";
            this.buttonBright.Size = new System.Drawing.Size(87, 39);
            this.buttonBright.TabIndex = 67;
            this.buttonBright.Text = "SET";
            this.buttonBright.UseVisualStyleBackColor = true;
            this.buttonBright.Click += new System.EventHandler(this.buttonBright_Click);
            // 
            // pictureHasil
            // 
            this.pictureHasil.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasil.Image")));
            this.pictureHasil.Location = new System.Drawing.Point(22, 336);
            this.pictureHasil.Name = "pictureHasil";
            this.pictureHasil.Size = new System.Drawing.Size(471, 285);
            this.pictureHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHasil.TabIndex = 66;
            this.pictureHasil.TabStop = false;
            // 
            // buttonGrayweight
            // 
            this.buttonGrayweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonGrayweight.Location = new System.Drawing.Point(12, 93);
            this.buttonGrayweight.Name = "buttonGrayweight";
            this.buttonGrayweight.Size = new System.Drawing.Size(326, 39);
            this.buttonGrayweight.TabIndex = 65;
            this.buttonGrayweight.Text = "Grayscale-Weighted";
            this.buttonGrayweight.UseVisualStyleBackColor = true;
            this.buttonGrayweight.Click += new System.EventHandler(this.buttonGrayweight_Click);
            // 
            // buttonGrayjust
            // 
            this.buttonGrayjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonGrayjust.Location = new System.Drawing.Point(12, 41);
            this.buttonGrayjust.Name = "buttonGrayjust";
            this.buttonGrayjust.Size = new System.Drawing.Size(326, 39);
            this.buttonGrayjust.TabIndex = 64;
            this.buttonGrayjust.Text = "Grayscale-Justified";
            this.buttonGrayjust.UseVisualStyleBackColor = true;
            this.buttonGrayjust.Click += new System.EventHandler(this.buttonGrayjust_Click);
            // 
            // buttonInv
            // 
            this.buttonInv.Location = new System.Drawing.Point(521, 217);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(350, 39);
            this.buttonInv.TabIndex = 63;
            this.buttonInv.Text = "Invert";
            this.buttonInv.UseVisualStyleBackColor = true;
            this.buttonInv.Click += new System.EventHandler(this.buttonInv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(515, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Thresholding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(516, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Brightness";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(521, 518);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(714, 44);
            this.buttonChange.TabIndex = 60;
            this.buttonChange.Text = "Change Image";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 37);
            this.label1.TabIndex = 59;
            this.label1.Text = "Digital Image Processing Program";
            // 
            // pictureAsli
            // 
            this.pictureAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureAsli.Image")));
            this.pictureAsli.Location = new System.Drawing.Point(22, 26);
            this.pictureAsli.Name = "pictureAsli";
            this.pictureAsli.Size = new System.Drawing.Size(471, 285);
            this.pictureAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAsli.TabIndex = 58;
            this.pictureAsli.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGrayjust);
            this.groupBox1.Controls.Add(this.buttonGrayweight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(886, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 145);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grayscaling";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(520, 577);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(714, 44);
            this.buttonSave.TabIndex = 73;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(521, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 217);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Processing Time";
            // 
            // textBoxPT
            // 
            this.textBoxPT.Enabled = false;
            this.textBoxPT.Location = new System.Drawing.Point(32, 165);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(648, 30);
            this.textBoxPT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Processing Message";
            // 
            // textBoxPM
            // 
            this.textBoxPM.Enabled = false;
            this.textBoxPM.Location = new System.Drawing.Point(34, 84);
            this.textBoxPM.Name = "textBoxPM";
            this.textBoxPM.Size = new System.Drawing.Size(646, 30);
            this.textBoxPM.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxThres);
            this.Controls.Add(this.textBoxBright);
            this.Controls.Add(this.buttonThres);
            this.Controls.Add(this.buttonBright);
            this.Controls.Add(this.pictureHasil);
            this.Controls.Add(this.buttonInv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureAsli);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAsli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxThres;
        private System.Windows.Forms.TextBox textBoxBright;
        private System.Windows.Forms.Button buttonThres;
        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.PictureBox pictureHasil;
        private System.Windows.Forms.Button buttonGrayweight;
        private System.Windows.Forms.Button buttonGrayjust;
        private System.Windows.Forms.Button buttonInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAsli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPM;
    }
}

