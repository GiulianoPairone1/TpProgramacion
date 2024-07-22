using Domain.Entities;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IVendedorService : IRepositoryBase<Vendedor>
    {
        public Vendedor? Get(string Nombre);
    }
}
