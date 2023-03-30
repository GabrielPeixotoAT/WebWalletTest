using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWallet.Data.DTO.RecordCategory;

namespace WebWallet.Services.Records.Interfaces
{
    public interface IRecordCategoryService
    {
        List<ReadRecordCategoryDTO> GetAll();
    }
}