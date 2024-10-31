using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class PortfolioAsset
    {
        [Key]
        [Column("portfolio_asset_id")]
        public int PortfolioAssetId { get; set; }

        [Required]
        [Column("portfolio_id")]
        public int PortfolioId { get; set; }

        [Required]
        [Column("asset_id")]
        public int AssetId { get; set; }

        [Required]
        [Column("quantity", TypeName = "DECIMAL(18,4)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column("purchase_price", TypeName = "DECIMAL(18,4)")]
        public decimal PurchasePrice { get; set; }

        [Column("purchase_date", TypeName = "DATETIME")]
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        [Column("current_price", TypeName = "DECIMAL(18,4)")]
        public decimal? CurrentPrice { get; set; }

        public Portfolio Portfolio { get; set; }
        public Asset Asset { get; set; }
    }
}
