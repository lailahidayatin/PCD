using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas
{
    public partial class Form1 : Form
    {
        public static int brightnessValue, contrastValue, logBrightnessValue, logContrassValue;
        public Form1()
        {
            InitializeComponent();
        }
        private static int truncate(int x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }
        private static double truncate(double x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog buka = new OpenFileDialog();
            buka.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            if (DialogResult.OK == buka.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(buka.FileName);
            }
        }

        private void circle5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                Bitmap c = new Bitmap((Bitmap)this.pbInput.Image);
                int[,] H = new int[,] { { 1, 1, 0, 1, 1 }, { 1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 }, { 1, 1, 0, 1, 1 } };
                int R;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                // THRESHOLD
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        R = c.GetPixel(i, j).R;
                        if (R < 128)
                        {
                            R = 0;
                        }
                        else
                        {
                            R = 255;
                        }
                        c.SetPixel(i, j, Color.FromArgb(R, R, R));
                    }
                }
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        R = c.GetPixel(i, j).R;
                        if (R == 0)
                        {
                            for (int k1 = -1; k1 < 1; k1++)
                            {
                                for (int k2 = -1; k2 < 1; k2++)
                                {
                                    if ((i + k1) < b.Width && (j + k2) < b.Height && (i + k1) >= 0 && (j + k2) >= 0)
                                    {
                                        if (H[k1 + 1, k2 + 1] != 1)
                                        {
                                            R = 255 * (H[k1 + 1, k2 + 1] & c.GetPixel(i + k1, j + k2).R);
                                            b.SetPixel(i + k1, j + k2, Color.FromArgb(R, R, R));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                this.pbOutput.Image = b;
                //this.pbOutput.Image = c;
            }
        }

        private void square3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                Bitmap c = new Bitmap((Bitmap)this.pbInput.Image);
                int[,] H = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                int R;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                // THRESHOLD
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        R = c.GetPixel(i, j).R;
                        if (R < 128)
                        {
                            R = 0;
                        }
                        else
                        {
                            R = 255;
                        }
                        c.SetPixel(i, j, Color.FromArgb(R, R, R));
                    }
                }
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        R = c.GetPixel(i, j).R;
                        if (R == 0)
                        {
                            for (int k1 = -1; k1 < 1; k1++)
                            {
                                for (int k2 = -1; k2 < 1; k2++)
                                {
                                    if ((i + k1) < b.Width && (j + k2) < b.Height && (i + k1) >= 0 && (j + k2) >= 0)
                                    {
                                        R = 255 * (H[k1 + 1, k2 + 1] & b.GetPixel(i + k1, j + k2).R);
                                        b.SetPixel(i + k1, j + k2, Color.FromArgb(R, R, R));
                                    }
                                }
                            }
                        }
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                //this.pbOutput.Image = c;
                this.pbOutput.Image = b;
            }
        }
        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            }
            else
            {
                SaveFileDialog simpan = new SaveFileDialog();
                simpan.Title = "Simpan File Citra";
                simpan.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == simpan.ShowDialog())
                    this.pbOutput.Image.Save(simpan.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
