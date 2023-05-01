using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.Result;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService accountService;
        private IUserService userService;
        private IAccountTypeService accountTypeService;
        private IRecordService recordService;
        private IRecordTypeService recordTypeService;
        private IRecordSubcategoryService recordSubcategoryService;

        public AccountController(
            IAccountService accountService, 
            IUserService userService, 
            IAccountTypeService accountTypeService, 
            IRecordService recordService, 
            IRecordTypeService recordTypeService, 
            IRecordSubcategoryService recordSubcategoryService)
        {
            this.accountService = accountService;
            this.userService = userService;
            this.accountTypeService = accountTypeService;
            this.recordService = recordService;
            this.recordTypeService = recordTypeService;
            this.recordSubcategoryService = recordSubcategoryService;
        }

        public IActionResult Index()
        {
            string userId = userService.GetUserId();

            AccountViewModel model = new AccountViewModel(accountService.GetAll(userId));
            model.AccountTypes = accountTypeService.GetAll();

            return View(model);
        }

        public IActionResult Create(CreateAccountDTO request)
        {
            request.UserId = userService.GetUserId();
            
            Result<CreateAccountDTO> result = accountService.Create(request);

            if(result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect("/");
        }

        public IActionResult Update(UpdateAccountDTO request)
        {
            request.UserId = userService.GetUserId();

            Result<UpdateAccountDTO> result = accountService.Update(request);

            if(result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect("/");
        }

        public IActionResult Delete(int accountid)
        {
            string userId = userService.GetUserId();

            Result result = accountService.Delete(accountid, userId);

            if (result.HasError)
                return NotFound();

            return Redirect("/") ;
        }

        public IActionResult AccountDetail(int accountid)
        {
            string userId = userService.GetUserId();

            AccountDetailViewModel model = new AccountDetailViewModel();

            ReadAccountDTO? account = accountService.ReadByID(accountid, userId);

            if(account == null)
                return NotFound("Account Not Found");

            model.Account = account;
            model.Records = recordService.GetByAccount(accountid);
            model.AccountType = accountTypeService.GetAll();
            model.RecordTypes = recordTypeService.GetAll();
            model.RecordSubcategories = recordSubcategoryService.GetAll();

            return View(model);
        }
    }
}
