using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.RecordCategory;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Services.Records
{
    public class RecordCategoryService : IRecordCategoryService
    {
        private ApplicationDbContext context;
        private IMapper mapper;

        public RecordCategoryService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadRecordCategoryDTO> GetAll()
        {
            return mapper.Map<List<ReadRecordCategoryDTO>>(context.RecordCategories);
        }
    }
}