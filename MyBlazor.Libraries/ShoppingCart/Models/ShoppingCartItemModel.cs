using MyBlazor.Libraries.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Libraries.ShoppingCart.Models
{
    public class ShoppingCartItemModel
    {
        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            this.Product = product;
            this.Price = product.Price;
            Quantity = quantity;
        }

        public ProductModel Product { get; }

        public int Price { get; protected set; }

        public int Quantity { get; protected set; }

        public int TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity = quantity;
        }
    }

}
