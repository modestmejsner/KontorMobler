using System;

namespace Application
{
    public class Discount : Product, IDiscount
    {
        private ICustomer _customer;
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        //public bool SpecialProductOffer { get; set; } //In order to extend the Discount for a special product offer.
        public Discount(ICustomer customer)
        {
            _customer = customer;
        }

        public bool Calculate()
        {
            if (DateTime.Now >= ValidFrom && DateTime.Now < ValidTo && _customer.IsDiscountAgreement)
            {
                var Spent = _customer.Spent + Price;
                if (Spent >= 2000 && Spent < 5000)
                {
                    Price = Decimal.Multiply(Price, 0.9m);
                    return true;
                }
                else if (Spent >= 5000 && Spent < 10000)
                {
                    Price = Decimal.Multiply(Price, 0.8m);
                    return true;
                }
                else if (Spent >= 10000)
                {
                    Price = Decimal.Multiply(Price, 0.7m);
                    return true;
                }
                //if (SpecialProductOffer) //In order to extend the Discount for a special product offer. 
                //{
                //    Price /= 2;
                //    return true; 
                //}
            }
            //if (SpecialProductOffer) //In order to extend the Discount for a special product offer.
            //{
            //    Price /= 2;
            //    return true; 
            //}
            return false;
        }
    }
}
