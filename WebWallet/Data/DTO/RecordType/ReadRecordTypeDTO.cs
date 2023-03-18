using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.RecordType
{
    public class ReadRecordTypeDTO
    {
        [Required]
        public int RecordTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
