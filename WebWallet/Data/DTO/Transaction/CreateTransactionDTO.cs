﻿using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Cards;
using WebWallet.Models.Records;

namespace WebWallet.Data.DTO.Transaction
{
    public class CreateTransactionDTO
    {
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public int InvoiceID { get; set; }
        [Required]
        public int RecordSubcategoryID { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
