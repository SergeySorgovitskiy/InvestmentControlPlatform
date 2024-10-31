using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Transaction
    {
        [Key]
        [Column("transaction_id")]
        public int TransactionId { get; set; }

        [Required]
        [Column("portfolio_id")]
        public int PortfolioId { get; set; }

        [Required]
        [Column("asset_id")]
        public int AssetId { get; set; }

        [Required]
        [Column("transaction_type", TypeName = "VARCHAR(4)")]
        public string TransactionType { get; set; } // buy/sell 

        [Required]
        [Column("quantity", TypeName = "DECIMAL(18,4)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column("price", TypeName = "DECIMAL(18,4)")]
        public decimal Price { get; set; }

        [Required]
        [Column("date", TypeName = "DATETIME")]
        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Column("total_amount", TypeName = "DECIMAL(18,4)")]
        public decimal TotalAmount => Quantity * Price;

        public Portfolio Portfolio { get; set; }
        public Asset Asset { get; set; }
    }
}
