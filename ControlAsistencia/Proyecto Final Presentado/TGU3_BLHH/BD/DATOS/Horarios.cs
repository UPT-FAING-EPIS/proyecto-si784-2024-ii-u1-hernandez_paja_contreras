namespace BD.DATOS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Horarios
    {
        [Key]
        public int IdHorario { get; set; }

        public int IdEmpleado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFin { get; set; }

        public TimeSpan? HoraEntrada { get; set; }

        public TimeSpan? HoraSalida { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
