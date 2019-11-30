namespace Prak06
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonShear = new System.Windows.Forms.Button();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.buttonReflect = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.radYRef = new System.Windows.Forms.RadioButton();
            this.radXRef = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYShear = new System.Windows.Forms.TextBox();
            this.trkYShear = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXShear = new System.Windows.Forms.TextBox();
            this.trkXShear = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYScaling = new System.Windows.Forms.TextBox();
            this.trkYScaling = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXScaling = new System.Windows.Forms.TextBox();
            this.trkXScaling = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYTrans = new System.Windows.Forms.TextBox();
            this.trkYTrans = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXTrans = new System.Windows.Forms.TextBox();
            this.trkXTrans = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.trkRotation = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkYShear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXShear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.buttonScale);
            this.groupBox1.Controls.Add(this.buttonShear);
            this.groupBox1.Controls.Add(this.buttonTranslate);
            this.groupBox1.Controls.Add(this.buttonReflect);
            this.groupBox1.Controls.Add(this.btnRotate);
            this.groupBox1.Controls.Add(this.radYRef);
            this.groupBox1.Controls.Add(this.radXRef);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtYShear);
            this.groupBox1.Controls.Add(this.trkYShear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtXShear);
            this.groupBox1.Controls.Add(this.trkXShear);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtYScaling);
            this.groupBox1.Controls.Add(this.trkYScaling);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtXScaling);
            this.groupBox1.Controls.Add(this.trkXScaling);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtYTrans);
            this.groupBox1.Controls.Add(this.trkYTrans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtXTrans);
            this.groupBox1.Controls.Add(this.trkXTrans);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRotation);
            this.groupBox1.Controls.Add(this.trkRotation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(517, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digital Image Processing";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(776, 333);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 54);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(475, 333);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(124, 54);
            this.buttonScale.TabIndex = 33;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonShear
            // 
            this.buttonShear.Location = new System.Drawing.Point(625, 333);
            this.buttonShear.Name = "buttonShear";
            this.buttonShear.Size = new System.Drawing.Size(124, 54);
            this.buttonShear.TabIndex = 32;
            this.buttonShear.Text = "Shear";
            this.buttonShear.UseVisualStyleBackColor = true;
            this.buttonShear.Click += new System.EventHandler(this.buttonShear_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(776, 261);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(124, 54);
            this.buttonTranslate.TabIndex = 31;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonReflect
            // 
            this.buttonReflect.Location = new System.Drawing.Point(625, 261);
            this.buttonReflect.Name = "buttonReflect";
            this.buttonReflect.Size = new System.Drawing.Size(124, 54);
            this.buttonReflect.TabIndex = 30;
            this.buttonReflect.Text = "Reflect";
            this.buttonReflect.UseVisualStyleBackColor = true;
            this.buttonReflect.Click += new System.EventHandler(this.buttonReflect_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(475, 261);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(124, 54);
            this.btnRotate.TabIndex = 29;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // radYRef
            // 
            this.radYRef.AutoSize = true;
            this.radYRef.Location = new System.Drawing.Point(740, 56);
            this.radYRef.Name = "radYRef";
            this.radYRef.Size = new System.Drawing.Size(102, 33);
            this.radYRef.TabIndex = 28;
            this.radYRef.TabStop = true;
            this.radYRef.Text = "Y axis";
            this.radYRef.UseVisualStyleBackColor = true;
            // 
            // radXRef
            // 
            this.radXRef.AutoSize = true;
            this.radXRef.Location = new System.Drawing.Point(621, 56);
            this.radXRef.Name = "radXRef";
            this.radXRef.Size = new System.Drawing.Size(103, 33);
            this.radXRef.TabIndex = 27;
            this.radXRef.TabStop = true;
            this.radXRef.Text = "X axis";
            this.radXRef.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Reflection";
            // 
            // txtYShear
            // 
            this.txtYShear.Location = new System.Drawing.Point(828, 201);
            this.txtYShear.Name = "txtYShear";
            this.txtYShear.Size = new System.Drawing.Size(72, 35);
            this.txtYShear.TabIndex = 25;
            this.txtYShear.Text = "2";
            // 
            // trkYShear
            // 
            this.trkYShear.Location = new System.Drawing.Point(621, 201);
            this.trkYShear.Minimum = 2;
            this.trkYShear.Name = "trkYShear";
            this.trkYShear.Size = new System.Drawing.Size(200, 69);
            this.trkYShear.TabIndex = 24;
            this.trkYShear.Value = 2;
            this.trkYShear.Scroll += new System.EventHandler(this.trkYShear_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y axis";
            // 
            // txtXShear
            // 
            this.txtXShear.Location = new System.Drawing.Point(828, 160);
            this.txtXShear.Name = "txtXShear";
            this.txtXShear.Size = new System.Drawing.Size(72, 35);
            this.txtXShear.TabIndex = 22;
            this.txtXShear.Text = "1";
            // 
            // trkXShear
            // 
            this.trkXShear.Location = new System.Drawing.Point(621, 160);
            this.trkXShear.Minimum = 1;
            this.trkXShear.Name = "trkXShear";
            this.trkXShear.Size = new System.Drawing.Size(200, 69);
            this.trkXShear.TabIndex = 21;
            this.trkXShear.Value = 1;
            this.trkXShear.Scroll += new System.EventHandler(this.trkXShear_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "X axis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Shearing";
            // 
            // txtYScaling
            // 
            this.txtYScaling.Location = new System.Drawing.Point(378, 346);
            this.txtYScaling.Name = "txtYScaling";
            this.txtYScaling.Size = new System.Drawing.Size(72, 35);
            this.txtYScaling.TabIndex = 18;
            this.txtYScaling.Text = "1";
            // 
            // trkYScaling
            // 
            this.trkYScaling.Location = new System.Drawing.Point(171, 346);
            this.trkYScaling.Minimum = 1;
            this.trkYScaling.Name = "trkYScaling";
            this.trkYScaling.Size = new System.Drawing.Size(200, 69);
            this.trkYScaling.TabIndex = 17;
            this.trkYScaling.Value = 1;
            this.trkYScaling.Scroll += new System.EventHandler(this.trkYScaling_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y axis";
            // 
            // txtXScaling
            // 
            this.txtXScaling.Location = new System.Drawing.Point(378, 305);
            this.txtXScaling.Name = "txtXScaling";
            this.txtXScaling.Size = new System.Drawing.Size(72, 35);
            this.txtXScaling.TabIndex = 15;
            this.txtXScaling.Text = "1";
            // 
            // trkXScaling
            // 
            this.trkXScaling.Location = new System.Drawing.Point(171, 305);
            this.trkXScaling.Minimum = 1;
            this.trkXScaling.Name = "trkXScaling";
            this.trkXScaling.Size = new System.Drawing.Size(200, 69);
            this.trkXScaling.TabIndex = 14;
            this.trkXScaling.Value = 1;
            this.trkXScaling.Scroll += new System.EventHandler(this.trkXScaling_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "X axis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Scaling";
            // 
            // txtYTrans
            // 
            this.txtYTrans.Location = new System.Drawing.Point(378, 201);
            this.txtYTrans.Name = "txtYTrans";
            this.txtYTrans.Size = new System.Drawing.Size(72, 35);
            this.txtYTrans.TabIndex = 11;
            this.txtYTrans.Text = "0";
            // 
            // trkYTrans
            // 
            this.trkYTrans.Location = new System.Drawing.Point(171, 201);
            this.trkYTrans.Maximum = 100;
            this.trkYTrans.Minimum = -100;
            this.trkYTrans.Name = "trkYTrans";
            this.trkYTrans.Size = new System.Drawing.Size(200, 69);
            this.trkYTrans.TabIndex = 10;
            this.trkYTrans.Scroll += new System.EventHandler(this.trkYTrans_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y axis";
            // 
            // txtXTrans
            // 
            this.txtXTrans.Location = new System.Drawing.Point(378, 160);
            this.txtXTrans.Name = "txtXTrans";
            this.txtXTrans.Size = new System.Drawing.Size(72, 35);
            this.txtXTrans.TabIndex = 8;
            this.txtXTrans.Text = "0";
            // 
            // trkXTrans
            // 
            this.trkXTrans.Location = new System.Drawing.Point(171, 160);
            this.trkXTrans.Maximum = 100;
            this.trkXTrans.Minimum = -100;
            this.trkXTrans.Name = "trkXTrans";
            this.trkXTrans.Size = new System.Drawing.Size(200, 69);
            this.trkXTrans.TabIndex = 7;
            this.trkXTrans.Scroll += new System.EventHandler(this.trkXTrans_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "X axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Translation";
            // 
            // txtRotation
            // 
            this.txtRotation.Enabled = false;
            this.txtRotation.HideSelection = false;
            this.txtRotation.Location = new System.Drawing.Point(378, 56);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(72, 35);
            this.txtRotation.TabIndex = 2;
            this.txtRotation.Text = "0°";
            // 
            // trkRotation
            // 
            this.trkRotation.Location = new System.Drawing.Point(171, 56);
            this.trkRotation.Maximum = 360;
            this.trkRotation.Minimum = -360;
            this.trkRotation.Name = "trkRotation";
            this.trkRotation.Size = new System.Drawing.Size(200, 69);
            this.trkRotation.TabIndex = 1;
            this.trkRotation.Scroll += new System.EventHandler(this.trkRotation_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1488, 550);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1466, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkYShear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXShear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.RadioButton radYRef;
        private System.Windows.Forms.RadioButton radXRef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYShear;
        private System.Windows.Forms.TrackBar trkYShear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXShear;
        private System.Windows.Forms.TrackBar trkXShear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYScaling;
        private System.Windows.Forms.TrackBar trkYScaling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXScaling;
        private System.Windows.Forms.TrackBar trkXScaling;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYTrans;
        private System.Windows.Forms.TrackBar trkYTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXTrans;
        private System.Windows.Forms.TrackBar trkXTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.TrackBar trkRotation;
        private System.Windows.Forms.Button buttonReflect;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonShear;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Button btnReset;
    }
}

