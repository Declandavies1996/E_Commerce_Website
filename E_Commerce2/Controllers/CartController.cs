using E_Commerce2.Interfaces;
using E_Commerce2.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce2.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartItemService _cartItemService;
        public CartController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }
        [HttpGet]
        [Route("Cart/ViewCart")]
        public IActionResult ViewCart()
        {
            return View(_cartItemService.GetAllCartItems(User.Identity.Name));
        }
        [HttpPost]
        [Route("Cart/AddToCart/{productId}")]
        public IActionResult AddToCart(int productId)
        {
            //Check If User Logged In
            if (!User.Identity.IsAuthenticated)
                return RedirectToPage("/Account/Login", new { area = "Identity" });

            //Check If Item Already In Cart
            if (_cartItemService.AnyCartItemExists(productId, User.Identity.Name))
            {
                //Get Existing Record
                var existingRecord = _cartItemService.GetCartByUsernameAndProduct(User.Identity.Name, productId);

                //Update Record Total Items In Cart
                existingRecord.Quantity++;

                //Update Record In Database
                _cartItemService.UpdateCart(existingRecord);
            }
            else
            {
                //Create New Cart Item
                var cartItem = new CartItem()
                {
                    ProductId = productId,
                    Quantity = 1,
                    Username = User.Identity.Name
                };

                //Add To Database 
                _cartItemService.AddCart(cartItem);
            }

            return Json(new { success = true, message = "Item added to cart successfully." });

        }
    }
}
