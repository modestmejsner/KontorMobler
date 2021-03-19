using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public abstract class Product
    {
        public decimal Price { get; set; }
    }

    public class DiscountProduct : Product
    {
        private ICustomer _customer;
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public DiscountProduct(ICustomer customer)
        {
            _customer = customer;
        }
    }
}
