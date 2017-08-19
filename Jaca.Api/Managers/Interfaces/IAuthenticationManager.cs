using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface IAuthenticationManager
    {
        BaseResponse<object> IsValidLogin(string login, string password);

        BaseResponse<object> RecoverLogin(string login);
    }
}
