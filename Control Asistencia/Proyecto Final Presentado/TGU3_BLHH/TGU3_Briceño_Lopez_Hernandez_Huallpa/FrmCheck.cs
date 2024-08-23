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
using TGU3_Briceño_Lopez_Hernandez_Huallpa.clases;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa
{
    public partial class FrmCheck : Form
    {
        private static int id = 0;
        private ClsEmpleados Empleados = new ClsEmpleados();
        private ClsAsistencia Asistencias = new ClsAsistencia();



        public FrmCheck()
        {
            InitializeComponent();
            Lista();
        }

        private void Lista()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.DataSource = Asistencias.Listar();
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void ptbMarcarManualmente_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            TimeSpan hora = fecha.TimeOfDay;
            Asistencia objAsistencia = new Asistencia();
            objAsistencia.Nombre = txtNombre.Text;
            objAsistencia.FechaAsistencia = fecha;
            objAsistencia.HoraEntrada = hora;
            objAsistencia.Nombre = txtNombre.Text + txtApellido.Text;
            objAsistencia.IdEmpleado = Convert.ToInt32(txtId.Text);

            Asistencias.Insertar(objAsistencia);
            Limpiar();
            MessageBox.Show("El registro se ha grabado correctamente..", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Lista();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMenu Frm = new FrmMenu();
            this.Hide();
            Frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DateTime fecha = DateTime.Now;
                TimeSpan hora = fecha.TimeOfDay;
                Asistencia objAsistencia = new Asistencia();
                objAsistencia.Nombre = txtNombre.Text;
                objAsistencia.FechaAsistencia = fecha;
                objAsistencia.HoraSalida = hora;
                objAsistencia.Nombre = txtNombre.Text + txtApellido.Text;
                objAsistencia.IdEmpleado = Convert.ToInt32(txtId.Text);

                Asistencias.Insertar(objAsistencia);
                Limpiar();
                MessageBox.Show("El registro se ha grabado correctamente..", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista();
            }
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            //string Buscar;
            //Buscar = txtLista.Text;
            //ConsultaProducto1(Buscar);
        }
    }
}
