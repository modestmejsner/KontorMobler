using System;

namespace Application
{
    public interface IDiscount
    {
        public int Type { get; set; }
        public decimal Amount { get; set; }

        public DateTime ValidFrom{ get; set; }
        public DateTime ValidTo { get; set; }

        bool IsValid(DateTime dateTime);

        decimal Recalculation(decimal Spent);
    }
}