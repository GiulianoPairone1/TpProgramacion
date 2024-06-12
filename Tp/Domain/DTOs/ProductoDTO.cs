using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ProductoDTO
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
}
