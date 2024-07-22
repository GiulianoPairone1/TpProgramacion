using Domain.Entities;
using Domain.IRepositories;
using Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class GerenteRepository: RepositoryBase<Gerente>, IGerenteRepository
    {
        private readonly StockDbContext _context;

        public GerenteRepository(StockDbContext context):base(context)
        {
            _context = context;
        }

        public Gerente? Get(string nombre)
        {
            return _context.Gerentes.FirstOrDefault(s => nombre == nombre);
        }
    }
}
