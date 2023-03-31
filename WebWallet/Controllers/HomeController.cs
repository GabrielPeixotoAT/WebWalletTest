using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;
using WebWallet.Models;
using WebWallet.Models.ViewModels;
using WebWallet.Models.ViewModels.Builders;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        IAccountService accountService;
        IAccountTypeService accountTypeService;
        IUserService userService;
        IRecordService recordService;
        IRecordTypeService recordTypeService;
        IRecordSubcategoryService recordSubcategoryService;
        IRecordCategoryService recordCategoryService;

        public HomeController(ILogger<HomeController> logger, 
            IAccountService accountService, 
            IUserService userService, 
            IRecordService recordService, 
            IRecordSubcategoryService recordSubcategoryService,
            IRecordCategoryService recordCategoryService,
            IAccountTypeService accountTypeService,
            IRecordTypeService recordTypeService)
        {
            this.logger = logger;
            this.accountService = accountService;
            this.userService = userService;
            this.recordService = recordService;
            this.recordSubcategoryService = recordSubcategoryService;
            this.recordCategoryService = recordCategoryService;
            this.accountTypeService = accountTypeService;
            this.recordTypeService = recordTypeService;
        }

        public IActionResult Index()
        {
            string userId = userService.GetUserId();

            HomeViewModelBuilder builder = new HomeViewModelBuilder();

            builder.SetAccounts(accountService.GetAll(userId));
            builder.SetAccountTypes(accountTypeService.GetAll());
            builder.SetRecords(recordService.GetAll(userId));
            builder.SetRecordTypes(recordTypeService.GetAll());
            builder.SetRecordCategory(recordCategoryService.GetAll());
            builder.SetRecordSubcategory(recordSubcategoryService.GetAll());
            builder.CalculateValues();

            return View(builder.GetResult());
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