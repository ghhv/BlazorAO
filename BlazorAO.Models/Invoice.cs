﻿using AO.Models;
using BlazorAO.Models.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAO.Models
{
    [UniqueConstraint(nameof(InvoiceNumber))]
    public class Invoice : BaseTable
    {
        [References(typeof(Client))]
        public int ClientId { get; set; }
                
        public int InvoiceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }        
    }
}
