using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.DTO.Invoices;
using WebWallet.Data.DTO.InvoiceStatus;
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
        IInvoiceService invoiceService;
        IInvoiceStatusService invoiceStatusService;

        IUserService userService;

        public CardController(
            ICardService cardService,
            IBankService bankService,
            IInvoiceService invoiceService,
            IUserService userService,
            IInvoiceStatusService invoiceStatusService)
        {
            this.cardService = cardService;
            this.bankService = bankService;
            this.invoiceService = invoiceService;
            this.userService = userService;
            this.invoiceStatusService = invoiceStatusService;
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

            ReadCardDTO? card = cardService.ReadOne(id);

            if (card == null)
                return NotFound("Error: Card not Found");

            model.Card = card;
            model.Banks = bankService.GetAll(userID);
            model.Invoices = invoiceService.GetByCard(id, userID).OrderBy(invoice => invoice.DueDate).Take(2).ToList();

            return View(model);
        }

        public IActionResult CreateInvoice(CreateInvoiceDTO createInvoice)
        {
            string userID = userService.GetUserId();

            Result<CreateInvoiceDTO> result = invoiceService.Create(createInvoice, userID);

            if (result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect($"/Card/Details/{createInvoice.CardID}");
        }

        public IActionResult InvoiceDetails(int id)
        {
            string userID = userService.GetUserId();


            InvoiceDetailViewModel model = new InvoiceDetailViewModel();

            model.Invoice = invoiceService.GetByID(id, userID);
            model.Status = invoiceStatusService.GetAll();

            return View(model);
        }

        public IActionResult UpdateInvoice(UpdateInvoiceDTO updateInvoice)
        {
            string userID = userService.GetUserId();

            Result<UpdateInvoiceDTO> result = invoiceService.Update(updateInvoice, userID);

            if (result.HasError)
                return NotFound($"Error: {result.Message}");

            return Redirect("/Card/InvoiceDetails/");
        }
    }
}
