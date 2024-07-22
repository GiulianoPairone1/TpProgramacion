using Domain.DTOs;
using Domain.Entities;
using Domain.IRepositories;
using Domain.ViewModels;
using Infraestructure.Context;


namespace Infraestructure.Repositories
{ 
    public class ProductoRepository:IProductRepository
    {
        private readonly StockDbContext _context;
        public ProductoRepository(StockDbContext context)
        {
            _context = context;
        }

        public ProductoDTO GetById(Guid id) 
        {
            return _context.Productos
                .Where(y => y.Id == id)
                .Select(p => new ProductoDTO
                {
                    Id = p.Id,
                    Tipo = p.Tipo,
                    Activo = p.Activo,
                    Precio = p.Precio,
                }).FirstOrDefault();
        }

        public IEnumerable<ProductoDTO> GetList()
        {
            return _context.Productos
                .Where(p => p.Activo)
                .Select(p => new ProductoDTO
                {
                    Id = p.Id,
                    Tipo = p.Tipo,
                    Activo = p.Activo,
                    Precio= p.Precio,
                }).ToList();
        }

        public bool Create (ProductoViewModel producto)
        {
            producto.Id=Guid.NewGuid();
            var prod = _context.Productos.FirstOrDefault(p=>p.Id==producto.Id);
            if (prod != null) 
            {
                return false;
            }

            _context.Productos.Add(new Producto
            {
                Id = producto.Id,
                Tipo = producto.Tipo,
                Activo = producto.Activo,
                Precio = producto.Precio,
            });
            _context.SaveChanges();
            return true;
        }

        public bool Update (ProductoViewModel producto)
        {
            var prod = _context.Productos.FirstOrDefault(y=>y.Id==producto.Id);
            if (prod == null)
            {
                return false;
            }
            prod.Tipo = producto.Tipo;
            prod.Precio= producto.Precio;
            _context.SaveChanges();
            return true;
        }

        public bool Desactive (Guid id)
        {
            var prod = _context.Productos.FirstOrDefault(y=>y.Id==id);
            if (prod == null) 
            {
                return false;
            }
            prod.Activo = false;
            _context.SaveChanges();
            return true;
        }

        public bool Active(Guid id)
        {
            var prod = _context.Productos.FirstOrDefault(y => y.Id == id);
            if (prod == null)
            {
                return false;
            }
            prod.Activo = true;
            _context.SaveChanges();
            return true;
        }
    }
}
