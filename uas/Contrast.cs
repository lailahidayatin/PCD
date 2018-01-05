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
    public partial class Contrast : Form
    {
        public Contrast()
        {
            InitializeComponent();
        }

        private void tbOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hscContrast_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hscContrast_ValueChanged(object sender, EventArgs e)
        {
            tbContrast.Text = hscContrast.Value.ToString();
        }

        private void Contrast_Load(object sender, EventArgs e)
        {
            hscContrast.Value = Form1.contrastValue;
            tbContrast.Text = hscContrast.Value.ToString();
        }
    }
}
