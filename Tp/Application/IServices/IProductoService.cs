using System;
using Domain.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ViewModels;

namespace Application.IServices
{
    public interface IProductoService
    {
        IEnumerable<ProductoDTO> GetList();
        ProductoDTO GetById(Guid id);
        bool Create (ProductoViewModel producto);
        bool Update (ProductoViewModel producto);
        bool Desactive (Guid id);
        bool Active(Guid id);

    }
}
