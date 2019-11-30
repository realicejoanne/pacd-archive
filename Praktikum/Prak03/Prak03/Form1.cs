using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmpAsli, bmpHasil, bmpOriginal;
        bool gray = false;
        Stopwatch sw;

        //Save
        private void buttonReset_Click(object sender, EventArgs e)
        {
            var fd = new SaveFileDialog();
            fd.Filter = "bmp (*.bmp)|*.bmp; | jpg (*.jpg)|*.jpg | png (*.png)|*.png";
            fd.AddExtension = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(fd.FileName).ToUpper())
                {
                    case ".bmp":
                        pictureHasil.Image.Save(fd.FileName, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        pictureHasil.Image.Save(fd.FileName, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        pictureHasil.Image.Save(fd.FileName, ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        //Change
        private void buttonChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Image File (*.jpg; *bmp) for dialog text
            //After separator, the allowed extensions are inputted !important
            open.Filter = "Image File (*.jpg; *.bmp) | *.jpg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureAsli.Image = new Bitmap(open.FileName);
                pictureHasil.Image = new Bitmap(open.FileName);
                bmpOriginal = (Bitmap)pictureAsli.Image;
            }
        }

        //Brightness-Pointer
        private void buttonBright_Click(object sender, EventArgs e)
        {
            if (textBoxBright.Text == "")
            {
                textBoxPM.Text = "Please input brightness value!";
                textBoxPT.Text = "";
            }
            else
            {
                bmpAsli = (Bitmap)pictureAsli.Image;
                //int nBrightness = Convert.ToInt16(textBoxBright.Text);

                gray = false;
                sw = Stopwatch.StartNew();
                BrightnessViaPointer(bmpAsli);
                sw.Stop();

                pictureHasil.Image = bmpAsli;

                long time = sw.ElapsedMilliseconds;
                textBoxPM.Text = "Set Brightness Succeed";
                textBoxPT.Text = String.Format("{0:f} ms", time);
            }
        }
        private void BrightnessViaPointer(Bitmap bmpAsli)
        { 
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int nOffset = bmData.Stride - bmData.Width * 3, nVal;
                int nWidth = bmData.Width * 3;
                int nBrightness = Convert.ToInt16(textBoxBright.Text);

                byte* p = (byte*)bmData.Scan0.ToPointer();
                for (int y = 0; y < bmData.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nVal = p[0] + nBrightness;
                        if (nVal < 0) nVal = 0;
                        if (nVal > 255) nVal = 255;

                        p[0] = (byte)nVal;
                        ++p;
                        ++p;
                        ++p;
                    }
                    p += nOffset;
                }
            }
            bmpAsli.UnlockBits(bmData);
        }

        //Thresholding-Pointer
        private void buttonThres_Click(object sender, EventArgs e)
        {
            if (textBoxThres.Text == "")
            {
                textBoxPM.Text = "Please input thresholding value!";
                textBoxPT.Text = "";
            }
            else
            {
                bmpAsli = (Bitmap)pictureAsli.Image;

                gray = false;
                sw = Stopwatch.StartNew();
                ThresholdingViaPointer(bmpAsli);
                sw.Stop();

                pictureHasil.Image = bmpAsli;

                long time = sw.ElapsedMilliseconds;
                textBoxPM.Text = "Thresholding Succeed";
                textBoxPT.Text = String.Format("{0:f} ms", time);
            }
        }
        private void ThresholdingViaPointer(Bitmap bmpAsli)
        {
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int nOffset = bmData.Stride - bmData.Width * 3, nVal;
                int nWidth = bmData.Width * 3;
                int nThresholding = Convert.ToInt16(textBoxThres.Text);

                byte* p = (byte*)bmData.Scan0.ToPointer();
                for (int y = 0; y < bmData.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nVal = p[0];
                        if (nVal < nThresholding) nVal = 0;
                        if (nVal > nThresholding) nVal = 255;

                        p[0] = (byte)nVal;
                        ++p;
                    }
                    p += nOffset;
                }
                bmpAsli.UnlockBits(bmData);
            }
        }

        //Invert-Pointer
        private void buttonInv_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;

            gray = false;
            sw = Stopwatch.StartNew();
            InvertViaPointer(bmpAsli);
            sw.Stop();

            pictureHasil.Image = bmpAsli;

            long time = sw.ElapsedMilliseconds;
            textBoxPM.Text = "Invert Succeed";
            textBoxPT.Text = String.Format("{0:f} ms", time);
        }
        private void InvertViaPointer(Bitmap bmpAsli)
        {
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int nOffset = bmData.Stride - bmData.Width * 3, nVal;
                int nWidth = bmData.Width * 3;
                byte* p = (byte*)bmData.Scan0.ToPointer();
                for (int y = 0; y < bmData.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nVal = 255 - p[0];
                        p[0] = (byte)nVal;
                        ++p;
                    }
                    p += nOffset;
                }
            }
            bmpAsli.UnlockBits(bmData);
        }

        //Grayscale-Justified-Pointer
        private void buttonGrayjust_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;

            gray = false;
            sw = Stopwatch.StartNew();
            GrayjustViaPointer(bmpAsli);
            sw.Stop();

            long time = sw.ElapsedMilliseconds;
            textBoxPM.Text = "Justified Grayscaling Succeed";
            textBoxPT.Text = String.Format("{0:f} ms", time);
            gray = true;
        }
        private void GrayjustViaPointer(Bitmap bmpAsli)
        {
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                while ((int)p != stopAddress)
                {
                    p[0] = (byte)((p[2] + p[1] + p[0])/3);
                    p[1] = p[0];
                    p[2] = p[0];
                    p += 3;
                }
            }
            bmpAsli.UnlockBits(bmData);
            pictureHasil.Image = bmpAsli;
        }

        //Grayscale-Weighted-Pointer
        private void buttonGrayweight_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;

            gray = false;
            sw = Stopwatch.StartNew();
            GrayweightViaPointer(bmpAsli);
            sw.Stop();

            long time = sw.ElapsedMilliseconds;
            textBoxPM.Text = "BT 601 Grayscaling Succeed";
            textBoxPT.Text = String.Format("{0:f} ms", time);
            gray = true;
        }
        private void GrayweightViaPointer(Bitmap bmpAsli)
        {
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                while ((int)p != stopAddress)
                {
                    p[0] = (byte)(.299 * p[2] + .587 * p[1] + .114 * p[0]);
                    p[1] = p[0];
                    p[2] = p[0];
                    p += 3;
                }
            }
            bmpAsli.UnlockBits(bmData);
            pictureHasil.Image = bmpAsli;
        }
    }
}
