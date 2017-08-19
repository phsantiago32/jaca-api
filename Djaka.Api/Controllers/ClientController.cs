using Djaka.Api.Models;
using Nancy.ModelBinding;

namespace Djaka.Api.Controllers
{
    public class ClientController : BaseController
    {
        public ClientController() : base("clients")
        {
            Get("{id}", args => this.ClientManager.GetClient(args.id));

            Post("", _ => this.ClientManager.CreateClient(this.Bind<Client>()));
        }
    }
}
