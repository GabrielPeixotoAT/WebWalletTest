using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Records
{
    public class RecordType
    {
        [Key]
        [Required]
        public int RecordTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
