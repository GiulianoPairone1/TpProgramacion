using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IUserService
    {
        List<User> GetAll();
        public int Add (User user);
        bool Update(UserDTO user);
    }
}
