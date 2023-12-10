using Microsoft.AspNetCore.Mvc;

namespace Music_Shop.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            Cart.ClearCart();
            return View();
        }
    }
}
