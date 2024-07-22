using Domain.IRepositories;
using Application.IServices;
using Domain.DTOs;
using Domain.ViewModels;

namespace Application.Services
{  
    public class ProductoService:IProductoService
    {
        private readonly IProductRepository _repository;
        public ProductoService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProductoDTO> GetList()
        {
            return _repository.GetList();
        }

        public ProductoDTO GetById(Guid id) 
        {
            return _repository.GetById(id);
        }

        public bool Create (ProductoViewModel producto)
        {
            return _repository.Create(producto);
        }

        public bool Update (ProductoViewModel producto) 
        {
            return _repository.Update(producto);
        }

        public bool Desactive (Guid id)
        {
            return _repository.Desactive(id);
        }

        public bool Active(Guid id)
        {
            return _repository.Active(id);
        }

    }


}
