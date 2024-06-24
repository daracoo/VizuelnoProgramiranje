using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Item
    {
        Product Product { get; set; }
        public int Quantity {  get; set; }

        public Item(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} X {2} = {3}", Product.Name, Product.Price, Quantity, Product.Price * Quantity);
        }

        public int Price()
        {
            return Product.Price * Quantity;
        }
    }
}
