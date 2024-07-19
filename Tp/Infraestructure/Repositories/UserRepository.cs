using Domain.DTOs;
using Domain.Entities;
using Domain.IRepositories;
using Domain.ViewModels;
using Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StockDbContext _context;

        public UserRepository(StockDbContext context) 
        {
            _context = context;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public int Add(User user)

        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;

        }

        public bool Update(UserDTO user)
        {
            var us = _context.Users.FirstOrDefault(y => y.Id == user.Id);
            if (us == null)
            {
                return false;
            }

            us.Nombre = user.Nombre;
            us.Email = user.Email;
            us.Contraseña = user.Contraseña;

            _context.SaveChanges();
            return true;
        }

    }
}
