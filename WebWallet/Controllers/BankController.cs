using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Bank;
using WebWallet.Data.Result;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Controllers
{
    public class BankController : Controller
    {
        IUserService userService;

        IBankService bankService;

        public BankController(
            IUserService userService,
            IBankService bankService)
        {
            this.userService = userService;
            this.bankService = bankService;
        }

        public IActionResult Create(CreateBankDTO createBank)
        {
            string userID = userService.GetUserId();

            createBank.UserID = userID;

            Result<CreateBankDTO> result = bankService.Create(createBank);

            if(result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect("/Card");
        }

    }
}