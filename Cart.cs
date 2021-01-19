using System.Collections.Generic;

namespace SkuProblem
{
    public class Cart
    {
        public List<Sku> CartItems { get; private set; }
        public Cart() {
            CartItems = new List<Sku>();
        }

        public void AddToCart(Sku sku)
        {
            CartItems.Add(sku);
        }

        public void AddToCart(IEnumerable<Sku> skus)
        {
            CartItems.AddRange(skus);
        }
    }
}
