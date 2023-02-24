using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;
        
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
    }
}
