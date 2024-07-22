using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IVendedorRepository:IRepositoryBase<Vendedor>
    {
        Vendedor? Get(string nombre);
    }
}
