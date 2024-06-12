using Application.IRepositories;
using Application.IServices;
using Domain.DTOs;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductoService:IProductoService
    {
        private readonly IProductoRepository _repository;
        public ProductoService(IProductoRepository repository)
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
