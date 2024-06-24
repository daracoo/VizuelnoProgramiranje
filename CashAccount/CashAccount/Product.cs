using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product
    {
        public string Code {  get; set; }
        public string Name { get; set; }
        public int Price {  get; set; }

        public Product(string code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} {2}", Code, Name, Price);
        }
    }
}
