using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGU3_Briceño_Lopez_Hernandez_Huallpa.clases;
using TGU3_Briceño_Lopez_Hernandez_Huallpa.DataClases;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa
{
    public partial class FrmAsistenciaE : Form
    {
        private static int id = 0;
        private ClsAsistencia Asistencia = new ClsAsistencia();
        public FrmAsistenciaE()
        {
            InitializeComponent();
            Lista();
        }
        private void Lista()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.DataSource = Asistencia.Listar();
        }

        public void ConsultaProducto1(string Busqueda)
        {
            //1.Conexion con el otrigen de la fuente de datos
            DataClasesResumenDataContext dc = new DataClasesResumenDataContext();
            //2
            var query = (from u in dc.SP_Asistencia_Empleado(Busqueda) select u).ToList();


            dgvLista.DataSource = query;
        }
        public void ConsultaProducto2(string Busqueda)
        {
            ////1.Conexion con el otrigen de la fuente de datos
            //DataClasesResumenDataContext dc = new DataClasesResumenDataContext();
            ////2
            //var query = new List<SP_Buscar_Producto_ContainsResult>();

            //query = dc.SP_Buscar_Producto_Contains(Busqueda).ToList();


            //dgvLista.DataSource = query;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar;
            Buscar = txtBuscar.Text;
            ConsultaProducto1(Buscar);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenu Frm = new FrmMenu();
            this.Hide();
            Frm.Show();
        }
    }
}
