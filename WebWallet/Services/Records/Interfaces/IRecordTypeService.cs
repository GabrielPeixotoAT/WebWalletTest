using WebWallet.Data.DTO.RecordType;

namespace WebWallet.Services.Records.Interfaces
{
    public interface IRecordTypeService
    {
        List<ReadRecordTypeDTO> GetAll();
    }
}