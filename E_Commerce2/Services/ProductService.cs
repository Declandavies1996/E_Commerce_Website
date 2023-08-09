using E_Commerce2.DAL;
using E_Commerce2.Interfaces;
using E_Commerce2.Models;

namespace E_Commerce2.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;
        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _productRepository.Delete(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.Get(id);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
