using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Libraries.Product.Models
{
    public interface IProductAddToCart
    {
        public ProductModel? Product { get; set; }

        public int? Quantity { get; set; }

        void AddToCart();
    }

}
 