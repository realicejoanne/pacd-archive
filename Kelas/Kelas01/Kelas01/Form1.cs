using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelas01
{
    public partial class Form1 : Form
    {
        int mouseClick = 0;
        int x1, y1, x2, y2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Image File (*.jpg; *bmp) for dialog text
            //After separator, the allowed extensions are inputted !important
            open.Filter = "Image File (*.jpg; *.bmp) | *.jpg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double euclidian, manhattan, chessboard;
            Cursor = Cursors.Cross;

            if (mouseClick == 0)
            {
                MouseEventArgs mc = (MouseEventArgs)e;
                base.OnMouseHover(mc);
                x1 = mc.X;
                y1 = mc.Y;

                textBoxX1.Text = x1.ToString();
                textBoxY1.Text = y1.ToString();
                mouseClick = 1;
            }
            else if (mouseClick == 1)
            {
                MouseEventArgs mc = (MouseEventArgs)e;
                base.OnMouseHover(mc);
                x2 = mc.X;
                y2 = mc.Y;

                textBoxX2.Text = x2.ToString();
                textBoxY2.Text = y2.ToString();
                mouseClick = 0;

                euclidian = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                manhattan = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                chessboard = Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                textBoxEuc.Text = euclidian.ToString();
                textBoxMan.Text = manhattan.ToString();
                textBoxChe.Text = chessboard.ToString();
            }
        }
    }
}
