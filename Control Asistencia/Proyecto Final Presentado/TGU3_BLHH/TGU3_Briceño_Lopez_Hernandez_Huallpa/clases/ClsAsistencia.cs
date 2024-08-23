using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGU3_Briceño_Lopez_Hernandez_Huallpa.DataClases;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa.clases
{
    public class ClsAsistencia
    {
        TablaAsistenciaDataContext dc = new TablaAsistenciaDataContext();
        //Implementar meytodos de crud

        public List<Asistencia> Listar()
        {
            List<Asistencia> ListaAsistencias = dc.Asistencia.ToList();
            return ListaAsistencias;
        }

        //metodo Insertar
        public void Insertar(Asistencia ObjEmpleados)
        {
            dc.Asistencia.InsertOnSubmit(ObjEmpleados);
            dc.SubmitChanges();
        }

    }
}
