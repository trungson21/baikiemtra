using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra
{
    internal class Shoppingcart
    {
        public List<Product> Products { get; private set; }

        public Shoppingcart()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public decimal GetTotalAmount()
        {
            return Products.Sum(p => p.Price * p.Quantity);
        }

        public int GetTotalQuantity()
        {
            return Products.Sum(p => p.Quantity);
        }

        public void Clear()
        {
            Products.Clear();
        }
    }
}
