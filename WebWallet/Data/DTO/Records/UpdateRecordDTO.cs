using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Records
{
    public class UpdateRecordDTO
    {
        [Required]
        public int RecordID { get; set; }
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int AccountID { get; set; }
        [Required]
        public int RecordTypeID { get; set; }
        [Required]
        public int RecordSubcategoryID { get; set; }
    }
}
