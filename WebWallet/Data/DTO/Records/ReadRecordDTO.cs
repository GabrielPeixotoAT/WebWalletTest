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