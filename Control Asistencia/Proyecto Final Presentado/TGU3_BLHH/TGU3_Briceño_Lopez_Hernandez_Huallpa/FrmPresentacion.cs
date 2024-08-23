using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGU3_Briceño_Lopez_Hernandez_Huallpa.DataClases;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa
{
    public partial class FrmPresentacion : Form
    {
        string Usu, Pas;
        public FrmPresentacion()
        {
            InitializeComponent();
        }
        public bool ValidarUsuario(string Usuario, String Password)
        {
            DataClasesResumenDataContext dc = new DataClasesResumenDataContext();
            var query = new List<SP_LoginUsuarioResult>();
            query = dc.SP_LoginUsuario(Usuario, Password).ToList();
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usu = txtUsuario.Text;
            Pas = txtPassword.Text;

            if (ValidarUsuario(Usu, Pas))
            {
                MessageBox.Show("Bienvenido Administrador " + Usu, " Login de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMenu Frm = new FrmMenu();
                this.Hide();
                Frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Password incorrectos..." + Usu, "Login de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmMenu Frm = new FrmMenu();
            }
        }
    }
}
