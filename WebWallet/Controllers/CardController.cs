﻿using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.Result;
using WebWallet.Models.ViewModels;
using WebWallet.Services.Auth.Interfaces;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Controllers
{
    public class CardController : Controller
    {
        ICardService cardService;
        IBankService bankService;

        IUserService userService;

        public CardController(
            ICardService cardService,
            IBankService bankService,
            IUserService userService)
        {
            this.cardService = cardService;
            this.userService = userService;
            this.bankService = bankService;
        }

        public IActionResult Index()
        {
            string userID = userService.GetUserId();

            CardViewModel model = new CardViewModel();

            model.Banks = bankService.GetAll(userID);
            model.Cards = cardService.GetAll(userID);

            return View(model);
        }

        public IActionResult Create(CreateCardDTO createCard)
        {
            string userID = userService.GetUserId();

            Result<CreateCardDTO> result = cardService.Create(createCard, userID);

            if (result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect("/Card");
        }

        public IActionResult Update(UpdateCardDTO updateCard)
        {
            string userID = userService.GetUserId();

            Result<UpdateCardDTO> result = cardService.Update(updateCard, userID);

            if (result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect($"/Card/Details/{updateCard.CardID}");
        }

        public IActionResult Delete(int id)
        {
            string userID = userService.GetUserId();

            Result result = cardService.Delete(id, userID);

            if (result.HasError)
                return NotFound($"Error: {result.Message}");
            
            return Redirect("/Card");
        }

        public IActionResult Details(int id)
        {
            string userID = userService.GetUserId();

            CardDetailViewModel model = new CardDetailViewModel();

            model.Card = cardService.ReadOne(id);
            model.Banks = bankService.GetAll(userID);

            return View(model);
        }
    }
}
