namespace BD.DATOS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleado_Puesto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPuesto { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Puestos Puestos { get; set; }
    }
}
