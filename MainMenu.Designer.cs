namespace Citra
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membacaDanMenyimpanFileGambarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membacaDataGambarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulasiRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuantisasiDataCitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramCitraDerajatKeabuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konvolusiImageFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiseReductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deteksiTepiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 453);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.advanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membacaDanMenyimpanFileGambarToolStripMenuItem,
            this.membacaDataGambarToolStripMenuItem});
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.basicToolStripMenuItem.Text = "Basic";
            // 
            // membacaDanMenyimpanFileGambarToolStripMenuItem
            // 
            this.membacaDanMenyimpanFileGambarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("membacaDanMenyimpanFileGambarToolStripMenuItem.Image")));
            this.membacaDanMenyimpanFileGambarToolStripMenuItem.Name = "membacaDanMenyimpanFileGambarToolStripMenuItem";
            this.membacaDanMenyimpanFileGambarToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.membacaDanMenyimpanFileGambarToolStripMenuItem.Text = "Membaca dan Menyimpan File Gambar";
            this.membacaDanMenyimpanFileGambarToolStripMenuItem.Click += new System.EventHandler(this.MembacaDanMenyimpanFileGambarToolStripMenuItem_Click);
            // 
            // membacaDataGambarToolStripMenuItem
            // 
            this.membacaDataGambarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("membacaDataGambarToolStripMenuItem.Image")));
            this.membacaDataGambarToolStripMenuItem.Name = "membacaDataGambarToolStripMenuItem";
            this.membacaDataGambarToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.membacaDataGambarToolStripMenuItem.Text = "Membaca Data Gambar";
            this.membacaDataGambarToolStripMenuItem.Click += new System.EventHandler(this.MembacaDataGambarToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manipulasiRGBToolStripMenuItem,
            this.kuantisasiDataCitraToolStripMenuItem,
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem,
            this.histogramCitraDerajatKeabuanToolStripMenuItem,
            this.histogramEqualizationToolStripMenuItem});
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // manipulasiRGBToolStripMenuItem
            // 
            this.manipulasiRGBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manipulasiRGBToolStripMenuItem.Image")));
            this.manipulasiRGBToolStripMenuItem.Name = "manipulasiRGBToolStripMenuItem";
            this.manipulasiRGBToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.manipulasiRGBToolStripMenuItem.Text = "Manipulasi RGB";
            this.manipulasiRGBToolStripMenuItem.Click += new System.EventHandler(this.ManipulasiRGBToolStripMenuItem_Click);
            // 
            // kuantisasiDataCitraToolStripMenuItem
            // 
            this.kuantisasiDataCitraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kuantisasiDataCitraToolStripMenuItem.Image")));
            this.kuantisasiDataCitraToolStripMenuItem.Name = "kuantisasiDataCitraToolStripMenuItem";
            this.kuantisasiDataCitraToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.kuantisasiDataCitraToolStripMenuItem.Text = "Kuantisasi Data Citra";
            this.kuantisasiDataCitraToolStripMenuItem.Click += new System.EventHandler(this.KuantisasiDataCitraToolStripMenuItem_Click);
            // 
            // pengolahanCitraDerajatKeabuanToolStripMenuItem
            // 
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pengolahanCitraDerajatKeabuanToolStripMenuItem.Image")));
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem.Name = "pengolahanCitraDerajatKeabuanToolStripMenuItem";
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem.Text = "Pengolahan Citra Derajat Keabuan";
            this.pengolahanCitraDerajatKeabuanToolStripMenuItem.Click += new System.EventHandler(this.PengolahanCitraDerajatKeabuanToolStripMenuItem_Click);
            // 
            // histogramCitraDerajatKeabuanToolStripMenuItem
            // 
            this.histogramCitraDerajatKeabuanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("histogramCitraDerajatKeabuanToolStripMenuItem.Image")));
            this.histogramCitraDerajatKeabuanToolStripMenuItem.Name = "histogramCitraDerajatKeabuanToolStripMenuItem";
            this.histogramCitraDerajatKeabuanToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.histogramCitraDerajatKeabuanToolStripMenuItem.Text = "Histogram Citra Derajat Keabuan";
            this.histogramCitraDerajatKeabuanToolStripMenuItem.Click += new System.EventHandler(this.HistogramCitraDerajatKeabuanToolStripMenuItem_Click);
            // 
            // histogramEqualizationToolStripMenuItem
            // 
            this.histogramEqualizationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("histogramEqualizationToolStripMenuItem.Image")));
            this.histogramEqualizationToolStripMenuItem.Name = "histogramEqualizationToolStripMenuItem";
            this.histogramEqualizationToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.histogramEqualizationToolStripMenuItem.Text = "Histogram Equalization";
            this.histogramEqualizationToolStripMenuItem.Click += new System.EventHandler(this.HistogramEqualizationToolStripMenuItem_Click);
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konvolusiImageFilteringToolStripMenuItem,
            this.imageNoiseToolStripMenuItem,
            this.noiseReductionToolStripMenuItem,
            this.deteksiTepiToolStripMenuItem,
            this.sharpnessToolStripMenuItem});
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.advanceToolStripMenuItem.Text = "Advance";
            // 
            // konvolusiImageFilteringToolStripMenuItem
            // 
            this.konvolusiImageFilteringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konvolusiImageFilteringToolStripMenuItem.Image")));
            this.konvolusiImageFilteringToolStripMenuItem.Name = "konvolusiImageFilteringToolStripMenuItem";
            this.konvolusiImageFilteringToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.konvolusiImageFilteringToolStripMenuItem.Text = "Konvolusi & Image Filtering";
            this.konvolusiImageFilteringToolStripMenuItem.Click += new System.EventHandler(this.KonvolusiImageFilteringToolStripMenuItem_Click);
            // 
            // imageNoiseToolStripMenuItem
            // 
            this.imageNoiseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageNoiseToolStripMenuItem.Image")));
            this.imageNoiseToolStripMenuItem.Name = "imageNoiseToolStripMenuItem";
            this.imageNoiseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.imageNoiseToolStripMenuItem.Text = "Image Noise";
            this.imageNoiseToolStripMenuItem.Click += new System.EventHandler(this.ImageNoiseToolStripMenuItem_Click);
            // 
            // noiseReductionToolStripMenuItem
            // 
            this.noiseReductionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noiseReductionToolStripMenuItem.Image")));
            this.noiseReductionToolStripMenuItem.Name = "noiseReductionToolStripMenuItem";
            this.noiseReductionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.noiseReductionToolStripMenuItem.Text = "Noise Reduction";
            this.noiseReductionToolStripMenuItem.Click += new System.EventHandler(this.NoiseReductionToolStripMenuItem_Click);
            // 
            // deteksiTepiToolStripMenuItem
            // 
            this.deteksiTepiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deteksiTepiToolStripMenuItem.Image")));
            this.deteksiTepiToolStripMenuItem.Name = "deteksiTepiToolStripMenuItem";
            this.deteksiTepiToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.deteksiTepiToolStripMenuItem.Text = "Deteksi Tepi";
            this.deteksiTepiToolStripMenuItem.Click += new System.EventHandler(this.DeteksiTepiToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sharpnessToolStripMenuItem.Image")));
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.SharpnessToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wifda M. F.  2110171002";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Linda Lailatus S.  2110171005";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(30, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CopyRight@2019";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(704, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(704, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(704, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membacaDanMenyimpanFileGambarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membacaDataGambarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulasiRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuantisasiDataCitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengolahanCitraDerajatKeabuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramCitraDerajatKeabuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konvolusiImageFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiseReductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deteksiTepiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}