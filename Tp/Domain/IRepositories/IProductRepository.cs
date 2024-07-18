using Domain.DTOs;
using Domain.ViewModels;

namespace Domain.IRepositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductoDTO> GetList();
        ProductoDTO GetById(Guid id);
        bool Create(ProductoViewModel producto);
        bool Update(ProductoViewModel producto);
        bool Desactive(Guid id);
        bool Active(Guid id);
    }
}
