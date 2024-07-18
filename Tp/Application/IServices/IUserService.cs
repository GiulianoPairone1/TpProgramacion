using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetList();
        bool Add(UserDTO user);
        bool Update(UserDTO user);
        bool Delete(Guid id);
    }
}
