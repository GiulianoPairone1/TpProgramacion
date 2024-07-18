using Application.IServices;
using Domain.DTOs;
using Domain.IRepositories;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService (IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<UserDTO> GetList()
        {
            return _repository.GetList();
        }

        public bool Add(UserDTO user)
        {
            return _repository.Add(user);
        }

        public bool Update(UserDTO user)
        {
            return _repository.Update(user);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }
    }
}
