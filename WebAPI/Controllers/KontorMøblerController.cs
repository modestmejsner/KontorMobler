using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KontorMøblerController : ControllerBase
    {
        private static readonly Customer[] Customers = new[]
        {
            new Customer() {Id = 1, Name = "Joe", Spent = 500, IsDiscountAgreement = true},
            new Customer() {Id = 2, Name = "John", Spent = 1000, IsDiscountAgreement = true},
            new Customer() {Id = 3, Name = "Joanna", Spent = 1500, IsDiscountAgreement = true},
            new Customer() {Id = 4, Name = "Jason", Spent = 2000, IsDiscountAgreement = true},
            new Customer() {Id = 5, Name = "JayZ", Spent = 2500, IsDiscountAgreement = true},
            new Customer() {Id = 6, Name = "Jack", Spent = 3000, IsDiscountAgreement = false},

        };

        private static readonly Discount[] Discounts = new[]
        {
            new Discount(Customers[0]){Id = 1, Name = "Discount1", Price = 100, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new Discount(Customers[1]){Id = 2, Name = "Discount2", Price = 200, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new Discount(Customers[2]){Id = 3, Name = "Discount3", Price = 300, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new Discount(Customers[3]){Id = 4, Name = "Discount4", Price = 400, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new Discount(Customers[4]){Id = 5, Name = "Discount5", Price = 500, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new Discount(Customers[5]){Id = 6, Name = "Discount6", Price = 600, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},

        };

        private readonly ILogger<KontorMøblerController> _logger;

        public KontorMøblerController(ILogger<KontorMøblerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    List<string> result = new List<string>();
        //    foreach (var discount in Discounts)
        //    {
        //        if (!discount.Calculate())
        //        {
        //            result.Add(discount.Name);
        //        }
        //    }
        //    return result;
        //}

        public IEnumerable<string> Get()
        {
            List<string> result = new List<string>();
            foreach (var customer in Customers)
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
