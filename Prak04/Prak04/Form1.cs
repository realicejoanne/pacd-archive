using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Prak04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmpOriginal;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bmpOriginal = new Bitmap(open.FileName);
                pictureAsli.Image = bmpOriginal;
                pictureHasil.Image = bmpOriginal;
                bmpOriginal = (Bitmap)pictureAsli.Image.Clone();
                rBBlur.Enabled = true;
                rBEdge.Enabled = true;
                rBSharp.Enabled = true;
                rBEmbo.Enabled = true;
                btnProcess.Enabled = true;
                textBoxK11.Text = "1";
                textBoxK12.Text = "2";
                textBoxK13.Text = "1";
                textBoxK21.Text = "2";
                textBoxK22.Text = "4";
                textBoxK23.Text = "1";
                textBoxK31.Text = "1";
                textBoxK32.Text = "2";
                textBoxK33.Text = "1";
                textBoxFaktor.Text = "16";
                textBoxOffset.Text = "0";
            }
        }

        public static Bitmap Konvolusi(Bitmap b, Operator m)
        {
            Bitmap bSrc = (Bitmap)b.Clone();
            if (m.Factor == 0) return b;
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            int stride2 = stride * 2;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;
                int nOffset = stride + 6 - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;
                int nPixel;
                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) + (pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) + (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[5 + stride] = (byte)nPixel;
                        nPixel = ((((pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) + (pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) + (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) + (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[4 + stride] = (byte)nPixel;
                        nPixel = ((((pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) + (pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) + (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) + (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[3 + stride] = (byte)nPixel;
                        p += 3;
                        pSrc += 3;
                    }
                    p += nOffset;
                    pSrc += nOffset;
                }
            }
            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);
            return b;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bmpOriginal = (Bitmap)pictureAsli.Image.Clone();
            Bitmap bmp = (Bitmap)pictureAsli.Image;
            btnReset.Enabled = true;
            Operator filter = new Operator();
            filter.TopLeft = Convert.ToInt16(textBoxK11.Text);
            filter.TopMid = Convert.ToInt16(textBoxK12.Text);
            filter.TopRight = Convert.ToInt16(textBoxK13.Text);
            filter.MidLeft = Convert.ToInt16(textBoxK21.Text);
            filter.Pixel = Convert.ToInt16(textBoxK22.Text);
            filter.MidRight = Convert.ToInt16(textBoxK23.Text);
            filter.BottomLeft = Convert.ToInt16(textBoxK31.Text);
            filter.BottomMid = Convert.ToInt16(textBoxK32.Text);
            filter.BottomRight = Convert.ToInt16(textBoxK33.Text);
            filter.Offset = Convert.ToUInt16(textBoxOffset.Text);
            filter.Factor = Convert.ToUInt16(textBoxFaktor.Text);
            pictureHasil.Image = Konvolusi(bmp, filter);
        }

        private void rBBlur_CheckedChanged(object sender, EventArgs e)
        {
            //rBBlur.Checked = true;
            rBEdge.Checked = false;
            rBSharp.Checked = false;
            rBEmbo.Checked = false;
            textBoxK11.Text = "1";
            textBoxK12.Text = "2";
            textBoxK13.Text = "1";
            textBoxK21.Text = "2";
            textBoxK22.Text = "4";
            textBoxK23.Text = "1";
            textBoxK31.Text = "1";
            textBoxK32.Text = "2";
            textBoxK33.Text = "1";
            textBoxFaktor.Text = "16";
            textBoxOffset.Text = "0";
        }

        private void rBSharp_CheckedChanged(object sender, EventArgs e)
        {
            rBBlur.Checked = false;
            rBEdge.Checked = false;
            //rBSharp.Checked = true;
            rBEmbo.Checked = false;
            textBoxK11.Text = "0";
            textBoxK12.Text = "-2";
            textBoxK13.Text = "0";
            textBoxK21.Text = "-2";
            textBoxK22.Text = "11";
            textBoxK23.Text = "-2";
            textBoxK31.Text = "0";
            textBoxK32.Text = "2";
            textBoxK33.Text = "0";
            textBoxFaktor.Text = "3";
            textBoxOffset.Text = "0";
        }

        private void rBEmbo_CheckedChanged(object sender, EventArgs e)
        {
            rBBlur.Checked = false;
            rBEdge.Checked = false;
            rBSharp.Checked = false;
            //rBEmbo.Checked = true;
            textBoxK11.Text = "-1";
            textBoxK12.Text = "0";
            textBoxK13.Text = "-1";
            textBoxK21.Text = "0";
            textBoxK22.Text = "4";
            textBoxK23.Text = "0";
            textBoxK31.Text = "-1";
            textBoxK32.Text = "0";
            textBoxK33.Text = "-1";
            textBoxFaktor.Text = "1";
            textBoxOffset.Text = "127";
        }

        private void rBEdge_CheckedChanged(object sender, EventArgs e)
        {
            rBBlur.Checked = false;
            //rBEdge.Checked = true;
            rBSharp.Checked = false;
            rBEmbo.Checked = false;
            textBoxK11.Text = "-1";
            textBoxK12.Text = "-1";
            textBoxK13.Text = "-1";
            textBoxK21.Text = "0";
            textBoxK22.Text = "0";
            textBoxK23.Text = "0";
            textBoxK31.Text = "1";
            textBoxK32.Text = "1";
            textBoxK33.Text = "1";
            textBoxFaktor.Text = "1";
            textBoxOffset.Text = "127";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureAsli.Image = (Bitmap)bmpOriginal.Clone();
            pictureHasil.Image = (Bitmap)bmpOriginal.Clone();
        }
    }
}
