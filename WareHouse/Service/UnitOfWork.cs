using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    class UnitOfWork : IUnitOfWork
    {
        protected List<Product> Products;
        public UnitOfWork(List<Product> products)
        {
            Products = products;
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public Product Get(string name)
        {
            return Products.Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return Products;
        }
    }
}
