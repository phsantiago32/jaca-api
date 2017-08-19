using Jaca.Api.Models;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IUserRepository
    {
        bool IsValidLogin(string userName, string userPassword);

        void CreateOrUpdate(User user);
    }
}
