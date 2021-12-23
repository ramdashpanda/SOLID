﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    interface IProductData
    {
        List<Product> GetProducts();
        Product GetProductByName(string name);

    }
}
