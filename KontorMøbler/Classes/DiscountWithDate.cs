using System;

namespace Application
{
    public class DiscountWithDate : Discount, IDiscountWithDate
    {
        private ICustomer _customer;
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DiscountWithDate(ICustomer customer) : base(customer) => _customer = customer;

        public new bool Calculate()
        {
            if (DateTime.Now >= ValidFrom && DateTime.Now < ValidTo && _customer.IsDiscountAgreement)
            {
                return CalculatePrice();
            }
            return false;
        }
    }
}
