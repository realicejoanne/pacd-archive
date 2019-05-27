using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak06
{
    public partial class Form1 : Form
    {
        // Intitalization and variable
        Bitmap bmpOriginal, bmp;
        bool firstTime = true;

        public Form1()
        {
            InitializeComponent();
        }

        //Buttons
        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Bitmap)bmpOriginal.Clone();
            bmp = (Bitmap)bmpOriginal.Clone();
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                bmpOriginal = (Bitmap)pictureBox1.Image.Clone();
                firstTime = false;
                btnReset.Enabled = true;
            }

            bmp = (Bitmap)bmpOriginal.Clone();
            float angleValue = trkRotation.Value;
            pictureBox1.Image = RotateImg(bmp, angleValue, Color.Transparent);
        }
        private void buttonReflect_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                bmpOriginal = (Bitmap)pictureBox1.Image.Clone();
                firstTime = false;
                btnReset.Enabled = true;
            }
            bmp = (Bitmap)pictureBox1.Image.Clone();

            if (radXRef.Checked == true)
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            else if (radYRef.Checked == true)
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            else
                radYRef.Checked = true;

            pictureBox1.Image = bmp;
        }
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                bmpOriginal = (Bitmap)pictureBox1.Image.Clone();
                firstTime = false;
                btnReset.Enabled = true;
            }

            bmp = (Bitmap)bmpOriginal.Clone();
            int xValue = trkXTrans.Value;
            int yValue = trkYTrans.Value;
            pictureBox1.Image = (Image)(TranslateImg(bmp, xValue, yValue, Color.Transparent));
        }
        private void buttonScale_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                bmpOriginal = (Bitmap)pictureBox1.Image.Clone();
                firstTime = false;
                btnReset.Enabled = true;
            }

            bmp = (Bitmap)bmpOriginal.Clone();
            int xValue = trkXScaling.Value;
            int yValue = trkYScaling.Value;
            pictureBox1.Image = ScaleImg(bmp, xValue, yValue, Color.Transparent);
        }
        private void buttonShear_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                bmpOriginal = (Bitmap)pictureBox1.Image.Clone();
                firstTime = false;
                btnReset.Enabled = true;
            }

            bmp = (Bitmap)bmpOriginal.Clone();
            int xValue = trkXShear.Value;
            int yValue = trkYShear.Value;

            if (xValue != 1 && yValue != 1)
                pictureBox1.Image = ShearImg(bmp, xValue, yValue, Color.Transparent);
        }

        //Geometric Process
        public static Bitmap RotateImg(Bitmap bmp, float angle, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            pf = PixelFormat.Format32bppArgb;

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));

            Matrix matrix = new Matrix();
            matrix.Rotate(angle);

            RectangleF rct = path.GetBounds(matrix);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
        public static Bitmap TranslateImg(Bitmap bmp, int xValue, int yValue, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            pf = PixelFormat.Format32bppArgb;

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));

            Matrix matrix = new Matrix();
            matrix.Translate(xValue, yValue);

            RectangleF rct = path.GetBounds(matrix);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.Transform = matrix;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
        public static Bitmap ScaleImg(Bitmap bmp, int xValue, int yValue, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            pf = PixelFormat.Format32bppArgb;

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));

            Matrix matrix = new Matrix();
            matrix.Scale(xValue, yValue, MatrixOrder.Append);

            RectangleF rct = path.GetBounds(matrix);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.Transform = matrix;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
        public static Bitmap ShearImg(Bitmap bmp, int xValue, int yValue, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            pf = PixelFormat.Format32bppArgb;

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));

            Matrix matrix = new Matrix();
            matrix.Shear(xValue, yValue, MatrixOrder.Append);

            RectangleF rct = path.GetBounds(matrix);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.Transform = matrix;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }

        //Trackbar
        private void trkRotation_Scroll(object sender, EventArgs e)
        {
            txtRotation.Text = trkRotation.Value.ToString() + "°";
        }

        private void trkXTrans_Scroll(object sender, EventArgs e)
        {
            txtXTrans.Text = trkXTrans.Value.ToString();
        }
        private void trkYTrans_Scroll(object sender, EventArgs e)
        {
            txtYTrans.Text = trkYTrans.Value.ToString();
        }

        private void trkXScaling_Scroll(object sender, EventArgs e)
        {
            txtXScaling.Text = trkXScaling.Value.ToString();
        }
        private void trkYScaling_Scroll(object sender, EventArgs e)
        {
            txtYScaling.Text = trkYScaling.Value.ToString();
        }

        private void trkXShear_Scroll(object sender, EventArgs e)
        {
            txtXShear.Text = trkXShear.Value.ToString();
        }
        private void trkYShear_Scroll(object sender, EventArgs e)
        {
            txtYShear.Text = trkYShear.Value.ToString();
        }
    }
}
