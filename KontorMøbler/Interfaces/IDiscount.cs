using System;

namespace Application
{
    public interface IDiscount
    {
        //public bool SpecialProductOffer { get; set; }
        //public int Volume { get; set; }

        public DateTime ValidFrom{ get; set; }
        public DateTime ValidTo { get; set; }
        public bool Calculate();
    }
}