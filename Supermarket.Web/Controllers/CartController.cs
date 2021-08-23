using Microsoft.AspNetCore.Mvc;
using Supermarket.Business.Abstract;
using Supermarket.Entities.Concrete;
using Supermarket.Web.Models;
using Supermarket.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Web.Controllers
{
    public class CartController : Controller
    {
        ICartSessionService _cartSessionService;
        ICartService _cartService;
        IProductService _productService;

        public CartController(IProductService productService,ICartService cartService,ICartSessionService cartSessionService)
        {
            _productService = productService;
            _cartSessionService = cartSessionService;
            _cartService = cartService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product, {0} ,was successfully added to the cart!",productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }
        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }
        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product was successfully removed from the cart!"));
            return RedirectToAction("List");
        }
        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, you order is in process", shippingDetails.FirstName));
            return View();
        }
    }
}
