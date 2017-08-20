using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jaca.Api.Controllers
{
    public class CustomerSaleController : BaseController
    {
        public CustomerSaleController() : base("customersale")
        {
            Get("{merchantId}", args => this.CustomerSaleManager.GetSales(args.merchantId));
        }
    }
}