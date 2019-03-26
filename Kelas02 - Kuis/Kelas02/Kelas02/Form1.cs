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

        Bitmap result, process;
        int thresMin;
        double eucMin;

        private void buttonE_Click(object sender, EventArgs e)
        {
            process = new Bitmap(pictureAsli.Image);
            result = new Bitmap(pictureHasil.Image);
            int thres = Convert.ToInt16(textBoxT.Text);
            int i, j, k, l;
            double jarak, hasil, sum = 0;

            Cursor = Cursors.WaitCursor;

            //Grayscale Perataan
            for (i = 0; i < 1881; i++)
            {
                for (j = 0; j < 455; j++)
                {
                    k = (process.GetPixel(i, j).R + process.GetPixel(i, j).G + process.GetPixel(i, j).B) / 3;
                    process.SetPixel(i, j, Color.FromArgb(k, k, k));
                }
            }

            //Normal Threshold
            for (i = 0; i < 1881; i++)
            {
                for (j = 0; j < 455; j++)
                {
                    k = process.GetPixel(i, j).R;
                    if (k >= thres)
                        l = 255;
                    else
                        l = 0;
                    process.SetPixel(i, j, Color.FromArgb(l, l, l));
                }
            }

            //Euclidean
            for (i = 0; i < 1881; i++)
            {
                for (j = 0; j < 455; j++)
                {
                    jarak = Math.Pow(process.GetPixel(i, j).R - result.GetPixel(i, j).R, 2);
                    sum = sum + jarak;
                }
            }

            pictureHasil.Image = process;

            hasil = Math.Sqrt(sum);
            textBoxE.Text = hasil.ToString();
            
            thresMin = thres;
            eucMin = hasil;
            textBoxS.Text = eucMin.ToString();

            Cursor = Cursors.Default;
        }
    }
}
