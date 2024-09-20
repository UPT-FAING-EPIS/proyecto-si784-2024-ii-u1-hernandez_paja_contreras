namespace BD.DATOS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Puestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puestos()
        {
            Empleado_Puesto = new HashSet<Empleado_Puesto>();
        }

        [Key]
        public int IdPuesto { get; set; }

        [StringLength(50)]
        public string NombrePuesto { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado_Puesto> Empleado_Puesto { get; set; }
    }
}
