using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class Asset
    {
        [Key]
        [Column("asset_id")]
        public int AssetId { get; set; }

        [Required]
        [Column("symbol", TypeName = "VARCHAR(10)")]
        public string Symbol { get; set; }

        [Required]
        [Column("name", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        [Required]
        [Column("type", TypeName = "VARCHAR(50)")]
        public string Type { get; set; }

        [Column("sector", TypeName = "VARCHAR(100)")]
        public string Sector { get; set; }

        [Column("exchange", TypeName = "VARCHAR(100)")]
        public string Exchange { get; set; }

        [Required]
        [Column("currency", TypeName = "VARCHAR(3)")]
        public string Currency { get; set; }

        public ICollection<PortfolioAsset> PortfolioAssets { get; set; }
        public ICollection<AssetPrice> AssetPrices { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Forecast> Forecasts { get; set; }
    }
}
