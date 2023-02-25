using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.Result;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService accountService;
        
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(CreateAccountDTO request)
        {
            ActionResult<CreateAccountDTO> result = accountService.Create(request);

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
