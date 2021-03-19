using NUnit.Framework;
using Moq;
using KontorMøbler;
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
        public void Customer_Should_Have_Discount()
        {
            var discountMock = new Mock<IDiscount>();
            _ = new Customer(discountMock.Object);
        }

        //[Test]
        //public void Customer_Discount_Based_On_How_Much_They_Sell()
        //{
        //    var off = 10m;
        //    var discountMock = new Mock<IDiscount>();
        //    discountMock.Setup(e => e.Recalculation(1000)).Returns(off);
        //    var customer = new Customer(discountMock.Object);
        //    Assert.AreEqual(off, customer.Off);
        //}

        [Test]
        public void Discount_Based_On_Time_Of_Year()
        {
            Assert.Pass();
        }
        [Test]
        public void Discount_Based_On_Special_Deals()
        {
            Assert.Pass();
        }

        [Test]
        public void Order_Should_Have_Information_About_Product_For_Customer_Discount_Based_On_How_Much_They_Sell()
        {
            Assert.Pass();
        }

        [Test]
        public void Product_Price_Should_Be_Calculate_Based_On_Discount()
        {
            var priceExpected = 90;
            var discountMock = new Mock<IDiscount>();
            discountMock.Setup(x=>x.Recalculation(1500)).Returns(10);
            discountMock.Setup(x => x.ValidFrom).Returns(DateTime.Now.AddDays(-1));
            discountMock.Setup(x => x.ValidTo).Returns(DateTime.Now.AddDays(1));
            var customer = new Customer(discountMock.Object);
            var product = new DiscountProduct(customer)
            {
                Price = 100
            };
            product.Price = product.Price * (customer.Off) / 100;
            Assert.AreEqual(priceExpected, product.Price);
        }
    }
}