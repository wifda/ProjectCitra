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
    public partial class Form4 : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
                    Color wb = Color.FromArgb(r, g, b);
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
                    Color wb = Color.FromArgb(r, 0, 0);
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
                    int g = w.G;
                    Color wb = Color.FromArgb(0, g, 0);
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
                    int b = w.B;
                    Color wb = Color.FromArgb(0, 0, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    Color wb = Color.FromArgb(r, r, r);
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
                    int g = w.G;
                    Color wb = Color.FromArgb(g, g, g);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int b = w.G;
                    Color wb = Color.FromArgb(b, b, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    Color wb = Color.FromArgb((byte)(2*r), (byte)(1.8*r), r);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
