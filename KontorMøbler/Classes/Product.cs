using System;

namespace Application
{
    public  class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Discount : Product, IDiscount
    {
        private ICustomer _customer;
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        //public bool SpecialProductOffer { get; set; }
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
                //if (SpecialProductOffer)
                //{
                //    Price /= 2;
                //    return true; 
                //}
            }
            //if (SpecialProductOffer)
            //{
            //    Price /= 2;
            //    return true; 
            //}
            return false;
        }
    }
}
