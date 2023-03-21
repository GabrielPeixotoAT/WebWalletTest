using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Records
{
    public class RecordSubcategory
    {
        [Key]
        [Required]
        public int RecordSubcategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public int RecordCategoryID { get; set; }
        public virtual RecordCategory RecordCategory { get; set; }
    }
}
