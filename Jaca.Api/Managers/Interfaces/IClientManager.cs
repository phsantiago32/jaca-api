using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers.Interfaces
{
    public interface IClientManager
    {
        BaseResponse<object> GetClient(string id);

        BaseResponse<object> CreateClient(Client client);
    }
}
