using AutoMapper;
using WebWallet.Data.DTO.Records;
using WebWallet.Models.Records;

namespace WebWallet.Profiles.Records
{
    public class RecordProfile : Profile
    {
        public RecordProfile() 
        {
            CreateMap<Record, ReadRecordDTO>();
            CreateMap<CreateRecordDTO, Record>();
        }
    }
}
