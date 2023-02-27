using AutoMapper;
using WebWallet.Data.DTO.RecordsSubcategories;
using WebWallet.Models.Records;

namespace WebWallet.Profiles.Records
{
    public class RecordSubcategoryProfile : Profile
    {
        public RecordSubcategoryProfile() 
        { 
            CreateMap<RecordSubcategory, ReadRecordSubcategoryDTO>();
        }
    }
}
