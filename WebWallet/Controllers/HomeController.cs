using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Models;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IAccountService accountService;

        public HomeController(ILogger<HomeController> logger, IAccountService accountService)
        {
            _logger = logger;
            this.accountService = accountService;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            model.Accounts = accountService.GetAll();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateAccount(CreateAccountDTO request)
        {
            ActionResult<CreateAccountDTO> result = accountService.Create(request);

            return Redirect("/");
        }
    }
}