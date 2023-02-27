using WebWallet.Data.DTO.RecordsSubcategories;

namespace WebWallet.Services.Records.Interfaces
{
    public interface IRecordSubcategoryService
    {
        List<ReadRecordSubcategoryDTO> GetAll();
    }
}