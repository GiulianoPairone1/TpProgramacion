using Domain.Entities;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IGerenteService:IRepositoryBase<Gerente>
    {
        public Gerente? Get(string nombre);
    }
}
