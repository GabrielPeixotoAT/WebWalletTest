using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.Result;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService accountService;
        private IUserService userService;
        
        public AccountController(IAccountService accountService, IUserService userService)
        {
            this.accountService = accountService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            string userId = userService.GetUserId();

            AccountViewModel model = new AccountViewModel(accountService.GetAll(userId));

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
    }
}
