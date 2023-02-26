using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Models;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;

namespace WebWallet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        IAccountService accountService;
        IUserService userService;

        public HomeController(ILogger<HomeController> logger, IAccountService accountService, IUserService userService)
        {
            this.logger = logger;
            this.accountService = accountService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var userId = userService.GetUserId();

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
    }
}