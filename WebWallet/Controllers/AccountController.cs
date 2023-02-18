using Microsoft.AspNetCore.Mvc;
using WebWallet.Data;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Models.Accounts;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Controllers
{
    public class AccountController : Controller
    {
        ApplicationDbContext dbContext;
        IAccountService accountService;
        
        public AccountController(ApplicationDbContext dbContext, IAccountService accountService)
        {
            this.dbContext = dbContext;
            this.accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(CreateAccountDTO request)
        {
            ActionResult<CreateAccountDTO> result = accountService.Create(request);

            return new ViewResult();
        }
    }
}
