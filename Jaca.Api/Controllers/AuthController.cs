using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jaca.Api.Controllers
{
    public class AuthController : BaseController
    {
        public AuthController() : base("auth")
        {
            Get("{login?}/{password?}", args => this.AuthManager.IsValidLogin(args.login, args.password));

            Get("recover/{login?}", args => this.AuthManager.RecoverLogin(args.login));
        }
    }
}