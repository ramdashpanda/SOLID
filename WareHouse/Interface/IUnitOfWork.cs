using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    interface IUnitOfWork
    {
        List<Product> GetAll();
        Product Get(string name);
        void Add(Product product);
    }
}
