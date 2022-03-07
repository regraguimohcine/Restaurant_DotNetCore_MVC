using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant_DotnetCoreMvc.Models;

namespace Restaurant_DotnetCoreMvc.Controllers
{
    public class ShopingCardsController : Controller
    {
        private readonly IPieRepository _pierepository;
        private readonly IShopingCardsRepository _shopingcardsrepository;

        public ShopingCardsController(IPieRepository pierepository, IShopingCardsRepository shopingcardsrepository)
        {
            _shopingcardsrepository=shopingcardsrepository;
            _pierepository = pierepository;
        }
        public IActionResult Index()
        {
            return View("Index", _shopingcardsrepository.ShopingCards);
        }

        public ActionResult Create(int id)
        {
            try
            {
                _shopingcardsrepository.AddToShopingCard(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _shopingcardsrepository.RemoveFromShopingCard(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult TotalShopingCards() {

            return View(_shopingcardsrepository.TotalOfShopingCards());
        }

    }
}
