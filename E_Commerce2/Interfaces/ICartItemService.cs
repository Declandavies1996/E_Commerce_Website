using E_Commerce2.Models;

namespace E_Commerce2.Interfaces
{
    public interface ICartItemService
    {
        void AddCart(CartItem cartItem);
        void UpdateCart(CartItem cartItem);
        void DeleteCart(CartItem cartItem);
        bool AnyCartItemExists(int productId, string username);
        CartItem GetCartById(int id);
        CartItem GetCartByUsernameAndProduct(string username, int productId);
        IEnumerable<CartItem> GetAllCartItems(string username);
    }
}
