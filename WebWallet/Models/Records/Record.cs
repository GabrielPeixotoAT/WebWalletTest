using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Accounts;

namespace WebWallet.Models.Records
{
    public class Record
    {
        [Key]
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
        
        public virtual Account Account { get; set; }
        public virtual RecordType RecordType { get; set; }
        public virtual RecordSubcategory RecordSubcategory { get; set; }
    }
}
