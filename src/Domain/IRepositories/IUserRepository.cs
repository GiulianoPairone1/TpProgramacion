using Domain.DTOs;
using Domain.Entities;

namespace Domain.IRepositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        public int Add(User user);
        bool Update(UserDTO user);

    }
}
