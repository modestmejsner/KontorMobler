using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KontorMoblerController : ControllerBase
    {
        private readonly ILogger<KontorMoblerController> _logger;

        public KontorMoblerController(ILogger<KontorMoblerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> result = new List<string>();
            foreach (var discount in MockDataLayer.Discounts)
            {
                if (!discount.Calculate())
                {
                    result.Add(discount.Name);
                }
            }
            return result;
        }

        [HttpPost]
        public IEnumerable<string> Post()
        {
            List<string> result = new List<string>();
            foreach (var customer in MockDataLayer.Customers)
            {
                if (customer.IsDiscountAgreement)
                {
                    result.Add(customer.Name);
                }
            }
            return result;
        }
    }
}
