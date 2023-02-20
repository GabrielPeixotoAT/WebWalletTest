using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Accounts;

namespace WebWallet.Models.Records
{
    public class Record
    {
        [Key]
        [Required]
        public int RecordId { get; set; }
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
        
        public Account Account { get; set; }
        public RecordType RecordType { get; set; }
        public RecordSubcategory RecordSubcategory { get; set; }
    }
}
