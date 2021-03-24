namespace Application
{
    internal interface IDiscount
    {
        public int Id { get; set; }
        //public bool SpecialProductOffer { get; set; }
        //public int Volume { get; set; }
        public void IsDiscountAgreement(ICustomer customer);
        public bool Calculate();
    }
}