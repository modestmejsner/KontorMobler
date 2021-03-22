using NUnit.Framework;
using Moq;
using System;

namespace Application.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Discount_Price_Should_Be_Calculate_Based_On_Customer_Spent_Low_At_Ones()
        {
            var priceExpected = 90;

            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Spent).Returns(2500);
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
        public void Discount_Price_Should_Be_Calculate_Based_On_Customer_Spent_Huge_At_Ones()
        {
            var priceExpected = 70000;

            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Spent).Returns(2500);
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
        public void Discount_Price_Should_Be_The_Same_Time_Out_Of_Dated()
        {
            var priceExpected = 100;

            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Spent).Returns(2500);
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
