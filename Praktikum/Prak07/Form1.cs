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

namespace Prak07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmpori1, bmpori2;
        int fungsi = 1;

        public static Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        //Processing
        public Bitmap add(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Min((ptr1[0] + ptr2[0]), 255);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap subtraction(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Max((ptr1[0] - ptr2[0]), 0);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap difference(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Abs(ptr1[0] - ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap multiply(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Min((ptr1[0] * ptr2[0]), 255);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap average(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)((ptr1[0] + ptr2[0]) / 2);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap min(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Min(ptr1[0], ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap max(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)Math.Max(ptr1[0], ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap amplitude(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)(Math.Sqrt(Math.Pow(ptr1[0], 2) + Math.Pow(ptr2[0], 2)) / Math.Sqrt(2));
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap AND(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)(ptr1[0] & ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap OR(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)(ptr1[0] | ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap XOR(Bitmap bmp1, Bitmap bmp2)
        {
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)(ptr1[0] ^ ptr2[0]);
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }
        public Bitmap crossFading(Bitmap bmp1, Bitmap bmp2)
        {
            double weight = trkBar.Value / 10.0;
            BitmapData bmpData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmpData1.Width;
            int height = bmpData1.Height;
            Bitmap bmpresult = new Bitmap(width, height);
            BitmapData bmpData3 = bmpresult.LockBits(new Rectangle(0, 0, bmpresult.Width, bmpresult.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int remain1 = bmpData1.Stride - bmpData1.Width * 3;
                int remain2 = bmpData2.Stride - bmpData2.Width * 3;
                int remain3 = bmpData3.Stride - bmpData3.Width * 3;
                byte* ptr1 = (byte*)bmpData1.Scan0;
                byte* ptr2 = (byte*)bmpData2.Scan0;
                byte* ptr3 = (byte*)bmpData3.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width * 3; j++)
                    {
                        ptr3[0] = (byte)(ptr1[0] * weight + ptr2[0] * (1 - weight));
                        ++ptr1;
                        ++ptr2;
                        ++ptr3;
                    }
                    ptr1 += remain1;
                    ptr2 += remain2;
                    ptr3 += remain3;
                }
            }
            bmp1.UnlockBits(bmpData1);
            bmp2.UnlockBits(bmpData2);
            bmpresult.UnlockBits(bmpData3);
            return bmpresult;
        }

        //Buttons
        private void btnSelect1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.png;)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bmpori1 = new Bitmap(open.FileName);
                bmpori1 = resizeImage(bmpori1, new Size(250, 250));
                pic1.Image = bmpori1;
                picHasil.Image = null;
            }
        }
        private void btnSelect2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.png;)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bmpori2 = new Bitmap(open.FileName);
                bmpori2 = resizeImage(bmpori2, new Size(250, 250));
                pic2.Image = bmpori2;
                picHasil.Image = null;
            }
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            Bitmap bmpResult;
            switch (fungsi)
            {
                case 1:
                    {
                        bmpResult = add(bmpori1, bmpori2);
                    }
                    break;
                case 2:
                    {
                        bmpResult = subtraction(bmpori1, bmpori2);
                    }
                    break;
                case 3:
                    {
                        bmpResult = difference(bmpori1, bmpori2);
                    }
                    break;
                case 4:
                    {
                        bmpResult = multiply(bmpori1, bmpori2);
                    }
                    break;
                case 5:
                    {
                        bmpResult = average(bmpori1, bmpori2);
                    }
                    break;
                case 6:
                    {
                        bmpResult = crossFading(bmpori1, bmpori2);
                    }
                    break;
                case 7:
                    {
                        bmpResult = max(bmpori1, bmpori2);
                    }
                    break;
                case 8:
                    {
                        bmpResult = min(bmpori1, bmpori2);
                    }
                    break;
                case 9:
                    {
                        bmpResult = amplitude(bmpori1, bmpori2);
                    }
                    break;
                case 10:
                    {
                        bmpResult = AND(bmpori1, bmpori2);
                    }
                    break;
                case 11:
                    {
                        bmpResult = OR(bmpori1, bmpori2);
                    }
                    break;
                default:
                    {
                        bmpResult = XOR(bmpori1, bmpori2);
                    }
                    break;
            }
            picHasil.Image = bmpResult;
        }

        //Generate
        private void trkBar_Scroll(object sender, EventArgs e)
        {
            txtCross.Text = "0." + trkBar.Value.ToString();
        }
        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 1;
        }
        private void radSub_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 2;
        }
        private void radDif_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 3;
        }
        private void radMul_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 4;
        }
        private void radAvg_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 5;
        }
        private void radCro_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 6;
        }
        private void radMax_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 7;
        }
        private void radMin_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 8;
        }
        private void radAmp_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 9;
        }
        private void radAnd_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 10;
        }
        private void radOr_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 11;
        }
        private void radXor_CheckedChanged(object sender, EventArgs e)
        {
            fungsi = 12;
        }
    }
}
