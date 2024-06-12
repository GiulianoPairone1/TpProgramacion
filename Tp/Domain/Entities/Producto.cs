using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
