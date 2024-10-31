using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Portfolio
    {
        [Key]
        [Column("portfolio_id")]
        public int PortfolioId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("name", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        [Column("description", TypeName = "VARCHAR(500)")]
        public string Description { get; set; }

        [Column("created_date", TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        [Column("currency", TypeName = "VARCHAR(3)")]
        public string Currency { get; set; }

        public User User { get; set; }

        public ICollection<PortfolioAsset> PortfolioAssets { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
