using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Citra
{
    public partial class Form1 : Form
    {
        Image File;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = File;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                File.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }
    }
}
