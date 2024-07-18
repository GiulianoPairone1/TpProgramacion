using Domain.DTOs;

namespace Domain.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<UserDTO> GetList();
        bool Add (UserDTO user);
        bool Update(UserDTO user);
        bool Delete (Guid id);

    }
}
