using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class VendedorDTO
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string CompleteName
        {
            get
            {
                return Nombre + "" + Apellido;
            }
        }
    }
}
