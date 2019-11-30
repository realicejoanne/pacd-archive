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

namespace Tugas101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Change Image
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Image File (*.jpg; *bmp) for dialog text
            //After separator, the allowed extensions are inputted !important
            open.Filter = "Image File (*.jpg; *.bmp) | *.jpg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureAsli.Image = new Bitmap(open.FileName);
                pictureHasil.Image = new Bitmap(open.FileName);
            }
        }

        //Brightness
        Bitmap bmpAsli, bmpHasil;

        private void buttonBright_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(textBoxBright.Text);
            int i, j;
            int nilaiR, nilaiG, nilaiB;
            bmpAsli = (Bitmap)pictureAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (i = 0; i < baris; i++)
            {
                for (j = 0; j < kolom; j++)
                {
                    nilaiR = bmpAsli.GetPixel(i, j).R + k;
                    nilaiG = bmpAsli.GetPixel(i, j).G + k;
                    nilaiB = bmpAsli.GetPixel(i, j).B + k;
                    if (nilaiR > 255) nilaiR = 255;
                    if (nilaiG > 255) nilaiG = 255;
                    if (nilaiB > 255) nilaiB = 255;
                    if (nilaiR < 0) nilaiR = 0;
                    if (nilaiG < 0) nilaiG = 0;
                    if (nilaiB < 0) nilaiB = 0;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(nilaiR, nilaiG, nilaiB));
                }
                pictureHasil.Image = bmpHasil;
                Cursor = Cursors.Default;
            }
        }

        //Thresholding
        private void buttonThres_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(textBoxThres.Text);
            int i, j;
            int nilaiR, nilaiG, nilaiB;
            bmpAsli = (Bitmap)pictureAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (i = 0; i < baris; i++)
            {
                for (j = 0; j < kolom; j++)
                {
                    if (bmpAsli.GetPixel(i, j).R >= k) nilaiR = 255;
                    else nilaiR = 0;
                    if (bmpAsli.GetPixel(i, j).G >= k) nilaiG = 255;
                    else nilaiG = 0;
                    if (bmpAsli.GetPixel(i, j).B >= k) nilaiB = 255;
                    else nilaiB = 0;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(nilaiR, nilaiG, nilaiB));
                }
            }
            pictureHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }

        //Invert
        private void buttonInv_Click(object sender, EventArgs e)
        {
            int i, j;
            int nilaiR, nilaiG, nilaiB;
            bmpAsli = (Bitmap)pictureAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (i = 0; i < baris; i++)
            {
                for (j = 0; j < kolom; j++)
                {
                    nilaiR = 255 - bmpAsli.GetPixel(i, j).R;
                    nilaiG = 255 - bmpAsli.GetPixel(i, j).G;
                    nilaiB = 255 - bmpAsli.GetPixel(i, j).B;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(nilaiR, nilaiG, nilaiB));
                }
            }
            pictureHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }

        //Grayscale-Perataan
        private void buttonGrayjust_Click(object sender, EventArgs e)
        {
            int i, j, k;
            bmpAsli = (Bitmap)pictureAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (i = 0; i < baris; i++)
            {
                for (j = 0; j < kolom; j++)
                {
                    k = (bmpAsli.GetPixel(i, j).R + bmpAsli.GetPixel(i, j).G + bmpAsli.GetPixel(i, j).B) / 3;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(k, k, k));
                }
            }
            pictureHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }

        //Grayscale Pembobotan
        private void buttonGrayweight_Click(object sender, EventArgs e)
        {
            int i, j, k;
            float key;
            bmpAsli = (Bitmap)pictureAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (i = 0; i < baris; i++)
            {
                for (j = 0; j < kolom; j++)
                {
                    key = ((bmpAsli.GetPixel(i, j).R * 0.299F) + (bmpAsli.GetPixel(i, j).G * 0.587F) + (bmpAsli.GetPixel(i, j).B) * 0.114F);
                    k = (int) key;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(k, k, k));
                }
            }

            pictureHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }

        //Grayscale Pointer
        private void buttonGrayPoint_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;
            Konversi2GreyViaPointer(bmpAsli);
            pictureHasil.Image = bmpAsli;
        }

        private void Konversi2GreyViaPointer(Bitmap bmpAsli)
        {   
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpAsli.Width, bmpAsli.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
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
        }
    }
}

