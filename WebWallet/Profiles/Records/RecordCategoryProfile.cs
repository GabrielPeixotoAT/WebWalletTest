using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebWallet.Data.DTO.RecordCategory;
using WebWallet.Models.Records;

namespace WebWallet.Profiles.Records
{
    public class RecordCategoryProfile : Profile
    {
        public RecordCategoryProfile()
        {
            CreateMap<RecordCategory, ReadRecordCategoryDTO>();
        }
    }
}