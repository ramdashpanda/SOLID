using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    class InventoryManagement : IInventoryManagement
    {
        private IProductData _ProductDA;

        public InventoryManagement(IProductData productDA)
        {
            _ProductDA = productDA;
        }
        public List<Product> GetProducts()
        {
            return _ProductDA.GetProducts();
        }

        public Product GetProductByName(string name)
        {
            return _ProductDA.GetProductByName(name);
        }

        public decimal GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
