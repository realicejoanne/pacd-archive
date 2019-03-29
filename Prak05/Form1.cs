using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bgType.SelectedIndex = 0;
            bmpOriginal = (Bitmap)pictureAsli.Image.Clone();
            bmpEdit = (Bitmap)pictureAsli.Image.Clone();
        }

        Bitmap bmpOriginal, bmpEdit;

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
                bmpEdit = (Bitmap)pictureAsli.Image.Clone();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureAsli.Image = (Bitmap)bmpOriginal.Clone();
            pictureHasil.Image = (Bitmap)bmpOriginal.Clone();
        }

        //Filtering
        public static Bitmap Median(Bitmap b)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
                        List<int> data1 = new List<int>();
                        data1.Add(pSrc[2]);
                        data1.Add(pSrc[5]);
                        data1.Add(pSrc[8]);
                        data1.Add(pSrc[2 + stride]);
                        data1.Add(pSrc[5 + stride]);
                        data1.Add(pSrc[8 + stride]);
                        data1.Add(pSrc[2 + stride2]);
                        data1.Add(pSrc[5 + stride2]);
                        data1.Add(pSrc[8 + stride2]);
                        data1.Sort();

                        nPixel = data1.ElementAt(5);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[1]);
                        data1.Add(pSrc[4]);
                        data1.Add(pSrc[7]);
                        data1.Add(pSrc[1 + stride]);
                        data1.Add(pSrc[4 + stride]);
                        data1.Add(pSrc[7 + stride]);
                        data1.Add(pSrc[1 + stride2]);
                        data1.Add(pSrc[4 + stride2]);
                        data1.Add(pSrc[7 + stride2]);
                        data1.Sort();

                        nPixel = data1.ElementAt(5);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[0]);
                        data1.Add(pSrc[3]);
                        data1.Add(pSrc[6]);
                        data1.Add(pSrc[0 + stride]);
                        data1.Add(pSrc[3 + stride]);
                        data1.Add(pSrc[6 + stride]);
                        data1.Add(pSrc[0 + stride2]);
                        data1.Add(pSrc[3 + stride2]);
                        data1.Add(pSrc[6 + stride2]);
                        data1.Sort();

                        nPixel = data1.ElementAt(5);
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
        public static Bitmap Average(Bitmap b)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
                        List<int> data1 = new List<int>();
                        data1.Add(pSrc[2]);
                        data1.Add(pSrc[5]);
                        data1.Add(pSrc[8]);
                        data1.Add(pSrc[2 + stride]);
                        data1.Add(pSrc[5 + stride]);
                        data1.Add(pSrc[8 + stride]);
                        data1.Add(pSrc[2 + stride2]);
                        data1.Add(pSrc[5 + stride2]);
                        data1.Add(pSrc[8 + stride2]);
                        nPixel = (int)data1.Average();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[1]);
                        data1.Add(pSrc[4]);
                        data1.Add(pSrc[7]);
                        data1.Add(pSrc[1 + stride]);
                        data1.Add(pSrc[4 + stride]);
                        data1.Add(pSrc[7 + stride]);
                        data1.Add(pSrc[1 + stride2]);
                        data1.Add(pSrc[4 + stride2]);
                        data1.Add(pSrc[7 + stride2]);
                        nPixel = (int)data1.Average();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[0]);
                        data1.Add(pSrc[3]);
                        data1.Add(pSrc[6]);
                        data1.Add(pSrc[0 + stride]);
                        data1.Add(pSrc[3 + stride]);
                        data1.Add(pSrc[6 + stride]);
                        data1.Add(pSrc[0 + stride2]);
                        data1.Add(pSrc[3 + stride2]);
                        data1.Add(pSrc[6 + stride2]);
                        nPixel = (int)data1.Average();
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
        public static Bitmap Max(Bitmap b)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
                        List<int> data1 = new List<int>();
                        data1.Add(pSrc[2]);
                        data1.Add(pSrc[5]);
                        data1.Add(pSrc[8]);
                        data1.Add(pSrc[2 + stride]);
                        data1.Add(pSrc[5 + stride]);
                        data1.Add(pSrc[8 + stride]);
                        data1.Add(pSrc[2 + stride2]);
                        data1.Add(pSrc[5 + stride2]);
                        data1.Add(pSrc[8 + stride2]);
                        nPixel = (int)data1.Max();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[1]);
                        data1.Add(pSrc[4]);
                        data1.Add(pSrc[7]);
                        data1.Add(pSrc[1 + stride]);
                        data1.Add(pSrc[4 + stride]);
                        data1.Add(pSrc[7 + stride]);
                        data1.Add(pSrc[1 + stride2]);
                        data1.Add(pSrc[4 + stride2]);
                        data1.Add(pSrc[7 + stride2]);
                        nPixel = (int)data1.Max();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[0]);
                        data1.Add(pSrc[3]);
                        data1.Add(pSrc[6]);
                        data1.Add(pSrc[0 + stride]);
                        data1.Add(pSrc[3 + stride]);
                        data1.Add(pSrc[6 + stride]);
                        data1.Add(pSrc[0 + stride2]);
                        data1.Add(pSrc[3 + stride2]);
                        data1.Add(pSrc[6 + stride2]);
                        nPixel = (int)data1.Max();
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
        public static Bitmap Min(Bitmap b)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
                        List<int> data1 = new List<int>();
                        data1.Add(pSrc[2]);
                        data1.Add(pSrc[5]);
                        data1.Add(pSrc[8]);
                        data1.Add(pSrc[2 + stride]);
                        data1.Add(pSrc[5 + stride]);
                        data1.Add(pSrc[8 + stride]);
                        data1.Add(pSrc[2 + stride2]);
                        data1.Add(pSrc[5 + stride2]);
                        data1.Add(pSrc[8 + stride2]);
                        nPixel = (int)data1.Min();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[1]);
                        data1.Add(pSrc[4]);
                        data1.Add(pSrc[7]);
                        data1.Add(pSrc[1 + stride]);
                        data1.Add(pSrc[4 + stride]);
                        data1.Add(pSrc[7 + stride]);
                        data1.Add(pSrc[1 + stride2]);
                        data1.Add(pSrc[4 + stride2]);
                        data1.Add(pSrc[7 + stride2]);
                        nPixel = (int)data1.Min();
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;
                        data1.Clear();
                        data1.Add(pSrc[0]);
                        data1.Add(pSrc[3]);
                        data1.Add(pSrc[6]);
                        data1.Add(pSrc[0 + stride]);
                        data1.Add(pSrc[3 + stride]);
                        data1.Add(pSrc[6 + stride]);
                        data1.Add(pSrc[0 + stride2]);
                        data1.Add(pSrc[3 + stride2]);
                        data1.Add(pSrc[6 + stride2]);
                        nPixel = (int)data1.Min();
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
        
        private void btnFiltering_Click(object sender, EventArgs e)
        {
            Bitmap source = new Bitmap(pictureAsli.Image);

            //Median
            if (filtering.SelectedIndex == 0)
            {
                Bitmap bmp = Median(source);
                pictureHasil.Image = bmp;
            }
            //Average
            else if (filtering.SelectedIndex == 1)
            {
                Bitmap bmp = Average(source);
                pictureHasil.Image = bmp;
            }
            //Maximum
            else if (filtering.SelectedIndex == 2)
            {
                Bitmap bmp = Max(source);
                pictureHasil.Image = bmp;
            }
            //Minimum
            else if (filtering.SelectedIndex == 3)
            {
                Bitmap bmp = Min(source);
                pictureHasil.Image = bmp;
            }
            else
            {
                pictureHasil.Image = (Bitmap)bmpOriginal.Clone();
            }
        }

        //Masking 3x3
        private void btnMErosi_Click(object sender, EventArgs e)
        {
            if (bgType.SelectedIndex == 0) ProcessDilation();
            if (bgType.SelectedIndex == 1) ProcessErosion();
        }
        private void btnMDilasi_Click(object sender, EventArgs e)
        {
            if (bgType.SelectedIndex == 0) ProcessErosion();
            if (bgType.SelectedIndex == 1) ProcessDilation();
        }

        public void gray_Erosion(byte[,] sele)
        {
            Bitmap tempbmp = (Bitmap)bmpEdit.Clone();

            BitmapData data2 = tempbmp.LockBits(new Rectangle(0, 0, tempbmp.Width, tempbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData data = bmpEdit.LockBits(new Rectangle(0, 0, bmpEdit.Width, bmpEdit.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            byte[,] sElement = sele;

            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                byte* tptr = (byte*)data2.Scan0;

                ptr += data.Stride + 3;
                tptr += data.Stride + 3;

                int remain = data.Stride - data.Width * 3;

                for (int i = 1; i < data.Height - 1; i++)
                {
                    for (int j = 1; j < data.Width - 1; j++)
                    {
                        byte* temp = ptr - data.Stride - 3;
                        byte min = 255;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (min > temp[data.Stride * k + l * 3])
                                {
                                    if (sElement[k, l] != 0)
                                        min = temp[data.Stride * k + l * 3];
                                }
                            }
                        }

                        tptr[0] = tptr[1] = tptr[2] = min;
                        ptr += 3;
                        tptr += 3;
                    }
                    ptr += remain + 6;
                    tptr += remain + 6;
                }
            }

            bmpEdit.UnlockBits(data);
            tempbmp.UnlockBits(data2);

            bmpEdit = (Bitmap)tempbmp.Clone();
        }
        public void gray_Dilation(byte[,] sele)
        {
            Bitmap tempbmp = (Bitmap)this.bmpEdit.Clone();

            BitmapData data2 = tempbmp.LockBits(new Rectangle(0, 0, tempbmp.Width, tempbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData data = bmpEdit.LockBits(new Rectangle(0, 0, bmpEdit.Width, bmpEdit.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            byte[,] sElement = sele;

            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                byte* tptr = (byte*)data2.Scan0;

                ptr += data.Stride + 3;
                tptr += data.Stride + 3;

                int remain = data.Stride - data.Width * 3;

                for (int i = 1; i < data.Height - 1; i++)
                {
                    for (int j = 1; j < data.Width - 1; j++)
                    {
                        byte* temp = ptr - data.Stride - 3;
                        byte min = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (min < temp[data.Stride * k + l * 3])
                                {
                                    if (sElement[k, l] != 0)
                                        min = temp[data.Stride * k + l * 3];
                                }
                            }
                        }

                        tptr[0] = tptr[1] = tptr[2] = min;
                        ptr += 3;
                        tptr += 3;
                    }
                    ptr += remain + 6;
                    tptr += remain + 6;
                }
            }

            bmpEdit.UnlockBits(data);
            tempbmp.UnlockBits(data2);

            bmpEdit = (Bitmap)tempbmp.Clone();
        }

        private void ProcessErosion()
        {
            byte[,] sele = new byte[3, 3];
            try
            {
                sele[0, 0] = (byte)Int32.Parse(textBoxK11.Text);
                sele[0, 1] = (byte)Int32.Parse(textBoxK12.Text);
                sele[0, 2] = (byte)Int32.Parse(textBoxK13.Text);
                sele[1, 0] = (byte)Int32.Parse(textBoxK21.Text);
                sele[1, 1] = (byte)Int32.Parse(textBoxK22.Text);
                sele[1, 2] = (byte)Int32.Parse(textBoxK23.Text);
                sele[2, 0] = (byte)Int32.Parse(textBoxK31.Text);
                sele[2, 1] = (byte)Int32.Parse(textBoxK32.Text);
                sele[2, 2] = (byte)Int32.Parse(textBoxK33.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unimpliable Mask");
            }

            gray_Erosion(sele);
            pictureHasil.Image = (Bitmap)bmpEdit.Clone();
            Image picture = pictureHasil.Image;
        }
        private void ProcessDilation()
        {
            byte[,] sele = new byte[3, 3];
            try
            {
                sele[0, 0] = (byte)Int32.Parse(textBoxK11.Text);
                sele[0, 1] = (byte)Int32.Parse(textBoxK12.Text);
                sele[0, 2] = (byte)Int32.Parse(textBoxK13.Text);
                sele[1, 0] = (byte)Int32.Parse(textBoxK21.Text);
                sele[1, 1] = (byte)Int32.Parse(textBoxK22.Text);
                sele[1, 2] = (byte)Int32.Parse(textBoxK23.Text);
                sele[2, 0] = (byte)Int32.Parse(textBoxK31.Text);
                sele[2, 1] = (byte)Int32.Parse(textBoxK32.Text);
                sele[2, 2] = (byte)Int32.Parse(textBoxK33.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unimpliable Mask");
            }
            gray_Dilation(sele);
            pictureHasil.Image = (Bitmap)bmpEdit.Clone();
            Image picture = pictureHasil.Image;
        }

        private void rMBox_CheckedChanged(object sender, EventArgs e)
        {
            rMPlus.Checked = false;
            rMCross.Checked = false;
            rMRing.Checked = false;
            rMDot.Checked = false;
            textBoxK11.Text = "1";
            textBoxK12.Text = "1";
            textBoxK13.Text = "1";
            textBoxK21.Text = "1";
            textBoxK22.Text = "1";
            textBoxK23.Text = "1";
            textBoxK31.Text = "1";
            textBoxK32.Text = "1";
            textBoxK33.Text = "1";
        }
        private void rMPlus_CheckedChanged(object sender, EventArgs e)
        {
            rMBox.Checked = false;
            rMCross.Checked = false;
            rMRing.Checked = false;
            rMDot.Checked = false;
            textBoxK11.Text = "0";
            textBoxK12.Text = "1";
            textBoxK13.Text = "0";
            textBoxK21.Text = "1";
            textBoxK22.Text = "1";
            textBoxK23.Text = "1";
            textBoxK31.Text = "0";
            textBoxK32.Text = "1";
            textBoxK33.Text = "0";
        }
        private void rMCross_CheckedChanged(object sender, EventArgs e)
        {
            rMBox.Checked = false;
            rMPlus.Checked = false;
            rMRing.Checked = false;
            rMDot.Checked = false;
            textBoxK11.Text = "1";
            textBoxK12.Text = "0";
            textBoxK13.Text = "1";
            textBoxK21.Text = "0";
            textBoxK22.Text = "1";
            textBoxK23.Text = "0";
            textBoxK31.Text = "1";
            textBoxK32.Text = "0";
            textBoxK33.Text = "1";
        }
        private void rMRing_CheckedChanged(object sender, EventArgs e)
        {
            rMPlus.Checked = false;
            rMCross.Checked = false;
            rMBox.Checked = false;
            rMDot.Checked = false;
            textBoxK11.Text = "1";
            textBoxK12.Text = "1";
            textBoxK13.Text = "1";
            textBoxK21.Text = "1";
            textBoxK22.Text = "0";
            textBoxK23.Text = "1";
            textBoxK31.Text = "1";
            textBoxK32.Text = "1";
            textBoxK33.Text = "1";
        }
        private void rMDot_CheckedChanged(object sender, EventArgs e)
        {
            rMPlus.Checked = false;
            rMCross.Checked = false;
            rMRing.Checked = false;
            rMBox.Checked = false;
            textBoxK11.Text = "0";
            textBoxK12.Text = "0";
            textBoxK13.Text = "0";
            textBoxK21.Text = "0";
            textBoxK22.Text = "1";
            textBoxK23.Text = "0";
            textBoxK31.Text = "0";
            textBoxK32.Text = "0";
            textBoxK33.Text = "0";
        }
    }
}
