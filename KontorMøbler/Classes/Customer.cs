namespace Application
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Spent { get; set; }
        public bool IsDiscountAgreement { get; set; }
    }
}
