using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

    }
}
