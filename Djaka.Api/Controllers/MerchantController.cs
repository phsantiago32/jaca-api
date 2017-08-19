using Djaka.Api.Models;
using Nancy.ModelBinding;

namespace Djaka.Api.Controllers
{
    public class MerchantController : BaseController
    {
        public MerchantController() :base("merchants")
        {
            Get("{id}", args => this.MerchantManager.GetMerchant(args.id));

            Post("", _ => this.MerchantManager.CreateMerchant(this.Bind<Merchant>()));
        }
    }
}
