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
        [Required]
        public int AccountID { get; set; }
        [Required]
        public int RecordTypeId { get; set; }
        [Required]
        public int RecordSubcategoryId { get; set; }
        
        public virtual Account Account { get; set; }
        public virtual RecordType RecordType { get; set; }
        public virtual RecordSubcategory RecordSubcategory { get; set; }
    }
}
