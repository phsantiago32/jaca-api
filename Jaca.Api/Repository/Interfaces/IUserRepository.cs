using Jaca.Api.Models;

namespace Jaca.Api.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string userName, string userPassword);

        void CreateOrUpdate(User user);

        User GetLogin(string login);
    }
}
