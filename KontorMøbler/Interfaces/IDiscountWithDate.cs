using System;

namespace Application
{
    internal interface IDiscountWithDate
    {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}