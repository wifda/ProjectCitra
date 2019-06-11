using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citra
{
    public partial class Form5 : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xbw = 0;
                    if (xg >= 128) xbw = 255;
                    Color wb = Color.FromArgb(xbw, xbw, xbw);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 16 * (int)(xg / 16);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 32 * (int)(xg / 32);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 64 * (int)(xg / 64);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
