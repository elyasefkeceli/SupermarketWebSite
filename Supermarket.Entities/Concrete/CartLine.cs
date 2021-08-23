using System;
using System.Text;

namespace Supermarket.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
