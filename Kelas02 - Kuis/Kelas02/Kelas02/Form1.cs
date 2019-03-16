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

namespace Kelas02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmpAsli, bmpHasil;

        private void buttonT_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;
            bmpHasil = (Bitmap)pictureHasil.Image;

            ThresholdingViaPointer(bmpHasil);
            pictureHasil.Image = bmpHasil;
        }

        private void ThresholdingViaPointer(Bitmap bmpHasil)
        {
            BitmapData bmData = bmpAsli.LockBits(new Rectangle(0, 0, bmpHasil.Width, bmpHasil.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int nOffset = bmData.Stride - bmData.Width * 3, nVal;
                int nWidth = bmData.Width * 3;
                int nThresholding = Convert.ToInt16(textBox1.Text);

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
                bmpHasil.UnlockBits(bmData);
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)pictureAsli.Image;
            bmpHasil = (Bitmap)pictureHasil.Image;
            
            if (bmpAsli.Width == bmpHasil.Width && bmpAsli.Height == bmpHasil.Height)
            {
                for (int i = 0; i < bmpAsli.Width; i++)
                {
                    for (int j = 0; j < bmpAsli.Height; j++)
                    {
                        pictureAsli = bmpAsli.GetPixel(i, j).ToString();
                        pictureHasil = bmpHasil.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            count2++;
                            flag = false;
                            break;
                        }
                        count1++;
                    }
                }
                if (flag == false)
                    MessageBox.Show("Sorry, Images are not same , " + count2 + " wrong pixels found");
                else
                    MessageBox.Show(" Images are same , " + count1 + " same pixels found and " + count2 + " wrong pixels found");
            }
            else
                MessageBox.Show("can not compare this images");
            this.Dispose();
        }
    }
}
