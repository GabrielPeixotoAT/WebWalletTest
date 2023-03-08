using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Records
{
    public class UpdateRecordDTO
    {
        [Required]
        public int RecordId { get; set; }
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int AccountID { get; set; }
        [Required]
        public int RecordTypeId { get; set; }
        [Required]
        public int RecordSubcategoryId { get; set; }
    }
}
