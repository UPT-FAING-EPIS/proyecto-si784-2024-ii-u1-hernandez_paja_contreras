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
    public partial class FrmAgregarE : Form
    {
        private static int id = 0;
        private ClsEmpleados Empleados = new ClsEmpleados();
        public FrmAgregarE()
        {
            InitializeComponent();
            Lista();
        }
        public void ComboEstado()
        {
            cmbEstado.Items.Clear();
            //cmbEstado.ImeMode;

        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbEstado.Text = string.Empty;
        }
        private void Lista()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.DataSource = Empleados.Listar();
        }
        private void Obtener(int id)
        {
            Empleado objCategoria = Empleados.Obtener(id);
            txtNombre.Text = objCategoria.Nombre;
            txtApellido.Text = objCategoria.Apellido;
            cmbEstado.Text = Convert.ToString(objCategoria.Estado);
        }

    


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = new Empleado();
            objEmpleado.Dni = txtDni.Text;
            objEmpleado.Nombre = txtNombre.Text;
            objEmpleado.Apellido = txtApellido.Text;
            objEmpleado.Email = txtEmail.Text;
            objEmpleado.Celular = txtCelular.Text;
            objEmpleado.Direccion = txtDireccion.Text;
            objEmpleado.Estado = Convert.ToChar(cmbEstado.Text);


            Empleados.Insertar(objEmpleado);
            Limpiar();
            MessageBox.Show("El registro se ha grabado correctamente..", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Lista();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Empleado objEmpleado = new Empleado();
                objEmpleado.Dni = txtDni.Text;
                objEmpleado.Nombre = txtNombre.Text;
                objEmpleado.Apellido = txtApellido.Text;
                objEmpleado.Email = txtEmail.Text;
                objEmpleado.Celular = txtCelular.Text;
                objEmpleado.Direccion = txtDireccion.Text;
                objEmpleado.Estado = Convert.ToChar(cmbEstado.Text);

                Empleados.Modificar(objEmpleado);
                Limpiar();
                MessageBox.Show("El registro se ha modificado correctamente..", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el registro...?", "gestion de categorias", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (id != 0)
                {
                    Empleados.Eliminar(id);
                    Limpiar();
                    MessageBox.Show("El registro se ha eliminado correctamente..", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Lista();
                }
            }
        }

        private void dgvLista_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    Obtener(id);
                }
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            FrmMenu Frm = new FrmMenu();
            this.Hide();
            Frm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
