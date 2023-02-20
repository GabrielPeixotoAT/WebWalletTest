using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Records
{
    public class RecordSubcategory
    {
        [Key]
        [Required]
        public int RecordSubcategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        
        public RecordCategory RecordCategory { get; set; }
    }
}
