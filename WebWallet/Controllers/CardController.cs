using Microsoft.AspNetCore.Mvc;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Controllers
{
    public class CardController : Controller
    {
        ICardService cardService;
        IUserService userService;

        public CardController(
            ICardService cardService,
            IUserService userService)
        {
            this.cardService = cardService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            CardViewModel model = new CardViewModel();

            model.Cards = cardService.GetAll(userService.GetUserId());

            return View(model);
        }
    }
}
