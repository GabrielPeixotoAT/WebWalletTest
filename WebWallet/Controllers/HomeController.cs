using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;
using WebWallet.Models;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        IAccountService accountService;
        IUserService userService;
        IRecordService recordService;
        IRecordSubcategoryService recordSubcategoryService;

        public HomeController(ILogger<HomeController> logger, 
            IAccountService accountService, IUserService userService, 
            IRecordService recordService, 
            IRecordSubcategoryService recordSubcategoryService)
        {
            this.logger = logger;
            this.accountService = accountService;
            this.userService = userService;
            this.recordService = recordService;
            this.recordSubcategoryService = recordSubcategoryService;
        }

        public IActionResult Index()
        {
            string userId = userService.GetUserId();

            HomeViewModel model = new HomeViewModel();

            model.Accounts = accountService.GetAll(userId);
            model.Records = recordService.GetAll(userId);
            model.Categories = recordSubcategoryService.GetAll();
            model.CalculateCategoriesSubtotal();

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