using Domain.Entities;
using Domain.IRepositories;
using Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infraestructure.Repositories
{
    public class VendedorRepository: RepositoryBase<Vendedor> , IVendedorRepository
    {
        private readonly StockDbContext _context;
        public VendedorRepository(StockDbContext context):base(context) 
        {
            _context = context;
        }

        public Vendedor? Get(string nombre)
        {
            return _context.Vendedors.FirstOrDefault(s => s.Nombre == nombre);
        }
    }
}
