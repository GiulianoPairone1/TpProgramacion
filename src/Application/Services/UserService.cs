using Application.IServices;
using Domain.DTOs;
using Domain.Entities;
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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService (IUserRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetAll()
        {
            return _repository.GetAll();
        }

        public int Add(User user)
        {
            return _repository.Add(user);
        }

        public bool Update(UserDTO user)
        {
            return _repository.Update(user);
        }

    }
}
