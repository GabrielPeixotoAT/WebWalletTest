using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Data.Result;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Records.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService accountService;
        private IUserService userService;
        private IAccountTypeService accountTypeService;
        private IRecordService recordService;
        private IRecordTypeService recordTypeService;

        public AccountController(
            IAccountService accountService, 
            IUserService userService, 
            IAccountTypeService accountTypeService, 
            IRecordService recordService, 
            IRecordTypeService recordTypeService)
        {
            this.accountService = accountService;
            this.userService = userService;
            this.accountTypeService = accountTypeService;
            this.recordService = recordService;
            this.recordTypeService = recordTypeService;
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
                return NotFound();

            return Redirect("/");
        }

        public IActionResult Update(UpdateAccountDTO request)
        {
            Result<UpdateAccountDTO> result = accountService.Update(request);

            if(result.HasError)
                return NotFound();

            return Redirect("/");
        }

        public IActionResult Delete(int accountid)
        {
            bool result = accountService.Delete(accountid);

            return Redirect("/");
        }

        public IActionResult AccountDetail(int accountid)
        {
            string userId = userService.GetUserId();

            AccountDetailViewModel model = new AccountDetailViewModel();

            model.Account = accountService.GetByIDExternal(accountid);
            model.Records = recordService.GetByAccount(accountid);
            model.AccountType = accountTypeService.GetAll();
            model.RecordTypes = recordTypeService.GetAll();

            return View(model);
        }
    }
}
