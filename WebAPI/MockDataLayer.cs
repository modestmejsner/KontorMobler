using System;
using Application;

namespace WebAPI
{
    public class MockDataLayer
    {
        public static Customer[] Customers = new[]
       {
            new Customer() {Id = 0, Name = "Joe",    Spent = 0,     IsDiscountAgreement = false},
            new Customer() {Id = 1, Name = "John",   Spent = 1000,  IsDiscountAgreement = false},
            new Customer() {Id = 2, Name = "Joanna", Spent = 2000,  IsDiscountAgreement = false},
            new Customer() {Id = 3, Name = "Jason",  Spent = 5000,  IsDiscountAgreement = true },
            new Customer() {Id = 4, Name = "JayZ",   Spent = 8000,  IsDiscountAgreement = true },
            new Customer() {Id = 5, Name = "Jack",   Spent = 10000, IsDiscountAgreement = true },
        };

        public static readonly DiscountWithDate[] Discounts = new[]
        {
            new DiscountWithDate(Customers[0]){Id = 0, Name = "Joe_Discount",    Price = 0,   ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new DiscountWithDate(Customers[1]){Id = 1, Name = "John_Discount",   Price = 100, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new DiscountWithDate(Customers[2]){Id = 2, Name = "Joanna_Discount", Price = 200, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new DiscountWithDate(Customers[3]){Id = 3, Name = "Jason_Discount",  Price = 300, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new DiscountWithDate(Customers[4]){Id = 4, Name = "JayZ_Discount",   Price = 400, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},
            new DiscountWithDate(Customers[5]){Id = 5, Name = "Jack_Discount",   Price = 500, ValidFrom = DateTime.Now.AddDays(-1), ValidTo = DateTime.Now.AddDays(1)},

        };
    }
}
