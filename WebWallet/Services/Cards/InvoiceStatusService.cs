using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.InvoiceStatus;
using WebWallet.Services.Cards.Interfaces;

namespace WebWallet.Services.Cards
{
    public class InvoiceStatusService : IInvoiceStatusService
    {
        ApplicationDbContext context;
        IMapper mapper;

        public InvoiceStatusService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadInvoiceStatusDTO> GetAll()
        {
            return mapper.Map<List<ReadInvoiceStatusDTO>>(context.InvoiceStatus);
        }
    }
}