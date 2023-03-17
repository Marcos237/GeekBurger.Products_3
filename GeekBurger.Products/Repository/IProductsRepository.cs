using GeekBurger.Products.Model;

namespace GeekBurger.Products.Repository
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProductsByStoreName(string storeName);
        IEnumerable<Product> GetFullListOfItems();
        Product GetProductById(Guid id);
    }
}
