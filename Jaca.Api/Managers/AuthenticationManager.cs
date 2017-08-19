using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers
{
    public class AuthenticationManager : BaseManager, IAuthenticationManager
    {
        public BaseResponse<object> IsValidLogin(string login, string password)
        {
            var response = new BaseResponse<object>();

            var isValidLogin = this.UserRepository.IsValidLogin(login, password);

            if (isValidLogin)
            {
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.IsSuccess = true;

                return response;
            }

            response.StatusCode = System.Net.HttpStatusCode.NotFound;

            return response;
        }
    }
}
