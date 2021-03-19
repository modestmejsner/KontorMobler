using Application;
using System;

namespace KontorMøbler
{
    public class Customer : ICustomer
    {
        private IDiscount _discount;

        public int Type { get; set; }
        public decimal Spent { get; }
        public decimal Off { get; private set; }


        public Customer(IDiscount discount)
        {
            _discount = discount;
 
            if (Spent > 0)
            {
                Off = _discount.Recalculation(Spent);
            }
            if (!discount.IsValid(DateTime.Now))
            {
                Off = 0;
            }
        }
    }   
}
