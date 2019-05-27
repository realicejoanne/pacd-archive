using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Direction
using Emgu.CV;
using Emgu.CV.Structure;

namespace Kelas08
{
    public partial class Form1 : Form
    {
        //Definisi global
        VideoCapture grabber;
        Image<Bgr, Byte> ImageFrame, img;

        public Form1()
        {
            InitializeComponent();
        }

        //Button
        private void button1_Click(object sender, EventArgs e)
        {
            grabber = new VideoCapture();
            Application.Idle += ProsesFrame;
        }

        private void ProsesFrame(object sender, EventArgs arg)
        {
            ImageFrame = grabber.QueryFrame().ToImage<Bgr, Byte>();
            img = ImageFrame.Clone();

            //Gray
            if (radioButton2.Checked)
            {
                //Set gray
                for (int v = 0; v < img.Height; v++)
                {
                    for (int h = 0; h < img.Width; h++)
                    {
                        byte blue = img.Data[v, h, 0];
                        byte green = img.Data[v, h, 1];
                        byte red = img.Data[v, h, 2];

                        float result = (blue + green + red) / 3;

                        img.Data[v, h, 0] = (byte)result;
                        img.Data[v, h, 1] = (byte)result;
                        img.Data[v, h, 2] = (byte)result;
                    }
                }
            }

            //Biner
            if (radioButton3.Checked)
            {
                //Set binary
                float sum;
                float result;

                for (int v = 0; v < img.Height; v++)
                {
                    for (int h = 0; h < img.Width; h++)
                    {
                        byte blue = img.Data[v, h, 0];
                        byte green = img.Data[v, h, 1];
                        byte red = img.Data[v, h, 2];

                        sum = (blue + green + red);
                        if (sum >= 128)
                            result = 255;
                        else
                            result = 0;

                        img.Data[v, h, 0] = (byte)result;
                        img.Data[v, h, 1] = (byte)result;
                        img.Data[v, h, 2] = (byte)result;
                    }
                }
            }

            imageBox1.Image = img;
        }

    }
}
