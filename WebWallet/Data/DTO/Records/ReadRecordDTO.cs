using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebWallet.Data.DTO.Records
{
    public class ReadRecordDTO
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