using E_Commerce2.DAL;
using E_Commerce2.Interfaces;
using E_Commerce2.Models;

namespace E_Commerce2.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly IGenericRepository<CartItem> _cartItemRepository;
        public CartItemService(IGenericRepository<CartItem> cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public void AddCart(CartItem cartItem)
        {
            _cartItemRepository.Add(cartItem);
        }

        public bool AnyCartItemExists(int productId, string username)
        {
            return _cartItemRepository.Any(c => c.Username == username && c.ProductId == productId);
        }

        public void DeleteCart(CartItem cartItem)
        {
            _cartItemRepository.Delete(cartItem);
        }

        public IEnumerable<CartItem> GetAllCartItems(string username)
        {
            return _cartItemRepository.GetAllBy(x => x.Username == username);
        }

        public CartItem GetCartById(int id)
        {
            return _cartItemRepository.Get(id);
        }

        public CartItem GetCartByUsernameAndProduct(string username, int productId)
        {
            return _cartItemRepository.GetBy(c => c.Username == username && c.ProductId == productId);
        }

        public void UpdateCart(CartItem cartItem)
        {
            _cartItemRepository.Update(cartItem);
        }
    }
}
