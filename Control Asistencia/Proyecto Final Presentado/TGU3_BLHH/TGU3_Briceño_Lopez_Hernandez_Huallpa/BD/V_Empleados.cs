namespace TGU3_Briceño_Lopez_Hernandez_Huallpa.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Empleados
    {
        [Key]
        [Column(Order = 0)]
        public int IdEmpleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Dni { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string Apellido { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(11)]
        public string Celular { get; set; }

        [Column(TypeName = "text")]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
