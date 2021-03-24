using NUnit.Framework;
using Moq;
using System;

namespace Application.Tests
{
    public class Tests
    {
        readonly Mock<ICustomer> customerMock = new Mock<ICustomer>();
        [SetUp]
        public void Setup()
        {
            customerMock.Setup(x => x.Spent).Returns(2500);
            customerMock.Setup(x => x.IsDiscountAgreement).Returns(true);
        }

        [Test]
        public void Calculate_PriceWhileSpentLowAtOnes_TheSmallestDiscount()
        {
            var priceExpected = 90;
            var discount = new Discount(customerMock.Object)
            {
                Price = 100,
                ValidFrom = DateTime.Now.AddDays(-1),
                ValidTo = DateTime.Now.AddDays(1),
            };
            _ = discount.Calculate();
            Assert.AreEqual(priceExpected, discount.Price);
        }

        [Test]
        public void Calculate_PriceWhileSpentHighAtOnes_TheHighestDiscount()
        {
            var priceExpected = 70000;

            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Spent).Returns(2500);
            customerMock.Setup(x => x.IsDiscountAgreement).Returns(true);
            var discount = new Discount(customerMock.Object)
            {
                Price = 100000,
                ValidFrom = DateTime.Now.AddDays(-1),
                ValidTo = DateTime.Now.AddDays(1),
            };
            _ = discount.Calculate();
            Assert.AreEqual(priceExpected, discount.Price);
        }

        [Test]
        public void Calculate_DiscountOutDated_NoneDiscount()
        {
            var priceExpected = 100;

            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Spent).Returns(2500);
            customerMock.Setup(x => x.IsDiscountAgreement).Returns(true);
            var discount = new Discount(customerMock.Object)
            {
                Price = 100,
                ValidFrom = DateTime.Now.AddDays(-2),
                ValidTo = DateTime.Now.AddDays(-1),
            };
            _ = discount.Calculate();
            Assert.AreEqual(priceExpected, discount.Price);
        }
    }
}
