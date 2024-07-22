using Application.IServices;
using Domain.Entities;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VendedorService:IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public Vendedor? Get (string nombre)
        {
            return _vendedorRepository.Get(nombre);
        }

        public List<Vendedor> GetAll()
        {
            return _vendedorRepository.GetAll();
        }

        public Vendedor Add (Vendedor vendedor)
        {
            return _vendedorRepository.Add(vendedor);
        }

        public int Update(Vendedor vendedor)
        {
            return _vendedorRepository.Update(vendedor);
        }

        public int Delete(Vendedor vendedor)
        {
            return _vendedorRepository.Delete(vendedor);
        }

        public Vendedor? GetById<Tid>(Tid id)
        {
            return _vendedorRepository.GetById(id); ;
        }
    }
}
