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
    public partial class Form7 : Form
    {
        Bitmap objBitmap;
        public Form7()
        {
            InitializeComponent();
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

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void Button3_Click(object sender, EventArgs e)
        {
            float[] h = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[i]);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            float[] h = new float[256];
            float[] c = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++) c[i] = c[i - 1] + h[i];
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, c[i]);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
