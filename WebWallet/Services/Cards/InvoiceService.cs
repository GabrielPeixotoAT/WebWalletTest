using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.Bank;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.DTO.Invoices;
using WebWallet.Data.Result;
using WebWallet.Models.Cards;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Services.Cards
{
    public class InvoiceService : IInvoiceService
    {
        ApplicationDbContext context;
        IMapper mapper;

        IBankService bankService;
        ICardService cardService;

        public InvoiceService(
            ApplicationDbContext context,
            IMapper mapper,
            ICardService cardService,
            IBankService bankService)
        {
            this.context = context;
            this.mapper = mapper;
            this.cardService = cardService;
            this.bankService = bankService;
        }

        public Result<CreateInvoiceDTO> Create(CreateInvoiceDTO createInvoice, string userID)
        {
            List<ReadBankDTO> banks = bankService.GetAll(userID);

            ReadCardDTO? card = cardService.ReadOne(createInvoice.CardID);

            if (card == null)
                return new ErrorResult<CreateInvoiceDTO>(createInvoice, "Card not Found");

            Bank? bank = bankService.GetByID(card.BankID, userID);

            if (bank == null)
                return new ErrorResult<CreateInvoiceDTO>(createInvoice, "Bank not found");

            if (!(banks.Where(bk => bk.BankID == bank.BankID).Count() > 0))
                return new ErrorResult<CreateInvoiceDTO>(createInvoice, "Invalid request");

            context.Invoices.Add(mapper.Map<Invoice>(createInvoice));
            context.SaveChanges();

            return new SuccessResult<CreateInvoiceDTO>(createInvoice);
        }

        public List<ReadInvoiceDTO> GetByCard(int cardID, string userID)
        {
            return mapper.Map<List<ReadInvoiceDTO>>(context.Invoices
                .Where(invoice => invoice.CardID == cardID));
        }
    }
}