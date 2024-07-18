using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Producto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public double Precio { get; set; }

        public Producto()
        {

        }

    }
}
