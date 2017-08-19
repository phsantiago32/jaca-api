using Jaca.Api.Factory;
using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models.Response;
using Jaca.Api.Utilities.Interfaces;
using Nancy;

namespace Jaca.Api.Controllers
{
    public abstract class BaseController : NancyModule
    {
        public BaseController(string modulePath) : base(modulePath) { }

        private IMerchantManager _merchantManager = null;
        public IMerchantManager MerchantManager
        {
            get
            {
                if (this._merchantManager == null)
                {
                    this._merchantManager = GlobalFactory.Do<IMerchantManager>();
                }

                return this._merchantManager;
            }
        }

        private IClientManager _clientManager = null;
        public IClientManager ClientManager
        {
            get
            {
                if (this._clientManager == null)
                {
                    this._clientManager = GlobalFactory.Do<IClientManager>();
                }

                return this._clientManager;
            }
        }

        private IPromotionManager _promotionManager = null;
        public IPromotionManager PromotionManager
        {
            get
            {
                if (this._promotionManager == null)
                {
                    this._promotionManager = GlobalFactory.Do<IPromotionManager>();
                }

                return this._promotionManager;
            }
        }

        private IPromotionProgressManager _promotionProgressManager = null;
        public IPromotionProgressManager PromotionProgressManager
        {
            get
            {
                if (this._promotionProgressManager == null)
                {
                    this._promotionProgressManager = GlobalFactory.Do<IPromotionProgressManager>();
                }

                return this._promotionProgressManager;
            }
        }

        public object CreateJsonResponse(BaseResponse<object> response)
        {
            HttpStatusCode statusCode = GlobalFactory.Do<IEnumUtility>().Convert<HttpStatusCode>(response.StatusCode);
            Nancy.Response httpResponse = null;

            if (response.IsSuccess == true)
            {
                httpResponse = Response.AsJson(response.SuccessBody, statusCode);
            }
            else
            {
                httpResponse = Response.AsJson(response.ErrorBody, statusCode);
            }

            return httpResponse;
        }
    }
}
