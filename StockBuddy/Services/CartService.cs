using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBuddy.Services
{
    public class CartService
    {
        private readonly List<Item> _cart = new List<Item>();
        public IReadOnlyList<Item> Cart => _cart;

        public void AddItem(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (item.itemPrice < 0) throw new ArgumentOutOfRangeException(nameof(item.itemPrice));

            _cart.Add(item);
        }

        public bool RemoveLast()
        {
            if (_cart.Count == 0) return false;
            _cart.RemoveAt(_cart.Count - 1);
            return true;
        }

        public decimal Total()
        {
            return _cart.Sum(i => i.itemPrice);
        }

        public decimal TotalWithTax(decimal taxRate)
        {
            if (taxRate < 0 || taxRate > 1) throw new ArgumentOutOfRangeException(nameof(taxRate));
            var subtotal = Total();
            return subtotal + (subtotal * taxRate);
        }
    }
}

