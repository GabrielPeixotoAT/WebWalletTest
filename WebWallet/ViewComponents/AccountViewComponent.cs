using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWallet.Services.Accounts.Interfaces;
using WebWallet.Services.Auth.Interfaces;

namespace WebWallet.ViewComponents
{
    public class AccountViewComponent : ViewComponent
    {
        private IAccountService accountService;
        private IUserService userService;

        public AccountViewComponent(IAccountService accountService, IUserService userService)
        {
            this.accountService = accountService;
            this.userService = userService;
        }

        public IViewComponentResult Invoke()
        {
            string userId = userService.GetUserId();

            var result = accountService.GetAll(userId);

            return View(result);
        }
    }
}