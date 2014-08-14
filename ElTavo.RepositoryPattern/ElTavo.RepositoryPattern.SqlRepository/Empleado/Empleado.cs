using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElTavo.RepositoryPattern.SqlRepository.Empleado
{
    [Table("Empleados")]
    public partial class Empleado
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }
    }
}
