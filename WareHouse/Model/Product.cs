using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MRP { get; set; }
    }

    public class Soap : Product, IPrice
    {
        public decimal GetPrice()
        {
            return (MRP * 0.9M);
        }
    }

    public class ToothPaste : Product, IPrice
    {
        public decimal GetPrice()
        {
            return (MRP * 0.8M);
        }
    }

    interface IPrice
    {        
        decimal GetPrice();
    }
}
