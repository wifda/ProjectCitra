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
    public partial class Form6 : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    objBitmap.SetPixel(x, y, wb);
                }
            pictureBox1.Image = objBitmap;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            int a = Convert.ToInt16(textBox1.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg + a;
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            float c = Convert.ToSingle(textBox2.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(c * xg);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 - xg);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            //Mencari nilai maksimum dan minimum
            int xgmax = 0;
            int xgmin = 255;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    if (xg < xgmin) xgmin = xg;
                    if (xg > xgmax) xgmax = xg;
                }
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * (xg - xgmin) / (xgmax - xgmin));
                    Color wb = Color.FromArgb(xb, xb, xb);
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
