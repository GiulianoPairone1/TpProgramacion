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
    internal class UserRepository : IUserRepository
    {
        private readonly StockDbContext _context;

        public UserRepository(StockDbContext context) 
        {
            _context = context;
        }

        public IEnumerable<UserDTO> GetList()
        {
            return _context.Users
                .Where(u => u.Activo)
                .Select(u => new UserDTO
                {
                    Id = u.Id,
                    Nombre = u.Nombre,
                    Email= u.Email,
                    UserType= u.UserType,
                }).ToList();
        }

        public bool Add(UserDTO user)
        {
            user.Id = Guid.NewGuid();
            var usu = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (usu != null)
            {
                return false;
            }

            _context.Users.Add(new User
            {
                Id = user.Id,
                Nombre= user.Nombre,
                Email= user.Email,
                Contraseña=user.Contraseña,
                UserType= user.UserType,
            });
            _context.SaveChanges();
            return true;
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

        public bool Delete (Guid id)
        {
            var us = _context.Users.FirstOrDefault(y => y.Id == id);
            if (us == null)
            {
                return false;
            }
            us.Activo = false;
            _context.SaveChanges();
            return true;
        }
    }
}
