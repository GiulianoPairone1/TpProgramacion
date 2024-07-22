using Application.IServices;
using Domain.Entities;
using Domain.IRepositories;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GerenteService: IGerenteService
    {
        private readonly IGerenteRepository _repository;

        public GerenteService(IGerenteRepository repository)
        {
            _repository = repository;
        }

        public Gerente? Get(string nombre)
        {
            return _repository.Get(nombre);
        }

        public List<Gerente> GetAll()
        {
            return _repository.GetAll();
        }

        public Gerente Add(Gerente gerente)
        {
            return _repository.Add(gerente);
        }

        public int Update(Gerente gerente)
        {
            return _repository.Update(gerente);
        }

        public int Delete(Gerente gerente)
        {
            return _repository.Delete(gerente);
        }

        public Gerente? GetById<Tid>(Tid id)
        {
            return _repository.GetById(id); ;
        }
    }
}
