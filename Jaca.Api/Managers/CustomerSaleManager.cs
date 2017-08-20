using System;
using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models;
using Jaca.Api.Models.Response;

namespace Jaca.Api.Managers
{
    public class CustomerSaleManager : BaseManager, ICustomerSaleManager
    {
        public BaseResponse<object> GetSales(string merchantId)
        {
            var response = new BaseResponse<object>();

            var sales = this.CustomerSaleRepository.Get(merchantId);

            response.SuccessBody = sales;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            response.IsSuccess = true;
            return response;
        }
    }
}
