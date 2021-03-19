using Application;
using System;

namespace KontorMøbler
{
    public class Discount : IDiscount
    {
        public int Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public bool IsValid(DateTime dateTime)
        {
            return (dateTime > ValidFrom && dateTime < ValidFrom);
        }

        public decimal Recalculation(decimal Spent)
        {
            if (Spent < 1000)
            {
                return 0M;
            }
            else if (Spent < 2000)
            {
                return 10M;
            }
            else if (Spent < 5000)
            {
                return 20M;
            }
            else if (Spent < 10000)
            {
                return 30M;
            }
            return 0;
        }
    }


}
