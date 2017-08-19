using Jaca.Api.Models;
using Nancy;
using Nancy.ModelBinding;

namespace Jaca.Api.Controllers
{
    public class PromotionController : BaseController
    {
        public PromotionController() : base("promotion")
        {
            Get("{id}", args => this.PromotionManager.GetPromotion(args.id));

            Post("", _ => PromotionManager.CreatePromotion(this.Bind<Promotion>()));

            Get("delete/{id}", args => PromotionManager.DeletePromotion(args.id));

            //Get("customer/{id}", args => PromotionManager.GetPromotionsByCustomer(args.id));
        }
    }
}
