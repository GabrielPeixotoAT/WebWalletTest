using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.RecordsSubcategories;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Services.Records
{
    public class RecordSubcategoryService : IRecordSubcategoryService
    {
        private ApplicationDbContext context;
        private IMapper mapper;

        public RecordSubcategoryService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadRecordSubcategoryDTO> GetAll()
        {
            return mapper.Map<List<ReadRecordSubcategoryDTO>>(
                context.RecordSubcategories.OrderBy(subCat => subCat.Description));
        }
    }
}
