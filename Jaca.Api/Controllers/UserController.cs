using Microsoft.AspNetCore.Mvc;

namespace Jaca.Api.Controllers
{
    public class UserController : BaseController
    {
        public UserController() : base("user")
        {
            //Get("{login?}", args => this.AuthManager.IsValidLogin(args.login));
        }
    }
}