using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.RecordType;
using WebWallet.Services.Records.Interfaces;

namespace WebWallet.Services.Records
{
    public class RecordTypeService : IRecordTypeService
    {
        private ApplicationDbContext context;
        private IMapper mapper;

        public RecordTypeService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadRecordTypeDTO> GetAll()
        {
            return mapper.Map<List<ReadRecordTypeDTO>>(context.RecordTypes);
        }
    }
}
