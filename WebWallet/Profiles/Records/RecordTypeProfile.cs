using AutoMapper;
using WebWallet.Data.DTO.RecordType;
using WebWallet.Models.Records;

namespace WebWallet.Profiles.Records
{
    public class RecordTypeProfile : Profile
    {
        public RecordTypeProfile() 
        {
            CreateMap<RecordType, ReadRecordTypeDTO>();
        }
    }
}
