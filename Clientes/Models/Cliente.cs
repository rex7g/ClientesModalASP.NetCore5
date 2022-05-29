using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nombre Cliente")]
        [MinLength(1), MaxLength(40)]

        public string Nombre { get; set; }
        [Required]
        [DisplayName("Cedula")]
        [MinLength(1), MaxLength(30)]
        public string Cedula { get; set; }
        [Required]
        [DisplayName("Telefono")]
        [MinLength(1) ,MaxLength(20)]
        public string Telefono { get; set; }
        [Required]
        [DisplayName("Direccion")]
        [MinLength(1), MaxLength(80)]

        public string Direccion { get; set; }
        [Required]
        [DisplayName("Estado")]
        [MinLength(1), MaxLength(20)]

        public status Estado { get; set; }



    }
    public enum status
    {
        Inactivo,
        Activo
    }

}
