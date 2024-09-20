using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCheck Frm = new FrmCheck();
            this.Hide();
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsistenciaE Frm = new FrmAsistenciaE();
            this.Hide();
            Frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAgregarE Frm = new FrmAgregarE();
            this.Hide();
            Frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
