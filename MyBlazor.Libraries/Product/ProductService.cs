using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.Storage;

namespace MyBlazor.Libraries.Product
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            this._storageService = storageService;
        }
        public IList<ProductModel> GetAll()
        {
            return _storageService.products.ToList();
        }

        public ProductModel? GetProduct(string sku)
        {
            return _storageService.products.FirstOrDefault(x => x.Sku == sku);
        }

        public ProductModel? GetProductBySlug(string slug)
        {
            return _storageService.products.FirstOrDefault(x => x.Slug == slug);
        }

        public IList<ProductModel> GetAll(int size, int pageId = 1)
        {
            var skip = size * (pageId - 1);
            return _storageService.products.Skip(skip).Take(size).ToList();
        }

        public int GetTotalPageCount(int size)
        {
            var count = _storageService.products.Count;

            return count > 0 ? (int)Math.Ceiling((decimal) count / size) : 1;
        }
    }
}
