using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestmentControlPlatform.DataAccess.Models
{
    public class AssetPrice
    {
        [Key]
        [Column("asset_price_id")]
        public int AssetPriceId { get; set; }

        [Required]
        [Column("asset_id")]
        public int AssetId { get; set; }

        [Required]
        [Column("date", TypeName = "DATETIME")]
        public DateTime Date { get; set; }

        [Required]
        [Column("open_price", TypeName = "DECIMAL(18,4)")]
        public decimal OpenPrice { get; set; }

        [Required]
        [Column("close_price", TypeName = "DECIMAL(18,4)")]
        public decimal ClosePrice { get; set; }

        [Column("high_price", TypeName = "DECIMAL(18,4)")]
        public decimal HighPrice { get; set; }

        [Column("low_price", TypeName = "DECIMAL(18,4)")]
        public decimal LowPrice { get; set; }

        [Column("volume", TypeName = "BIGINT")]
        public long Volume { get; set; }

        public Asset Asset { get; set; }
    }
}
