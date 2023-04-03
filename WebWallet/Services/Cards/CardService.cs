﻿using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.Bank;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.Result;
using WebWallet.Models.Cards;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Services.Cards
{
    public class CardService
    {
        ApplicationDbContext context;
        IMapper mapper;

        IBankService bankService;

        public CardService(
            ApplicationDbContext context,
            IMapper mapper, 
            IBankService bankService)
        {
            this.context = context;
            this.mapper = mapper;
            this.bankService = bankService;
        }

        public Result<CreateCardDTO> Create(CreateCardDTO createCard, string userID)
        {
            Card? card = GetByNumber(createCard.Number);

            if (card != null)
                return new ErrorResult<CreateCardDTO>(createCard, "This card is already registered");

            Bank? bank = bankService.GetByID(createCard.BankID, userID);

            if (bank == null)
                return new ErrorResult<CreateCardDTO>(createCard, "Bank not found");

            context.Cards.Add(mapper.Map<Card>(createCard));
            context.SaveChanges();

            return new SuccessResult<CreateCardDTO>(createCard);
        }

        public List<ReadCardDTO> GetAll(string userID)
        {
            List<ReadBankDTO> userBanks = bankService.GetAll(userID);

            List<ReadCardDTO> cards = new List<ReadCardDTO>();

            foreach (ReadBankDTO userBank in userBanks)
            {
                cards.AddRange(GetByBank(userBank.BankID));
            }

            return cards;
        }

        public List<ReadCardDTO> GetByBank(int bankID)
        {
            return mapper.Map<List<ReadCardDTO>>(context.Cards.Where(card => card.BankID == bankID));
        }

        public Result<UpdateCardDTO> Update(UpdateCardDTO updateCard, string userID)
        {
            List<ReadCardDTO> cards = GetAll(userID);
            
            Card? card = GetByID(updateCard.CardID);

            if (card == null)
                return new ErrorResult<UpdateCardDTO>(updateCard, "Card not found");

            card.BankID = updateCard.BankID;
            card.Number = updateCard.Number;
            card.ExpiringDate = updateCard.ExpiringDate;
            card.Limit = updateCard.Limit;
            card.InvoicesDueDate = updateCard.InvoicesDueDate;

            context.SaveChanges();

            return new SuccessResult<UpdateCardDTO>(updateCard);
        }

        Card? GetByNumber(string number)
        {
            return context.Cards.FirstOrDefault(card => card.Number == number);
        }

        Card? GetByID(int id)
        {
            return context.Cards.Find(id);
        }
    }
}
