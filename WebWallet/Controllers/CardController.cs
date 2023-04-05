using Microsoft.AspNetCore.Mvc;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Controllers
{
    public class CardController : Controller
    {
        ICardService cardService;
        IBankService bankService;

        IUserService userService;

        public CardController(
            ICardService cardService,
            IBankService bankService,
            IUserService userService)
        {
            this.cardService = cardService;
            this.userService = userService;
            this.bankService = bankService;
        }

        public IActionResult Index()
        {
            string userID = userService.GetUserId();

            CardViewModel model = new CardViewModel();

            model.Banks = bankService.GetAll(userID);
            model.Cards = cardService.GetAll(userID);

            return View(model);
        }
    }
}
