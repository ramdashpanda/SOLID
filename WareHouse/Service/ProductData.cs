using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    class ProductData : UnitOfWork, IProductData
    {
        private List<Product> products;

        public ProductData(List<Product> Products) : base(Products)
        {
            
        }
        public List<Product> GetProducts()
        {
            return GetAll();
        }

        public Product GetProductByName(string name)
        {
            var product = Get(name);
            return product;
        }

    }
}
