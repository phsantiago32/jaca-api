using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Djaka.Api.Models
{
    public class PromotionProgress
    {
        public string Id { get; set; }

        public string ClientId { get; set; }

        public string PromotionId { get; set; }

        public int Total { get; set; }

        public int Actual { get; set; }
    }
}
