using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    interface IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
