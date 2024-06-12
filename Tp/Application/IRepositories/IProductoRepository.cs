using Domain.DTOs;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IProductoRepository
    {
        IEnumerable<ProductoDTO> GetList();
        ProductoDTO GetById(Guid id);
        bool Create(ProductoViewModel producto);
        bool Update(ProductoViewModel producto);
        bool Desactive(Guid id);
        bool Active(Guid id);

    }
}
