using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGU3_Briceño_Lopez_Hernandez_Huallpa.DataClases;

namespace TGU3_Briceño_Lopez_Hernandez_Huallpa.clases
{
    public class ClsEmpleados
    {
        TablaEmpleadoDataContext dc = new TablaEmpleadoDataContext();
        //Implementar meytodos de crud

        public List<Empleado> Listar()
        {
            List<Empleado> ListaEmpleados = dc.Empleado.ToList();
            return ListaEmpleados;
        }
        //metodo obtener
        public Empleado Obtener(int id)
        {
            Empleado ObjEmpleados = dc.Empleado.Single
                (c => c.IdEmpleado == id);
            return ObjEmpleados;
        }
        //metodo Insertar
        public void Insertar(Empleado ObjEmpleados)
        {
            dc.Empleado.InsertOnSubmit(ObjEmpleados);
            dc.SubmitChanges();
        }
        //metodo Modificar
        public void Modificar(Empleado ObjEmpleados)
        {
            Empleado ObjCateg = dc.Empleado.Single(c
                => c.IdEmpleado == ObjEmpleados.IdEmpleado);
            ObjCateg.Dni = ObjEmpleados.Dni;
            ObjCateg.Nombre = ObjEmpleados.Nombre;
            ObjCateg.Apellido = ObjEmpleados.Apellido;
            ObjCateg.Email = ObjEmpleados.Email;
            ObjCateg.Celular = ObjEmpleados.Celular;
            ObjCateg.Direccion = ObjEmpleados.Direccion;
            ObjCateg.Estado = ObjEmpleados.Estado;
            dc.SubmitChanges();

        }
        //metodo Eliminar
        public void Eliminar(int id)
        {
            Empleado ObjCategoria = dc.Empleado.Single(c
                => c.IdEmpleado == id);
            dc.Empleado.DeleteOnSubmit(ObjCategoria);
            dc.SubmitChanges();
        }
    }
}
