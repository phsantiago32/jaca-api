using Jaca.Api.Models;
using Nancy;
using Nancy.ModelBinding;

namespace Jaca.Api.Controllers
{
    public class PromotionController : BaseController
    {
        public PromotionController() : base("merchant/{}promotions")
        {
            Get("{id}", args => this.PromotionManager.GetPromotion(args.id));

            Post("", _ => PromotionManager.CreatePromotion(this.Bind<Promotion>()));
        }
    }
}
