using E_Commerce2.Models;

namespace E_Commerce2.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product); 
        void DeleteProduct(Product product);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();

    }
}
