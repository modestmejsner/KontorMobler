using System;

namespace Application
{
    public abstract class Discount : Product, IDiscount
    {
        private ICustomer _customer;
        //public bool SpecialProductOffer { get; set; } //In order to extend the Discount for a special product offer.
        public void IsDiscountAgreement(ICustomer customer)
        {
            if (customer.Spent > 2000)
            {
                _customer.IsDiscountAgreement = true;
            }
        }
        public Discount(ICustomer customer)
        {
            _customer = customer;
            IsDiscountAgreement(_customer);
        }
        public bool Calculate()
        {
            if (_customer.IsDiscountAgreement)
            {
                return CalculatePrice();
            }
            return false;
        }

        protected bool CalculatePrice()
        {
            var ToBeSpent = _customer.Spent + Price;
            if (ToBeSpent >= 2000 && ToBeSpent < 5000)
            {
                Price = Decimal.Multiply(Price, 0.9m);
                return true;
            }
            else if (ToBeSpent >= 5000 && ToBeSpent < 10000)
            {
                Price = Decimal.Multiply(Price, 0.8m);
                return true;
            }
            else if (ToBeSpent >= 10000)
            {
                Price = Decimal.Multiply(Price, 0.7m);
                return true;
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