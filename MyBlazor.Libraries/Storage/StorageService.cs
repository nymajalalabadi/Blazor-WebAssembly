using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCart.Models;

namespace MyBlazor.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public StorageService()
        {
            products = new List<ProductModel>();

            ShoppingCart = new ShoppingCartModel();

            // Store a list of all the products for the online shop.
            AddProduct(new ProductModel("BUBBLES-GUMBALL-APRON", "A Gumball for Your Thoughts Apron", 24, "bubbles-gumball-apron-black.jpg"));

            AddProduct(new ProductModel("REX-MICROCONTROLLERS-APRON", "Great Microcontrollers Think Alike Apron", 24, "rex-microcontrollers-apron-black.jpg"));

            AddProduct(new ProductModel("DOLORES-COMPUTE-BASEBALLHAT", "I Compute, Therefore I Am Baseball Hat", 29, "dolores-compute-baseballhat-black.jpg"));

            AddProduct(new ProductModel("BUBBLES-GUMBALL-BASEBALLHAT", "A Gumball for Your Thoughts Baseball Hat", 29, "bubbles-gumball-baseballhat-black.jpg"));

            AddProduct(new ProductModel("REX-MICROCONTROLLERS-BASEBALLHAT", "Great Microcontrollers Think Alike Baseball Hat", 29, "rex-microcontrollers-baseballhat-black.jpg"));

            AddProduct(new ProductModel("DOLORES-COMPUTE-MUG", "I Compute, Therefore I Am Mug", 16, "dolores-compute-mug-black.jpg"));

            AddProduct(new ProductModel("DOLORES-COMPUTE-TSHIRT", "I Compute, Therefore I Am T-shirt", 26, "dolores-compute-tshirt-black.jpg"));

            AddProduct(new ProductModel("REX-MICROCONTROLLERS-TSHIRT", "Great Microcontrollers Think Alike T-shirt", 26, "rex-microcontrollers-tshirt-black.jpg"));
        }

        public IList<ProductModel> products { get; private set; }

        public ShoppingCartModel ShoppingCart { get; private set; }


        private void AddProduct(ProductModel product)
        {
            if (!products.Any(p => p.Sku == product.Sku))
            {

                products.Add(product);
            }
        }
    }
}
